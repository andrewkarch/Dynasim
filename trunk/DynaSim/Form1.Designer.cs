namespace DynaSim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabGraphTabPage = new System.Windows.Forms.TabPage();
            this.pnlInputData = new System.Windows.Forms.Panel();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.colVariableNameInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateOfChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeathRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraphMoveLeft = new System.Windows.Forms.Button();
            this.btnGraphMoveRight = new System.Windows.Forms.Button();
            this.pnlGraphGeneral = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasterQuantity = new System.Windows.Forms.TextBox();
            this.cmbMasterTimeUnit = new System.Windows.Forms.ComboBox();
            this.lblMasterTimeUnit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadSystem = new System.Windows.Forms.Button();
            this.btnLoadSimulation = new System.Windows.Forms.Button();
            this.btnGraphTabRunSim = new System.Windows.Forms.Button();
            this.tabTableTabPage = new System.Windows.Forms.TabPage();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInteractionsTabPage = new System.Windows.Forms.TabPage();
            this.dgvInteractions = new System.Windows.Forms.DataGridView();
            this.colVariableNameInteraction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbInteractionDropDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangeRateInteraction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInteractionPanel = new System.Windows.Forms.Panel();
            this.btnInteractionsTabRunSim = new System.Windows.Forms.Button();
            this.txtInteractionsPageConstantName = new System.Windows.Forms.TextBox();
            this.lblInteractionsPageConstant = new System.Windows.Forms.Label();
            this.btnInteractionsPageAddConstantInteraction = new System.Windows.Forms.Button();
            this.lblInteractionsPageInteractionEffectConstantOnQuantity = new System.Windows.Forms.Label();
            this.txtInteractionsPageConstantEffectOnQuantity = new System.Windows.Forms.TextBox();
            this.cmbInteractionsPageIntermediateUnitConstant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInteractionsPageToInteractWithViaConstant = new System.Windows.Forms.ComboBox();
            this.lblInteractionsPageInteractsWith = new System.Windows.Forms.Label();
            this.btnInteractionsPageAddVariableInteraction = new System.Windows.Forms.Button();
            this.lblInteractionsPageInteractionEffectOnQuantity = new System.Windows.Forms.Label();
            this.txtInteractionsPageEffectOnQuantity = new System.Windows.Forms.TextBox();
            this.cmbInteractionsPageIntermediateUnit = new System.Windows.Forms.ComboBox();
            this.lblPerUnit = new System.Windows.Forms.Label();
            this.cmbInteractionsPageToInteractWith = new System.Windows.Forms.ComboBox();
            this.lblInteractsWith = new System.Windows.Forms.Label();
            this.cmbInteractionsPageToInteract = new System.Windows.Forms.ComboBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainTabControl.SuspendLayout();
            this.tabGraphTabPage.SuspendLayout();
            this.pnlInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlGraphGeneral.SuspendLayout();
            this.tabTableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tabInteractionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.pnlInteractionPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabGraphTabPage);
            this.mainTabControl.Controls.Add(this.tabTableTabPage);
            this.mainTabControl.Controls.Add(this.tabInteractionsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1186, 624);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabGraphTabPage
            // 
            this.tabGraphTabPage.Controls.Add(this.pnlInputData);
            this.tabGraphTabPage.Controls.Add(this.pnlGraph);
            this.tabGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.tabGraphTabPage.Name = "tabGraphTabPage";
            this.tabGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphTabPage.Size = new System.Drawing.Size(1178, 598);
            this.tabGraphTabPage.TabIndex = 0;
            this.tabGraphTabPage.Text = "Graph";
            this.tabGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlInputData
            // 
            this.pnlInputData.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlInputData.Controls.Add(this.dgvVariables);
            this.pnlInputData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInputData.Location = new System.Drawing.Point(3, 452);
            this.pnlInputData.Name = "pnlInputData";
            this.pnlInputData.Size = new System.Drawing.Size(1172, 143);
            this.pnlInputData.TabIndex = 1;
            // 
            // dgvVariables
            // 
            this.dgvVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariableNameInput,
            this.colVariableQuantity,
            this.colRateOfChange,
            this.colBirthRate,
            this.colDeathRate});
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariables.Location = new System.Drawing.Point(0, 0);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.Size = new System.Drawing.Size(1172, 143);
            this.dgvVariables.TabIndex = 0;
            this.dgvVariables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVariables_CellContentClick);
            // 
            // colVariableNameInput
            // 
            this.colVariableNameInput.HeaderText = "Variable Name";
            this.colVariableNameInput.Name = "colVariableNameInput";
            // 
            // colVariableQuantity
            // 
            this.colVariableQuantity.HeaderText = "Variable Quantity";
            this.colVariableQuantity.Name = "colVariableQuantity";
            // 
            // colRateOfChange
            // 
            this.colRateOfChange.HeaderText = "Rate of Change Per Time Unit";
            this.colRateOfChange.Name = "colRateOfChange";
            // 
            // colBirthRate
            // 
            this.colBirthRate.HeaderText = "Quantity Birth Rate Per Time Unit";
            this.colBirthRate.Name = "colBirthRate";
            // 
            // colDeathRate
            // 
            this.colDeathRate.HeaderText = "Quantity Death Rate Per Time Unit";
            this.colDeathRate.Name = "colDeathRate";
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.BackColor = System.Drawing.Color.Silver;
            this.pnlGraph.Controls.Add(this.chart1);
            this.pnlGraph.Controls.Add(this.btnGraphMoveLeft);
            this.pnlGraph.Controls.Add(this.btnGraphMoveRight);
            this.pnlGraph.Controls.Add(this.pnlGraphGeneral);
            this.pnlGraph.Location = new System.Drawing.Point(8, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1164, 437);
            this.pnlGraph.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(84, 17);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(995, 312);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // btnGraphMoveLeft
            // 
            this.btnGraphMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGraphMoveLeft.Enabled = false;
            this.btnGraphMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphMoveLeft.Location = new System.Drawing.Point(3, 143);
            this.btnGraphMoveLeft.Name = "btnGraphMoveLeft";
            this.btnGraphMoveLeft.Size = new System.Drawing.Size(75, 73);
            this.btnGraphMoveLeft.TabIndex = 6;
            this.btnGraphMoveLeft.Text = "|<";
            this.btnGraphMoveLeft.UseVisualStyleBackColor = true;
            this.btnGraphMoveLeft.Visible = false;
            // 
            // btnGraphMoveRight
            // 
            this.btnGraphMoveRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGraphMoveRight.Enabled = false;
            this.btnGraphMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphMoveRight.Location = new System.Drawing.Point(1085, 143);
            this.btnGraphMoveRight.Name = "btnGraphMoveRight";
            this.btnGraphMoveRight.Size = new System.Drawing.Size(75, 73);
            this.btnGraphMoveRight.TabIndex = 5;
            this.btnGraphMoveRight.Text = ">|";
            this.btnGraphMoveRight.UseVisualStyleBackColor = true;
            this.btnGraphMoveRight.Visible = false;
            // 
            // pnlGraphGeneral
            // 
            this.pnlGraphGeneral.Controls.Add(this.label4);
            this.pnlGraphGeneral.Controls.Add(this.txtMasterQuantity);
            this.pnlGraphGeneral.Controls.Add(this.cmbMasterTimeUnit);
            this.pnlGraphGeneral.Controls.Add(this.lblMasterTimeUnit);
            this.pnlGraphGeneral.Controls.Add(this.btnSave);
            this.pnlGraphGeneral.Controls.Add(this.btnLoadSystem);
            this.pnlGraphGeneral.Controls.Add(this.btnLoadSimulation);
            this.pnlGraphGeneral.Controls.Add(this.btnGraphTabRunSim);
            this.pnlGraphGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGraphGeneral.Location = new System.Drawing.Point(0, 352);
            this.pnlGraphGeneral.Name = "pnlGraphGeneral";
            this.pnlGraphGeneral.Size = new System.Drawing.Size(1164, 85);
            this.pnlGraphGeneral.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity";
            // 
            // txtMasterQuantity
            // 
            this.txtMasterQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMasterQuantity.Location = new System.Drawing.Point(626, 25);
            this.txtMasterQuantity.Name = "txtMasterQuantity";
            this.txtMasterQuantity.Size = new System.Drawing.Size(242, 20);
            this.txtMasterQuantity.TabIndex = 12;
            this.txtMasterQuantity.Text = "1";
            // 
            // cmbMasterTimeUnit
            // 
            this.cmbMasterTimeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbMasterTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasterTimeUnit.FormattingEnabled = true;
            this.cmbMasterTimeUnit.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmbMasterTimeUnit.Location = new System.Drawing.Point(357, 25);
            this.cmbMasterTimeUnit.Name = "cmbMasterTimeUnit";
            this.cmbMasterTimeUnit.Size = new System.Drawing.Size(208, 21);
            this.cmbMasterTimeUnit.TabIndex = 7;
            this.cmbMasterTimeUnit.SelectedIndexChanged += new System.EventHandler(this.cmbMasterTimeUnit_SelectedIndexChanged);
            // 
            // lblMasterTimeUnit
            // 
            this.lblMasterTimeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMasterTimeUnit.AutoSize = true;
            this.lblMasterTimeUnit.Location = new System.Drawing.Point(264, 28);
            this.lblMasterTimeUnit.Name = "lblMasterTimeUnit";
            this.lblMasterTimeUnit.Size = new System.Drawing.Size(87, 13);
            this.lblMasterTimeUnit.TabIndex = 6;
            this.lblMasterTimeUnit.Text = "Master Time Unit";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Simulation";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadSystem
            // 
            this.btnLoadSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSystem.Enabled = false;
            this.btnLoadSystem.Location = new System.Drawing.Point(1029, 43);
            this.btnLoadSystem.Name = "btnLoadSystem";
            this.btnLoadSystem.Size = new System.Drawing.Size(131, 36);
            this.btnLoadSystem.TabIndex = 5;
            this.btnLoadSystem.Text = "Load System";
            this.btnLoadSystem.UseVisualStyleBackColor = true;
            this.btnLoadSystem.Visible = false;
            this.btnLoadSystem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnLoadSimulation
            // 
            this.btnLoadSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSimulation.Location = new System.Drawing.Point(1029, 6);
            this.btnLoadSimulation.Name = "btnLoadSimulation";
            this.btnLoadSimulation.Size = new System.Drawing.Size(131, 36);
            this.btnLoadSimulation.TabIndex = 4;
            this.btnLoadSimulation.Text = "Load Simulation";
            this.btnLoadSimulation.UseVisualStyleBackColor = true;
            this.btnLoadSimulation.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnGraphTabRunSim
            // 
            this.btnGraphTabRunSim.Location = new System.Drawing.Point(3, 6);
            this.btnGraphTabRunSim.Name = "btnGraphTabRunSim";
            this.btnGraphTabRunSim.Size = new System.Drawing.Size(92, 36);
            this.btnGraphTabRunSim.TabIndex = 1;
            this.btnGraphTabRunSim.Text = "Run\r\nSimulation";
            this.btnGraphTabRunSim.UseVisualStyleBackColor = true;
            this.btnGraphTabRunSim.Click += new System.EventHandler(this.btnGraphTabPlay_Click);
            // 
            // tabTableTabPage
            // 
            this.tabTableTabPage.Controls.Add(this.dgvTable);
            this.tabTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.tabTableTabPage.Name = "tabTableTabPage";
            this.tabTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableTabPage.Size = new System.Drawing.Size(1178, 598);
            this.tabTableTabPage.TabIndex = 1;
            this.tabTableTabPage.Text = "Table";
            this.tabTableTabPage.UseVisualStyleBackColor = true;
            this.tabTableTabPage.Enter += new System.EventHandler(this.tableTabPage_Enter);
            this.tabTableTabPage.Leave += new System.EventHandler(this.tableTabPage_Leave);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(3, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(1172, 592);
            this.dgvTable.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.HeaderText = "Time";
            this.Data.Name = "Data";
            // 
            // tabInteractionsTabPage
            // 
            this.tabInteractionsTabPage.Controls.Add(this.dgvInteractions);
            this.tabInteractionsTabPage.Controls.Add(this.pnlInteractionPanel);
            this.tabInteractionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.tabInteractionsTabPage.Name = "tabInteractionsTabPage";
            this.tabInteractionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabInteractionsTabPage.Size = new System.Drawing.Size(1178, 598);
            this.tabInteractionsTabPage.TabIndex = 2;
            this.tabInteractionsTabPage.Text = "Interactions";
            this.tabInteractionsTabPage.UseVisualStyleBackColor = true;
            this.tabInteractionsTabPage.Enter += new System.EventHandler(this.interactionsTabPage_Enter);
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariableNameInteraction,
            this.cmbInteractionDropDown,
            this.colChangeRateInteraction});
            this.dgvInteractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInteractions.Location = new System.Drawing.Point(3, 138);
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.Size = new System.Drawing.Size(1172, 457);
            this.dgvInteractions.TabIndex = 0;
            // 
            // colVariableNameInteraction
            // 
            this.colVariableNameInteraction.HeaderText = "Variable/Constant Name";
            this.colVariableNameInteraction.Name = "colVariableNameInteraction";
            this.colVariableNameInteraction.ReadOnly = true;
            // 
            // cmbInteractionDropDown
            // 
            this.cmbInteractionDropDown.HeaderText = "Interacts With";
            this.cmbInteractionDropDown.Name = "cmbInteractionDropDown";
            this.cmbInteractionDropDown.ReadOnly = true;
            this.cmbInteractionDropDown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbInteractionDropDown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colChangeRateInteraction
            // 
            this.colChangeRateInteraction.HeaderText = "With an effect of <> on quantity";
            this.colChangeRateInteraction.Name = "colChangeRateInteraction";
            // 
            // pnlInteractionPanel
            // 
            this.pnlInteractionPanel.AutoScroll = true;
            this.pnlInteractionPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlInteractionPanel.Controls.Add(this.btnInteractionsTabRunSim);
            this.pnlInteractionPanel.Controls.Add(this.txtInteractionsPageConstantName);
            this.pnlInteractionPanel.Controls.Add(this.lblInteractionsPageConstant);
            this.pnlInteractionPanel.Controls.Add(this.btnInteractionsPageAddConstantInteraction);
            this.pnlInteractionPanel.Controls.Add(this.lblInteractionsPageInteractionEffectConstantOnQuantity);
            this.pnlInteractionPanel.Controls.Add(this.txtInteractionsPageConstantEffectOnQuantity);
            this.pnlInteractionPanel.Controls.Add(this.cmbInteractionsPageIntermediateUnitConstant);
            this.pnlInteractionPanel.Controls.Add(this.label2);
            this.pnlInteractionPanel.Controls.Add(this.cmbInteractionsPageToInteractWithViaConstant);
            this.pnlInteractionPanel.Controls.Add(this.lblInteractionsPageInteractsWith);
            this.pnlInteractionPanel.Controls.Add(this.btnInteractionsPageAddVariableInteraction);
            this.pnlInteractionPanel.Controls.Add(this.lblInteractionsPageInteractionEffectOnQuantity);
            this.pnlInteractionPanel.Controls.Add(this.txtInteractionsPageEffectOnQuantity);
            this.pnlInteractionPanel.Controls.Add(this.cmbInteractionsPageIntermediateUnit);
            this.pnlInteractionPanel.Controls.Add(this.lblPerUnit);
            this.pnlInteractionPanel.Controls.Add(this.cmbInteractionsPageToInteractWith);
            this.pnlInteractionPanel.Controls.Add(this.lblInteractsWith);
            this.pnlInteractionPanel.Controls.Add(this.cmbInteractionsPageToInteract);
            this.pnlInteractionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInteractionPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlInteractionPanel.Name = "pnlInteractionPanel";
            this.pnlInteractionPanel.Size = new System.Drawing.Size(1172, 135);
            this.pnlInteractionPanel.TabIndex = 1;
            // 
            // btnInteractionsTabRunSim
            // 
            this.btnInteractionsTabRunSim.Location = new System.Drawing.Point(1099, 9);
            this.btnInteractionsTabRunSim.Name = "btnInteractionsTabRunSim";
            this.btnInteractionsTabRunSim.Size = new System.Drawing.Size(70, 107);
            this.btnInteractionsTabRunSim.TabIndex = 18;
            this.btnInteractionsTabRunSim.Text = "Run\r\nSimulation";
            this.btnInteractionsTabRunSim.UseVisualStyleBackColor = true;
            this.btnInteractionsTabRunSim.Click += new System.EventHandler(this.btnGraphTabPlay_Click);
            // 
            // txtInteractionsPageConstantName
            // 
            this.txtInteractionsPageConstantName.Location = new System.Drawing.Point(70, 89);
            this.txtInteractionsPageConstantName.Name = "txtInteractionsPageConstantName";
            this.txtInteractionsPageConstantName.Size = new System.Drawing.Size(100, 20);
            this.txtInteractionsPageConstantName.TabIndex = 17;
            // 
            // lblInteractionsPageConstant
            // 
            this.lblInteractionsPageConstant.AutoSize = true;
            this.lblInteractionsPageConstant.Location = new System.Drawing.Point(14, 95);
            this.lblInteractionsPageConstant.Name = "lblInteractionsPageConstant";
            this.lblInteractionsPageConstant.Size = new System.Drawing.Size(49, 13);
            this.lblInteractionsPageConstant.TabIndex = 16;
            this.lblInteractionsPageConstant.Text = "Constant";
            // 
            // btnInteractionsPageAddConstantInteraction
            // 
            this.btnInteractionsPageAddConstantInteraction.Location = new System.Drawing.Point(983, 79);
            this.btnInteractionsPageAddConstantInteraction.Name = "btnInteractionsPageAddConstantInteraction";
            this.btnInteractionsPageAddConstantInteraction.Size = new System.Drawing.Size(110, 39);
            this.btnInteractionsPageAddConstantInteraction.TabIndex = 15;
            this.btnInteractionsPageAddConstantInteraction.Text = "Add Interaction\r\nConstant";
            this.btnInteractionsPageAddConstantInteraction.UseVisualStyleBackColor = true;
            this.btnInteractionsPageAddConstantInteraction.Click += new System.EventHandler(this.btnInteractionsPageAddVariableInteraction_Click);
            // 
            // lblInteractionsPageInteractionEffectConstantOnQuantity
            // 
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.AutoSize = true;
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.Location = new System.Drawing.Point(680, 90);
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.Name = "lblInteractionsPageInteractionEffectConstantOnQuantity";
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.Size = new System.Drawing.Size(104, 26);
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.TabIndex = 14;
            this.lblInteractionsPageInteractionEffectConstantOnQuantity.Text = "With an effect of \r\n(+,-,/,*,^) on quantity\r\n";
            // 
            // txtInteractionsPageConstantEffectOnQuantity
            // 
            this.txtInteractionsPageConstantEffectOnQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtInteractionsPageConstantEffectOnQuantity.Location = new System.Drawing.Point(785, 89);
            this.txtInteractionsPageConstantEffectOnQuantity.Name = "txtInteractionsPageConstantEffectOnQuantity";
            this.txtInteractionsPageConstantEffectOnQuantity.Size = new System.Drawing.Size(171, 20);
            this.txtInteractionsPageConstantEffectOnQuantity.TabIndex = 13;
            // 
            // cmbInteractionsPageIntermediateUnitConstant
            // 
            this.cmbInteractionsPageIntermediateUnitConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteractionsPageIntermediateUnitConstant.Enabled = false;
            this.cmbInteractionsPageIntermediateUnitConstant.FormattingEnabled = true;
            this.cmbInteractionsPageIntermediateUnitConstant.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmbInteractionsPageIntermediateUnitConstant.Location = new System.Drawing.Point(479, 89);
            this.cmbInteractionsPageIntermediateUnitConstant.Name = "cmbInteractionsPageIntermediateUnitConstant";
            this.cmbInteractionsPageIntermediateUnitConstant.Size = new System.Drawing.Size(195, 21);
            this.cmbInteractionsPageIntermediateUnitConstant.TabIndex = 12;
            this.cmbInteractionsPageIntermediateUnitConstant.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(447, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Per:";
            this.label2.Visible = false;
            // 
            // cmbInteractionsPageToInteractWithViaConstant
            // 
            this.cmbInteractionsPageToInteractWithViaConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteractionsPageToInteractWithViaConstant.FormattingEnabled = true;
            this.cmbInteractionsPageToInteractWithViaConstant.Location = new System.Drawing.Point(266, 89);
            this.cmbInteractionsPageToInteractWithViaConstant.Name = "cmbInteractionsPageToInteractWithViaConstant";
            this.cmbInteractionsPageToInteractWithViaConstant.Size = new System.Drawing.Size(175, 21);
            this.cmbInteractionsPageToInteractWithViaConstant.TabIndex = 10;
            // 
            // lblInteractionsPageInteractsWith
            // 
            this.lblInteractionsPageInteractsWith.AutoSize = true;
            this.lblInteractionsPageInteractsWith.Location = new System.Drawing.Point(184, 92);
            this.lblInteractionsPageInteractsWith.Name = "lblInteractionsPageInteractsWith";
            this.lblInteractionsPageInteractsWith.Size = new System.Drawing.Size(73, 13);
            this.lblInteractionsPageInteractsWith.TabIndex = 9;
            this.lblInteractionsPageInteractsWith.Text = "Interacts With";
            // 
            // btnInteractionsPageAddVariableInteraction
            // 
            this.btnInteractionsPageAddVariableInteraction.Location = new System.Drawing.Point(981, 9);
            this.btnInteractionsPageAddVariableInteraction.Name = "btnInteractionsPageAddVariableInteraction";
            this.btnInteractionsPageAddVariableInteraction.Size = new System.Drawing.Size(110, 39);
            this.btnInteractionsPageAddVariableInteraction.TabIndex = 4;
            this.btnInteractionsPageAddVariableInteraction.Text = "Add Variable Interaction";
            this.btnInteractionsPageAddVariableInteraction.UseVisualStyleBackColor = true;
            this.btnInteractionsPageAddVariableInteraction.Click += new System.EventHandler(this.btnInteractionsPageAddVariableInteraction_Click);
            // 
            // lblInteractionsPageInteractionEffectOnQuantity
            // 
            this.lblInteractionsPageInteractionEffectOnQuantity.AutoSize = true;
            this.lblInteractionsPageInteractionEffectOnQuantity.Location = new System.Drawing.Point(680, 20);
            this.lblInteractionsPageInteractionEffectOnQuantity.Name = "lblInteractionsPageInteractionEffectOnQuantity";
            this.lblInteractionsPageInteractionEffectOnQuantity.Size = new System.Drawing.Size(104, 26);
            this.lblInteractionsPageInteractionEffectOnQuantity.TabIndex = 6;
            this.lblInteractionsPageInteractionEffectOnQuantity.Text = "With an effect of \r\n(+,-,/,*,^) on quantity";
            // 
            // txtInteractionsPageEffectOnQuantity
            // 
            this.txtInteractionsPageEffectOnQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtInteractionsPageEffectOnQuantity.Location = new System.Drawing.Point(785, 19);
            this.txtInteractionsPageEffectOnQuantity.Name = "txtInteractionsPageEffectOnQuantity";
            this.txtInteractionsPageEffectOnQuantity.Size = new System.Drawing.Size(171, 20);
            this.txtInteractionsPageEffectOnQuantity.TabIndex = 3;
            // 
            // cmbInteractionsPageIntermediateUnit
            // 
            this.cmbInteractionsPageIntermediateUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteractionsPageIntermediateUnit.Enabled = false;
            this.cmbInteractionsPageIntermediateUnit.FormattingEnabled = true;
            this.cmbInteractionsPageIntermediateUnit.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmbInteractionsPageIntermediateUnit.Location = new System.Drawing.Point(479, 19);
            this.cmbInteractionsPageIntermediateUnit.Name = "cmbInteractionsPageIntermediateUnit";
            this.cmbInteractionsPageIntermediateUnit.Size = new System.Drawing.Size(195, 21);
            this.cmbInteractionsPageIntermediateUnit.TabIndex = 2;
            this.cmbInteractionsPageIntermediateUnit.Visible = false;
            // 
            // lblPerUnit
            // 
            this.lblPerUnit.AutoSize = true;
            this.lblPerUnit.Enabled = false;
            this.lblPerUnit.Location = new System.Drawing.Point(447, 22);
            this.lblPerUnit.Name = "lblPerUnit";
            this.lblPerUnit.Size = new System.Drawing.Size(26, 13);
            this.lblPerUnit.TabIndex = 3;
            this.lblPerUnit.Text = "Per:";
            this.lblPerUnit.Visible = false;
            // 
            // cmbInteractionsPageToInteractWith
            // 
            this.cmbInteractionsPageToInteractWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteractionsPageToInteractWith.FormattingEnabled = true;
            this.cmbInteractionsPageToInteractWith.Location = new System.Drawing.Point(266, 19);
            this.cmbInteractionsPageToInteractWith.Name = "cmbInteractionsPageToInteractWith";
            this.cmbInteractionsPageToInteractWith.Size = new System.Drawing.Size(175, 21);
            this.cmbInteractionsPageToInteractWith.TabIndex = 1;
            // 
            // lblInteractsWith
            // 
            this.lblInteractsWith.AutoSize = true;
            this.lblInteractsWith.Location = new System.Drawing.Point(184, 22);
            this.lblInteractsWith.Name = "lblInteractsWith";
            this.lblInteractsWith.Size = new System.Drawing.Size(73, 13);
            this.lblInteractsWith.TabIndex = 1;
            this.lblInteractsWith.Text = "Interacts With";
            // 
            // cmbInteractionsPageToInteract
            // 
            this.cmbInteractionsPageToInteract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteractionsPageToInteract.FormattingEnabled = true;
            this.cmbInteractionsPageToInteract.Location = new System.Drawing.Point(3, 19);
            this.cmbInteractionsPageToInteract.Name = "cmbInteractionsPageToInteract";
            this.cmbInteractionsPageToInteract.Size = new System.Drawing.Size(175, 21);
            this.cmbInteractionsPageToInteract.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1186, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File..";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text File|*.txt|\"All Files|*.*";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 648);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DynaSim";
            this.mainTabControl.ResumeLayout(false);
            this.tabGraphTabPage.ResumeLayout(false);
            this.pnlInputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            this.pnlGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlGraphGeneral.ResumeLayout(false);
            this.pnlGraphGeneral.PerformLayout();
            this.tabTableTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tabInteractionsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.pnlInteractionPanel.ResumeLayout(false);
            this.pnlInteractionPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabGraphTabPage;
        private System.Windows.Forms.TabPage tabTableTabPage;
        private System.Windows.Forms.TabPage tabInteractionsTabPage;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnGraphTabRunSim;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlGraphGeneral;
        private System.Windows.Forms.Button btnLoadSystem;
        private System.Windows.Forms.Button btnLoadSimulation;
        private System.Windows.Forms.Button btnGraphMoveLeft;
        private System.Windows.Forms.Button btnGraphMoveRight;
        private System.Windows.Forms.Panel pnlInputData;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.DataGridView dgvInteractions;
        private System.Windows.Forms.Panel pnlInteractionPanel;
        private System.Windows.Forms.Label lblInteractsWith;
        private System.Windows.Forms.ComboBox cmbInteractionsPageToInteract;
        private System.Windows.Forms.ComboBox cmbInteractionsPageToInteractWith;
        private System.Windows.Forms.ComboBox cmbMasterTimeUnit;
        private System.Windows.Forms.Label lblMasterTimeUnit;
        private System.Windows.Forms.Label lblPerUnit;
        private System.Windows.Forms.ComboBox cmbInteractionsPageIntermediateUnit;
        private System.Windows.Forms.Label lblInteractionsPageInteractionEffectOnQuantity;
        private System.Windows.Forms.TextBox txtInteractionsPageEffectOnQuantity;
        private System.Windows.Forms.Button btnInteractionsPageAddVariableInteraction;
        private System.Windows.Forms.TextBox txtInteractionsPageConstantName;
        private System.Windows.Forms.Label lblInteractionsPageConstant;
        private System.Windows.Forms.Button btnInteractionsPageAddConstantInteraction;
        private System.Windows.Forms.Label lblInteractionsPageInteractionEffectConstantOnQuantity;
        private System.Windows.Forms.TextBox txtInteractionsPageConstantEffectOnQuantity;
        private System.Windows.Forms.ComboBox cmbInteractionsPageIntermediateUnitConstant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInteractionsPageToInteractWithViaConstant;
        private System.Windows.Forms.Label lblInteractionsPageInteractsWith;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMasterQuantity;
        private System.Windows.Forms.Button btnInteractionsTabRunSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariableNameInteraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbInteractionDropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangeRateInteraction;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariableNameInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateOfChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeathRate;
    }
}

