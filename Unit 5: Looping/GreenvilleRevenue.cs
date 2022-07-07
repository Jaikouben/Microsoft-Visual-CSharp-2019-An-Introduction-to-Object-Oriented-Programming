/*
In Chapter 4 , you created an interactive application named GreenvilleRevenue that prompts a user for the number of contestants entered in this year’s and last year’s Greenville Idol competition and displays the revenue expected for this year’s competition if each contestant pays a $25 entrance fee. The program also displays one of three appropriate statements specified in the case problem in Chapter 4, based on a comparison between the number of contestants this year and last year.

Using the GreenvilleRevenue program you wrote in Case Study 1 of Chapter 4, modify the program so that the user must enter a number between 0 and 30, inclusive, for the number of contestants each year. If the user enters an incorrect number, the program prompts for a valid value.
*/

using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
      // Variables for holding this year and last year's contestants
      int lastYear = 0, thisYear = 0;

      // Booleans for checking validity of inputs
      bool valid1 = false, valid2 = false;

      // Prompts user for number of last year's contestants
      while(valid1 == false)
      {
        WriteLine("Enter number of contestants last year >>");
        lastYear = int.Parse(ReadLine());

        // Checks if input is valid
        if(lastYear >= 0 && lastYear <= 30)
          valid1 = true;
        else
          WriteLine("Invalid value");
      }

      // Prompts user for number of this year's contestants 
      while(valid2 == false)
      {
        WriteLine("Enter number of contestants this year >>");
        thisYear = int.Parse(ReadLine());

        // Checks if input is valid
        if(thisYear >= 0 && thisYear <= 30)
          valid2 = true;
        else
          WriteLine("Invalid value");
      }

      // Calculates revenue for this year
      int revenue = thisYear * 25;

      // Print competition information
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
