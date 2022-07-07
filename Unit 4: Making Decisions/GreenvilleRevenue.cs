/*
In Chapter 2, you created an interactive application named GreenvilleRevenue.

The program prompts a user for the number of contestants entered in this year’s and last year’s Greenville Idol competition, and then it displays the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.

The programs also display a statement that compares the number of contestants each year. Using the program you wrote in Case Study 1 of Chapter 2, replace that statement with one of the following messages:
  If the competition has more than twice as many contestants as last year, display The competition is more than twice as big this year!
  If the competition is bigger than last year’s but not more than twice as big, display The competition is bigger than ever!
  If the competition is smaller than last year’s, display, A tighter race this year! Come out and cast your vote!
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
      if(thisYear > (lastYear * 2))
        WriteLine("The competition is more than twice as big this year!");
      else 
        if(thisYear > lastYear)
          WriteLine("The competition is bigger than ever!");
        else
          WriteLine("A tighter race this year! Come out and cast your vote!");
      WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(thisYear > lastYear)
        WriteLine("It is True that this year's competition is bigger than last year's");
      else 
        WriteLine("It is False that this year's competition is bigger than last year's");
   }
}
