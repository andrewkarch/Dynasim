// Copyright (C) Caleb Taylor 2012
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Media;

namespace DynaSimControlLibrary
{
    /// <summary>
    /// The interface used to interact with the custom graphing control.
    /// </summary>
    interface IGraphInterface
    {
        /// <summary>
        /// Adds a variable to the graph, the graph will update this variable accordingly when UpdateGraphItem is called.
        /// A color image will automatically be assigned to identify it on the graph, the image is utilized in the listbox
        /// of the custom control; the listbox items can be accompanied with small images (more like thumbnails).
        /// Use the bitmap/graphics tools to generate these solid-color images starting with basic colors, then combine
        /// them for further variables.
        /// **Existing images may be updated when the basic and "intermediate" colors have been depleted to maintain
        /// visual contrast between the values.**
        /// Throws an exception when the name is already assigned, or the utilized color pallete has been exhausted.
        /// </summary>
        /// <param name="name">Name of the variable to add to the graph.</param>
        /// <param name="value">Value to start with, string used to parse to graphable value.</param>
        void AddVariable(string name, string value);
        /// <summary>
        /// Removes a variable from the graph.
        /// Returns the assigned color back to the list to
        /// be re-used.
        /// </summary>
        /// <param name="name">Name of the variable to remove from the graph.</param>
        bool RemoveVariable(string name);
        /// <summary>
        /// Updates the graph with the new variable value.
        /// Throws information exceptions on error.
        /// </summary>
        /// <param name="name">Name of the variable.</param>
        /// <param name="value">Value to be updated, string used to parse to graphable value.</param>
        void UpdateGraphItem(string name, string value);
        /// <summary>
        /// Translates the graph points to the left one unit to make room for updated graph items.
        /// Throws exception(s).
        /// </summary>
        void AdvanceGraphUnit();

        /// <summary>
        /// Directly related to the time interval chosen for viewing the graph!
        /// The PictureBox will be divided into these columns across the X axis from left to right.
        /// Method is also responsible for ensuring proper condensing or expanding the graphed items as the unit is changed.
        /// Throws exception(s).
        /// </summary>
        /// <param name="unitCount"> Number of units on the X axis of the graph. </param>
        void SetGraphUnitsAcrossXAxis(uint unitCount);

        /// <summary>
        /// Public method used to set the graph view time unit (X axis).
        /// May be updated to use an enum or specialized type for time unit information.
        /// Throws exception(s).
        /// </summary>
        /// <param name="timeUnitCode">TODO: To be replaced...</param>
        void SetGraphViewTimeUnit(uint timeUnitCode);

        /// <summary>
        /// Directly related to the maximal value being graphed.
        /// The PictureBox will be divided into these rows across the Y axis from bottom to top.
        /// Method is also responsible for ensuring proper condensing or expanding the graphed items as the unit is changed.
        /// </summary>
        /// <param name="unitCount"> Number of units on the Y axis of the graph. </param>
        void SetGraphUnitsAcrossYAxis(uint unitCount);
        //... TODO!!!
        // Here it can be set up to read from a data source (undefined as of now)
        // Also the control could include a timer with the tick event set to read from the data source and update the graph...
        // In which case there would be a bool property in the interface "UseTimer", the timer would be modified through the custom
        // control.
    }

    /// <summary>
    /// Custom Graph Control that includes methods for working with the graph view and associated items of it.
    /// Implements IGraphInterface.
    /// </summary>
    public partial class GraphControl : UserControl, IGraphInterface
    {
        /// <summary>
        /// Holds a time unit to work with.
        /// DO NOT CHANGE THE ORDER (or value) OF THESE
        /// </summary>
        public enum TimeUnit
        {
            NULL,
            SECONDS,
            MINUTES,
            HOURS,
            DAYS,
            WEEKS,
            MONTHS,
            YEARS
        }
        public struct TimeRecords
        {
            public const int SECONDS_IN_A_MINUTE = 60;
        }

