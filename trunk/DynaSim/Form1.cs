﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DynaSim
{
    /// <summary>
    /// Primary GUI class.
    /// </summary>
    public partial class Form1 : Form
    {
        private uint currentX = 0;

        /// <summary>
        /// Equation builder instance, "eb"
        /// </summary>
        EquationBuilder eb;
        /// <summary>
        /// Simulation Engine instance, "se"
        /// </summary>
        SimEngine se;

        /// <summary>
        /// GUI class constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            eb = new EquationBuilder();
            se = new SimEngine(new SimEngine.dataPreparedDelegate(this.OnDataPrepared));
            this.cmbMasterTimeUnit.SelectedIndex = 6;
        }

        /// <summary>
        /// Extract the current named variables for use in some combo-box interaction options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interactionsTabPage_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
            List<string> namedVariablesAndConstants = new List<string>();
            //Use the input DataGridView to populate the interaction DataGridView, preserve existing interactions.
            string eq = "";
            if (!eb.BuildEquationFromDataGridView(this.dgvVariables, ref eq))
                MessageBox.Show("Invalid data in Graph tab DataGridView.");
            else
            {
                namedVariablesAndConstants.Clear();
                //first token of every line of eq goes into:
                //cmbInteractionsPageToInteract
                //cmbInteractionsPageToInteractWith
                //cmbInteractionsPageToInteractWithViaConstant
                //and the combo box at index 1 in the DataGridView.
                string[] tokens = eq.Split();
                foreach (string s in tokens)
                {
                    double re;
                    if (! Double.TryParse(s, out re) && !String.IsNullOrWhiteSpace(s))
                    {
                        namedVariablesAndConstants.Add(s.ToLower());
                    }
                }
                cmbInteractionsPageToInteract.DataSource = new List<string>(namedVariablesAndConstants);
                cmbInteractionsPageToInteractWith.DataSource = new List<string>(namedVariablesAndConstants);
                cmbInteractionsPageToInteractWithViaConstant.DataSource = new List<string>(namedVariablesAndConstants);
            }
        }
        
        /// <summary>
        /// Swap graph values to table if simulation is running.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableTabPage_Enter(object sender, EventArgs e)
        {
            int rowCount = dgvVariables.RowCount - 1; ;
            int rowParser = 0;
            while  (rowParser < rowCount) 
            {
                string value = dgvVariables.Rows[rowParser].Cells[0].Value.ToString();
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = value;
                int colIndex = dgvTable.Columns.Add(col);
                rowParser++;
            }
        }

        /// <summary>
        /// Return graph values back to graph view upon exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableTabPage_Leave(object sender, EventArgs e)
        {
            dgvTable.Columns.Clear();
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Time";
            int colIndex = dgvTable.Columns.Add(col);
        }

        /// <summary>
        /// Attempts to start the simulation using the input data on the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGraphTabPlay_Click(object sender, EventArgs e)
        {
            string eq = "";
            if (eb.BuildEquationFromDataGridView(this.dgvVariables, ref eq)
                && eb.BuildEquationFromDataGridView(this.dgvInteractions, ref eq))
            {
                // Send to sim engine (if the data is good from both datagridviews).
                chart1.Series.Clear();
                se.InitMath(eq);
                uint runDur = 0;
                runDur = GetRunningTime(runDur);
                for(uint i = 0; i < runDur; i++)
                    se.WorkFunction();
                runDur = 0;
                currentX = 0;
            }
        }

        private uint GetRunningTime(uint runDur)
        {
            switch (this.cmbMasterTimeUnit.SelectedIndex)
            {
                case 0:
                    // Seconds
                    runDur = 1000;// Milliseconds.
                    break;
                case 1:
                    // Minutes
                    runDur = 60; // Seconds.
                    break;
                case 2:
                    // Hours
                    runDur = 60;// Minutes
                    break;
                case 3:
                    // Days
                    runDur = 24; // Hours
                    break;
                case 4:
                    // Weeks
                    runDur = 7;
                    break;
                case 5:
                    // Months
                    runDur = 30;
                    break;
                case 6:
                    // Years
                    runDur = 12;
                    break;
                default:
                    runDur = 1;
                    break;
            }
            runDur *= uint.Parse(this.txtMasterQuantity.Text);
            return runDur;
        }

        /// <summary>
        /// Validate and add an interaction to the interaction datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInteractionsPageAddVariableInteraction_Click(object sender, EventArgs e)
        {
            // Clears errors and rechecks for them when button is clicked.
            errorProvider.Clear();

            try
            {
                if (sender == this.btnInteractionsPageAddVariableInteraction)
                {
                    // Check for no selection.
                    CheckForNoSelection(cmbInteractionsPageToInteract);
                    CheckForNoSelection(cmbInteractionsPageToInteractWith);
                    CheckForNoSelection(cmbInteractionsPageIntermediateUnit);

                    // Check operation input box.
                    CheckInteractionOperation(txtInteractionsPageEffectOnQuantity);

                    // If no exception thrown at this point, continue adding the interaction.
                    this.dgvInteractions.Rows.Add(cmbInteractionsPageToInteract.SelectedValue,
                        cmbInteractionsPageToInteractWith.SelectedValue, txtInteractionsPageEffectOnQuantity.Text);
                }
                else if (sender == this.btnInteractionsPageAddConstantInteraction)
                {
                    // Check for no selection.
                    CheckForNoSelection(txtInteractionsPageConstantName);
                    CheckForNoSelection(cmbInteractionsPageToInteractWithViaConstant);
                    CheckForNoSelection(cmbInteractionsPageIntermediateUnitConstant);

                    // Check operation input box.
                    CheckInteractionOperation(txtInteractionsPageConstantEffectOnQuantity);

                    // If no exception thrown at this point, continue adding the interaction.
                    this.dgvInteractions.Rows.Add(txtInteractionsPageConstantName.Text + Constants.CONSTANT_ID,
                        cmbInteractionsPageToInteractWithViaConstant.SelectedValue,
                        txtInteractionsPageConstantEffectOnQuantity.Text);
                }
            }
            catch
            {

            }
            
        }

        /// <summary>
        /// Ensure an operator is present and the value is numeric.
        /// </summary>
        /// <param name="text"></param>
        private void CheckInteractionOperation(Control text)
        {
            CheckForNoSelection(text);
            //Strip off a copy of the first character, find it in the acceptable operator string.
            char beg = text.Text[0];
            if (!Constants.AcceptableOperators.Contains(beg))
            {
                errorProvider.SetError(text, "Not a valid operator.");
                throw new Exception("Invalid operator exception.");
            }

            //Ensure the rest of the string is numeric.
            string num = text.Text.Substring(1);
            foreach (char c in num)
            {
                if (!Char.IsDigit(c) && c != '.')
                {
                    errorProvider.SetError(text, "Fix your effect value.");
                    throw new Exception("Invalid effect value exception.");
                }
            }
        }

        /// <summary>
        /// Ensure a selection is made, if not set the error provider.
        /// </summary>
        /// <param name="cbx">a combobox or textbox control</param>
        private void CheckForNoSelection(Control cbx)
        {
            if (String.IsNullOrWhiteSpace(cbx.Text) || String.IsNullOrEmpty(cbx.Text) )
            {
                errorProvider.SetError(cbx, "Please select a variable.");
                //throw new Exception("No selection exception.");
            }
        }

       /// <summary>
       /// Allow user to load a system via menu-strip option
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r != System.Windows.Forms.DialogResult.OK)
                return;
            try
            {
                string text
                    = System.IO.File.ReadAllText(openFileDialog1.FileName);
                string[] lines = text.Split('\n');
                this.dgvVariables.Rows.Clear();
                foreach (string s in lines)
                {
                    string[] tokens = s.Trim().Split(' ');
                    if (tokens.Length == Constants.VARIABLE_COL_COUNT)
                    {
                        
                        this.dgvVariables.Rows.Add(tokens);
                        
                    }
                    else if (tokens.Length == Constants.INTERACT_COL_COUNT)
                    {
                        this.dgvInteractions.Rows.Add(tokens);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail opening/loading file.");
            }


        }

        /// <summary>
        /// Allow user to save a system via menu-strip option. Provides a typical Windows saving interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r != System.Windows.Forms.DialogResult.OK)
                return;

            string equation = "";
            if (eb.BuildEquationFromDataGridView(this.dgvVariables, ref equation)
                && eb.BuildEquationFromDataGridView(this.dgvInteractions, ref equation))
            {
                try
                {
                    System.IO.File.WriteAllText(this.saveFileDialog1.FileName, equation);
                }
                catch
                {
                    MessageBox.Show("Fail saving file.");
                }
            }
            else
            {
                MessageBox.Show("You must have proper data to save it.");
            }
        }

        /// <summary>
        /// Allows user to save via save button, but doesn't open the Save As dialog feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveAs_Click(sender, e);
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        /// <summary>
        /// Receives data from the Sim Engine and plots it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="values">Named-Variable/Value pairs from the sim engine.</param>
        private void OnDataPrepared(object sender, Hashtable values)
        {
            //use the data
            foreach (DictionaryEntry d in values)
            {
                if (null == chart1.Series.FindByName(d.Key as string))
                {
                    chart1.Series.Add(d.Key as string);
                    chart1.Series.ElementAt(chart1.Series.Count - 1).ChartType 
                        = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                chart1.Series[d.Key as string].Points.AddXY(currentX, Double.Parse(d.Value as string));
                currentX++;
            }

        }

<<<<<<< .mine
        private void dgvVariables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

=======
        private void cmbMasterTimeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

>>>>>>> .r121
    }
}
