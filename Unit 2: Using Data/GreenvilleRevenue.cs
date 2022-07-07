/*
In Chapter 1, you created two programs to display the motto for the Greenville Idol competition that is held each summer during the Greenville County Fair.

Now write a program named GreenvilleRevenue that prompts a user for the number of contestants entered in last year’s competition and in this year’s competition.

  Display all the input data.
  Compute and display the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.
  Also display a statement that indicates whether this year’s competition has more contestants than last year’s.

An example of the program is shown below:
  Enter number of contestants last year >> 6
  Enter number of contestants this year >> 14
  Last year's competition had 6 contestants, and this year's has 14 contestants
  Revenue expected this year is $350.00
  It is True that this year's competition is bigger than last year's.
*/

using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
      // Prompts user for number of contestants for last year and this year
      WriteLine("Enter number of contestants last year >>");
      int lastYear = int.Parse(ReadLine());
      WriteLine("Enter number of contestants this year >>");
      int thisYear = int.Parse(ReadLine());

      // Calculates revenue for this year
      int revenue = thisYear * 25;

      // Prints competition information
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYear, thisYear);
      WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(thisYear > lastYear)
        WriteLine("It is True that this year's competition is bigger than last year's");
      else 
        WriteLine("It is False that this year's competition is bigger than last year's");
   }
}
