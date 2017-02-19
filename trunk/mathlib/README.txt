-----------------------------------------------------------------
-----------------------------------------------------------------

info.lundin.Math.dll - Math expression parser in C#

Author: Patrik Lundin
http://www.lundin.info
patrik@lundin.info

-----------------------------------------------------------------
-----------------------------------------------------------------

-----------------------------------------------------------------
Usage and code example:
-----------------------------------------------------------------

To use the math expression parser in any .NET aware language simply
copy the info.lundin.Math.dll into the same directory as your source 
files and then reference it.

For example, using C# ( C-sharp ):

// Import the assembly that contains the parser
using info.lundin.Math;

// some other imports
using System;
using System.Collections;

public class Test 
{
	public static void Main( String[] args )
	{
		// Instantiate the parser
		ExpressionParser parser = new ExpressionParser();

		// Create a hashtable to hold values
		Hashtable h = new Hashtable();

		// Add variables and values to hashtable
		h.Add( "x", 1.ToString() );
		h.Add( "y", 2.ToString() );

		// Parse and write the result
		double result = parser.Parse( "xcos(y)", h  );
		Console.WriteLine( “Result: {0}”, result );
	}
}

 
When you compile your source you must make sure it finds the info.lundin.Math.dll,
with the C-sharp compiler this is made with the /r switch:

csc /r:info.lundin.Math.dll yourfile.cs

Don't forget to send along a copy of the info.lundin.Math.dll with your program.

-----------------------------------------------------------------
Reference:
-----------------------------------------------------------------

The parser handles most mathematical operators and functions.

Operators:

+, -, *, /, ^, %


Functions:

sqrt, sin, cos, tan, atan, acos, asin, 
acotan, exp, ln, 10log, fac, sinh, cosh,
tanh, abs, ceil, floor, sfac, round, fpart

Logical:

!, ==, !=, ||, &&, >, < , >=, <=, 

