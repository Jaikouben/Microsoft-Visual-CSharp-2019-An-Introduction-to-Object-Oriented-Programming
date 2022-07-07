/*
Convert the ProjectedRaises class to an interactive application named ProjectedRaisesInteractive. Instead of assigning values to the salaries, accept them from the user as input.

Output for each employee should be formatted similar to the following example for the first employee: Next year's salary for the first employee will be $26,000.00.

Note: The salary in the output will change depending on the user input.
*/

using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
   static void Main()
   {
      const double RAISE = 0.04;
      // Accepts salaries as user input
      double salary1 = Convert.ToDouble(ReadLine()), salary2 = Convert.ToDouble(ReadLine()), salary3 = Convert.ToDouble(ReadLine());
      WriteLine("Next year's salary for the first employee will be {0}", (salary1 + salary1 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Next year's salary for the second employee will be {0}", (salary2 + salary2 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));  
      WriteLine("Next year's salary for the third employee will be {0}", (salary3 + salary3 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));     
   }
}