        /// <summary>
        /// Nested class for holding variable graph information.
        /// </summary>
        private class NamedVariable
        {
            string name;
            Color graphColor;
            List<uint> values;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public List<uint> Values
            {
                get { return values; }
                set { values = value; }
            }
            public Color GraphColor
            {
                get { return graphColor; }
                set { graphColor = value; }
            }
            public NamedVariable(string variableName, uint firstValue, Color firstGraphColor)
            {
                Name = variableName;
                values.Add(firstValue);
                graphColor = firstGraphColor;
            }
        }
        /// <summary>
        /// A List of items that store information about each named variable,
        /// such as color and the list of values.
        /// </summary>
        private List<NamedVariable> variables;
        private List<Color> graphColors;
        private uint currentGraphUnit = 0;
        /// <summary>
        /// Rectangle defining the bounds for the graphing area,
        /// it will have a border around it used for informational purposes.
        /// </summary>
        private Rectangle graphRect;
        /// <summary>
        /// Graph time unit information.
        /// </summary>
        private TimeUnit graphPageUnits, graphIntermediateUnits;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GraphControl()
        {
            InitializeComponent();
            variables = new List<NamedVariable>();
            graphColors = new List<Color>();
            graphRect = new Rectangle();
            BuildColorList();
            InitializeGraphVariableListView();
            //DrawGraphAreaBorder();
        }

        /// <summary>
        /// Adds a variable to the graph, the graph will update this variable accordingly when UpdateGraphItem is called.
        /// A color image will automatically be assigned to identify it on the graph, the image is utilized in the listbox
        /// of the custom control; the listbox items can be accompanied with small images (more like thumbnails).
        /// Use the bitmap/graphics tools to generate these solid-color images.
        /// Throws an exception when the name is already assigned, or the utilized color pallete has been exhausted.
        /// </summary>
        /// <param name="name">Name of the variable to add to the graph.</param>
        /// <param name="value">Value to start with, string used to parse to graphable value.</param>
        public void AddVariable(string name, string value)
        {
            uint val = uint.Parse(value);
            if(IsVariableNameAdded(name))
                throw new ArgumentException("Adding a duplicate variable name was attempted.");
            variables.Add(new NamedVariable(name, val, GetNextColor()));
            // Update list view variables.
            PopulateListView();
        }

