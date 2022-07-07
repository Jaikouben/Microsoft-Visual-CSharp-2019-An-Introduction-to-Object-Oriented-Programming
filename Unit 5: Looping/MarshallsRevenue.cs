/*
In Chapter 4 of your book, you created an interactive application named MarshallsRevenue that prompts a user for the number of interior and exterior murals scheduled to be painted during a month and computes the expected revenue for each type of mural. The program also prompts the user for the month number and modifies the pricing based on requirements listed in Chapter 4.

Now, modify your program so that the user must enter a month value from 1 through 12. If the user enters an incorrect number, the program prompts for a valid value. Also, the user must enter a number between 0 and 30 inclusive for the number of murals of each type; otherwise, the program prompts the user again.
*/

using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      // Declares variables
      int interiorMurals = 0, exteriorMurals = 0, interiorRevenue, exteriorRevenue, revenue;
      
      // Prompts the user to enter a month 
      bool valid1 = false;
      int month = 0;
      while(valid1 == false)
      {
        WriteLine("Enter the month >>");
        month = int.Parse(ReadLine());

        if(month >= 1 && month <= 12)
          valid1 = true;
        else
          WriteLine("Invalid input");
      }

      // Prompts the user to enter interior murals scheduled
      bool valid2 = false;
      while(valid2 == false)
      {
        WriteLine("Enter the number of interior murals scheduled >>");
        interiorMurals = int.Parse(ReadLine());

        if(interiorMurals >= 0 && interiorMurals <= 30)
          valid2 = true;
        else  
          WriteLine("Invalid input");
      }

      // Prompts the user to enter exterior murals scheduled
      bool valid3 = false;
      while(valid3 == false)
      {
        // Changes the number of exterior murals based on the month entered
        if(month == 12 || month == 1 || month == 2)
        {
          exteriorMurals = 0;
          valid3 = true;
        }
        else
        {
          WriteLine("Enter the number of exterior murals scheduled >>");
          exteriorMurals = int.Parse(ReadLine());

          if(month >= 0 && month <= 30)
            valid3 = true;
          else 
            WriteLine("Invalid input");
        }
        
      }

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
      WriteLine("{0} interior murals are scheduled for a total of {1}", interiorMurals, interiorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled for a total of {1}", exteriorMurals, exteriorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("{0} exterior murals are scheduled for a total of {1}", exteriorMurals, exteriorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total revenue expected is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(interiorMurals > exteriorMurals)
        WriteLine("It is True that there are more interior murals scheduled than exterior ones.");
      else
        WriteLine("It is False that there are more interior murals scheduled than exterior ones.");      
   }
}
