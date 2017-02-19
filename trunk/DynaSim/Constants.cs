using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynaSim
{
    /// <summary>
    /// Constants used throughout the program.
    /// </summary>
    class Constants
    {
        public const int VARIABLE_COL_COUNT = 5, INTERACT_COL_COUNT = 3;
        public const string RATE_OF_CHANGE = "_rateofchange";
        public const string BIRTH_RATE_QUANTITY = "_birthrate";
        public const string DEATH_RATE_QUANTITY = "_deathrate";
        public const string CONSTANT_ID = "_const";
        public const string INTERACTS_WITH = "_interactswith";
        public const string INTERACTION = "_interaction";
        /// <summary>
        /// Constant string containing single char acceptable operators.
        /// </summary>
        public const string AcceptableOperators = "+-*/^";
    }
}
