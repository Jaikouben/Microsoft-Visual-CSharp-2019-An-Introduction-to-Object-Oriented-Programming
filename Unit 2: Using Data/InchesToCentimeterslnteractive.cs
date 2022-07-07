/*
Convert the InchesToCentimeters program to an interactive application named InchesToCentimeterslnteractive.

Instead of assigning a value to the inches variable, accept the value from the user as input.

Display the measurement in both inches and centimeters—for example, if inches is input as 3, the output should be: 3 inches is 7.62 centimeters.
*/

using System;
using static System.Console;
class InchesToCentimetersInteractive
{
   static void Main()
   {
      // Declares a constant variable representing centimeters per inch
      const double CENTIMETERS_PER_INCH = 2.54;

      // Declares a variable representing inches that accepts user input as the value
      double inches = Convert.ToDouble(ReadLine());

      // Displays results
      WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH); 
   }
}