        /// <summary>
        /// Removes a variable from the list.
        /// Returns the assigned color back to the list to
        /// be re-used.
        /// </summary>
        /// <param name="name">Name of the variable to remove from the graph.</param>
        /// <returns>true on variable removed, false otherwise</returns>
        public bool RemoveVariable(string name)
        {
            for(int i = 0; i < variables.Count; i++)
            {
                if (variables[i].Name == name)
                {
                    // Return color back to the "palette".
                    graphColors.Add(variables[i].GraphColor);
                    // Remove variable
                    variables.RemoveAt(i);
                    // Update listview
                    PopulateListView();
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// Add a new value to an existing graph item's List of uint values.
        /// Throws exception on non-parsable "value" arg.
        /// </summary>
        /// <param name="name">Name of the graph variable.</param>
        /// <param name="value">Value of the graph variable to be added.</param>
        public void UpdateGraphItem(string name, string value)
        {
            uint val = uint.Parse(value);
            foreach (NamedVariable nv in variables)
            {
                if (name == nv.Name)
                    nv.Values.Add(val);
            }
            // Redraw

        }

        /// <summary>
        /// Translates the graph points to the left one unit to make room for updated graph items.
        /// Throws exception(s).
        /// </summary>
        public void AdvanceGraphUnit()
        {
            throw new NotImplementedException();
        }

        void IGraphInterface.SetGraphUnitsAcrossXAxis(uint unitCount)
        {
            throw new NotImplementedException();
        }

        void IGraphInterface.SetGraphViewTimeUnit(uint timeUnitCode)
        {
            throw new NotImplementedException();
        }

        void IGraphInterface.SetGraphUnitsAcrossYAxis(uint unitCount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ran once on class initialization.
        /// Builds list of System.Drawing colors, stores
        /// info in List "graphColors".
        /// </summary>
        private void BuildColorList()
        {
            System.Drawing.Color c;
            foreach (string s in Enum.GetNames(typeof(System.Drawing.KnownColor)))
            {
                c = System.Drawing.Color.FromName(s);
                graphColors.Add(c);
            }
            //Remove white, it's the first color...
            graphColors.RemoveAt(0);
        }

        /// <summary>
        /// Maintains state to retrieve the next in-order color in the "Color" object.
        /// May throw an exception, if that happens generally assume the list of colors
        /// has been exhausted and composite color functionality is not completed.
        /// Fatal error.
        /// </summary>
        /// <returns></returns>
        private Color GetNextColor()
        {
            Color c = graphColors.First();
            graphColors.RemoveAt(0);
            return c;
        }

        /// <summary>
        /// Checks to see if a name is in the list of variables.
        /// </summary>
        /// <param name="name">Variable name in question.</param>
        /// <returns>True if variable exists in graph, false otherwise.</returns>
        private bool IsVariableNameAdded(string name)
        {
            foreach (NamedVariable n in variables)
            {
                if (n.Name == name)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Clears the named variables listview (lstGraphVariableList)
        /// and adds the contents of the named variables list (variables).
        /// </summary>
        private void PopulateListView()
        {
            // Constant Image Size.
            const int x = 0, y = 0, w = 64, h = 64;
            // Clear contents of list.
            this.lstGraphVariableList.Items.Clear();
            // Loop through the variable list adding each name and color
            // (after creating a solid color image 64x64 pixels).
            foreach (NamedVariable n in this.variables)
            {
                Bitmap bmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bmp);
                SolidBrush sb = new SolidBrush(n.GraphColor);
                g.FillRectangle(sb, x, y, w, h);
                g.Dispose();
                sb.Dispose();
                int c = this.lstGraphVariableList.SmallImageList.Images.Count;
                this.lstGraphVariableList.SmallImageList.Images.Add(bmp);
                this.lstGraphVariableList.Items.Add(n.Name, c + 1);
            }
        }

        /// <summary>
        /// Minor initialization of the listview "lstGraphVariableList",
        /// sets the view to smallicon and adds a "SmallImageList".
        /// For viewing icons that indicate line color, next to the variable name.
        /// </summary>
        private void InitializeGraphVariableListView()
        {
            this.lstGraphVariableList.View = View.SmallIcon;
            this.lstGraphVariableList.SmallImageList = new ImageList();
        }

        /// <summary>
        /// Draws border text.
        /// </summary>
        private void DrawBorderText()
        {

        }
        /// <summary>
        /// Redraws the graph from the "variables" list.
        /// </summary>
        private void Redraw()
        {
            // Inside the graph rect....

            // Determine the unit the graph will be broken into (X-axis).
            uint val = 0;
            
            switch (this.graphIntermediateUnits)
            {
                case TimeUnit.NULL:
                    break;
                case TimeUnit.SECONDS:
                    // Calculate seconds in a (graphPageUnits).
                    // Maybe something like:
                    switch (this.graphPageUnits)
	                {
                        case TimeUnit.NULL:
                            //exception/error w/e
                            break;
                        case TimeUnit.SECONDS:
                            //same as parent unit, error
                            break;
                        case TimeUnit.MINUTES:
                            val = 60;
                            break;
                        case TimeUnit.HOURS:
                            break;
                        case TimeUnit.DAYS:
                            break;
                        case TimeUnit.WEEKS:
                            break;
                        case TimeUnit.MONTHS:
                            break;
                        case TimeUnit.YEARS:
                            break;
                        default:
                            break;
	                }
                    break;
                case TimeUnit.MINUTES:
                    break;
                case TimeUnit.HOURS:
                    break;
                case TimeUnit.DAYS:
                    break;
                case TimeUnit.WEEKS:
                    break;
                case TimeUnit.MONTHS:
                    break;
                case TimeUnit.YEARS:
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// This sets the graph units for the X axis in
        /// terms of seconds/minutes/hours/days/months/years.
        /// </summary>
        /// <returns></returns>
        public bool SetGraphXAxisUnits(TimeUnit pageUnit, TimeUnit intervalUnit)
        {
            if (pageUnit == TimeUnit.NULL || intervalUnit == TimeUnit.NULL)
            {
                return false;
            }
            else
            {
                if (pageUnit <= intervalUnit)
                    throw new Exception("Page units must be larger than intermediate drawing units.");
                this.graphPageUnits = pageUnit;
                this.graphIntermediateUnits = intervalUnit;
            }
            return true;
        }

        private void GraphControl_Resize(object sender, EventArgs e)
        {
            // Update the graphRect and borders.
        }
    }
}
