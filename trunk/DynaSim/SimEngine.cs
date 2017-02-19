using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using info.lundin.Math;

namespace DynaSim
{
    class SimEngine
    {
        /// <summary>
        /// Math parser.
        /// </summary>
        info.lundin.Math.ExpressionParser parser;

        /// <summary>
        /// List of tuples for storing the data.
        /// </summary>
        List<Tuple<string, string, string, string, string>> vector;

        /// <summary>
        /// Custom delegate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="values">hash table containing named variables as keys and their values</param>
        public delegate void dataPreparedDelegate(object sender, Hashtable values);

        // Create an instance of the event.
        private event dataPreparedDelegate DataPrepared;
        /// <summary>
        /// SimEngine constructor.
        /// </summary>
        public SimEngine(dataPreparedDelegate eventHandler)
        {
            parser = new ExpressionParser();
            vector = new List<Tuple<string, string, string, string, string>>();
            DataPrepared += eventHandler;
        }

        /// <summary>
        /// Initalizes the "equations" into the math parser.
        /// </summary>
        /// <param name="equation"></param>
        public void InitMath(string equation)
        {
            vector.Clear();
            // Line by line, adding 'dem named variables and initial quantities to the hash tables.

            // Split it into dgv rows.
            string[] rows = equation.Split('\n');

            // Identify and add the named variables.
            foreach (string s in rows)
            {
                string st = s.Trim();
                string[] tokens = st.Split(' ');

                if (tokens.Length == Constants.VARIABLE_COL_COUNT)
                {
                    vector.Add(new Tuple<string, string, string, string, string>(
                        tokens[0], tokens[1], tokens[2], tokens[3], tokens[4]
                        ));
                }
                else if (tokens.Length == Constants.INTERACT_COL_COUNT)
                {
                    vector.Add(new Tuple<string, string, string, string, string>(
                        tokens[0], tokens[1], tokens[2], "", ""));
                }
            }
        }

        /// <summary>
        /// Performs work, does what is described, and reports the results.
        /// </summary>
        public void WorkFunction()
        {
            // Tuple for all of the changes.
            List<Tuple<string, string, string, string, string>> tupCop
                = new List<Tuple<string, string, string, string, string>>();

            // Birth/Death/Rate of change
            foreach (Tuple<string, string, string, string, string> t in vector)
            {
                Tuple<string, string, string, string, string> tempTup;

                if (!String.IsNullOrEmpty(t.Item5))
                {
                    Double result =
                    Double.Parse(t.Item2) * Double.Parse(t.Item3) + Double.Parse(t.Item4) - Double.Parse(t.Item5);
                    tempTup
                        = new Tuple<string, string, string, string, string>(t.Item1, result.ToString(),
                            t.Item3, t.Item4, t.Item5);
                    tupCop.Add(tempTup);
                }
            }
            vector = tupCop;
            // Interaction
            for (int i = 0; i < vector.Count; i++)
            {
                if (String.IsNullOrEmpty(vector[i].Item5))
                {
                    string toFind = vector[i].Item2;
                    string operation = vector[i].Item3;
                    for (int j = 0; j < vector.Count; j++)
                    {
                        if (vector[j].Item1 == toFind && !String.IsNullOrEmpty(vector[j].Item5))
                        {
                            string val = vector[j].Item2;
                            Hashtable ht = new Hashtable();
                            ht.Add(toFind, val);
                            vector[j] = new Tuple<string, string, string, string, string>(vector[j].Item1,
                                parser.Parse(toFind + operation, ht).ToString(), vector[j].Item3, vector[j].Item4,
                                vector[j].Item5);
                            //parser came in handy.
                        }
                    }
                }
            }
            // Build a hash table for output.
            Hashtable hit = new Hashtable();
            foreach (Tuple<string, string, string, string, string> t in vector)
            {
                if (!String.IsNullOrEmpty(t.Item5))
                    hit.Add(t.Item1, t.Item2);
            }
            // Raise Event
            DataPrepared(this, hit);
        }
    }
}
