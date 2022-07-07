/*
In Chapter 1, you created two programs to display the motto for Marshall’s Murals.

Now write a program named MarshallsRevenue that prompts a user for the number of interior and exterior murals scheduled to be painted during the next month.

Compute the expected revenue for each type of mural. Interior murals cost $500 each, and exterior murals cost $750 each.

Also display the total expected revenue and a statement that indicates whether more interior murals are scheduled than exterior ones.

An example of the program is shown below:
  Enter number of interior murals scheduled >> 3
  Enter number of exterior murals scheduled >> 1
  3 interior murals are scheduled at $500.00 each for a total of $1,500.00
  1 exterior murals are scheduled at $750.00 each for a total of $750.00
  Total revenue expected is $2,250.00
  It is True that there are more interior murals scheduled than exterior ones.
*/

using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      // Prompts the user to enter information about the murals scheduled
      WriteLine("Enter the number of interior murals scheduled >>");
      int interiorMurals = int.Parse(ReadLine());
      WriteLine("Enter the number of exterior murals scheduled >>");
      int exteriorMurals = int.Parse(ReadLine());

      // Calculates revenue
      int revenue = (interiorMurals * 500) + (exteriorMurals * 750);
      int interiorRevenue = interiorMurals * 500;
      int exteriorRevenue = exteriorMurals * 750;

      // Displays information
      WriteLine("{0} interior murals are scheduled at $500.00 each for a total of {1}", interiorMurals, interiorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled at $750.00 each for a total of {1}", exteriorMurals, exteriorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total revenue expected is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(interiorMurals > exteriorMurals)
        WriteLine("It is True that there are more interior murals scheduled than exterior ones.");
      else
        WriteLine("It is False that there are more interior murals scheduled than exterior ones.");
   }
}
