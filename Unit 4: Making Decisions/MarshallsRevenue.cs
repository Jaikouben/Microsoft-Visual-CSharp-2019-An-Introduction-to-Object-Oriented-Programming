/*
In Chapter 2, you created an interactive application named MarshallsRevenue. The program prompts a user for the number of interior and exterior murals scheduled to be painted during the next month by Marshall’s Murals.

Next, the programs compute the expected revenue for each type of mural when interior murals cost $500 each and exterior murals cost $750 each. The application also displays the total expected revenue and a statement that indicates whether more interior murals are scheduled than exterior ones.

Using the program you wrote in Case Study 2 of Chapter 2, modify the application to accept a numeric value for the month being scheduled and to modify the pricing as follows:
  Because of uncertain weather conditions, exterior murals cannot be painted in December through February, so change the number of exterior murals to 0 for those months.
  Marshall prefers to paint exterior murals in April, May, September, and October. To encourage business, he charges only $699 for an exterior mural during those months. Murals in other months continue to cost $750.
  Marshall prefers to paint interior murals in July and August, so he charges only $450 for an interior mural during those months. Murals in other months continue to cost $500.

The three different examples of the program are shown below:
  // 1
  Enter the month >> 1
  Enter number of interior murals scheduled >> 2
  Enter number of exterior murals scheduled >> 3
  2 interior murals are scheduled for a total of $1,000.00
  0 exterior murals are scheduled for a total of $0.00
  Total revenue expected is $1,000.00
  It is True that there are more interior murals scheduled than exterior ones.

  // 2
  Enter the month >> 5
  Enter number of interior murals scheduled >> 1
  Enter number of exterior murals scheduled >> 2
  1 interior murals are scheduled for a total of $500.00
  2 exterior murals are scheduled for a total of $1,398.00
  Total revenue expected is $1,898.00
  It is False that there are more interior murals scheduled than exterior ones.

  // 3
  Enter the month >> 8
  Enter number of interior murals scheduled >> 2
  Enter number of exterior murals scheduled >> 1
  2 interior murals are scheduled for a total of $900.00
  1 exterior murals are scheduled for a total of $750.00
  Total revenue expected is $1,650.00
  It is True that there are more interior murals scheduled than exterior ones.
*/

using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      // Declares variables
      int interiorMurals, exteriorMurals, interiorRevenue, exteriorRevenue, revenue;

      // Prompts the user to enter a month 
      WriteLine("Enter the month >>");
      int month = int.Parse(ReadLine());

      // Prompts the user to enter information about the murals scheduled
      WriteLine("Enter the number of interior murals scheduled >>");
      interiorMurals = int.Parse(ReadLine());
      WriteLine("Enter the number of exterior murals scheduled >>");
      // Changes the number of exterior murals based on the month entered
      if(month == 12 || month == 1 || month == 2)
        exteriorMurals = 0;
      else
        exteriorMurals = int.Parse(ReadLine());

      // Calculates revenue
      revenue = 0;
      if(month == 7 || month == 8)
      {
        interiorRevenue = interiorMurals * 450;
        revenue = revenue + interiorRevenue;
      }
      else
      {
        interiorRevenue = interiorMurals * 500;
        revenue = revenue + interiorRevenue;
      }
      if(month == 4 || month == 5 || month == 9 || month == 10)
      {
        exteriorRevenue = exteriorMurals * 699;
        revenue = revenue + exteriorRevenue;
      }
      else 
      {
        exteriorRevenue = exteriorMurals * 750;
        revenue = revenue + exteriorRevenue;
      }

      // Displays information
      WriteLine("{0} interior murals are scheduled for a total of {1}", interiorMurals, interiorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled for a total of {1}", exteriorMurals, exteriorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total revenue expected is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(interiorMurals > exteriorMurals)
        WriteLine("It is True that there are more interior murals scheduled than exterior ones.");
      else
        WriteLine("It is False that there are more interior murals scheduled than exterior ones.");   
      }
}
