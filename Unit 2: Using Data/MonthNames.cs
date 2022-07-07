/*
Create an enumeration named Month that holds values for the months of the year. With JANUARY equal to 1, FEBRUARY equal to 2, and so on through DECEMBER equal to 12.

Write a program named MonthNames that prompts the user for a month integer. Convert the user’s entry to a Month value, and display it.
*/

using System;
using static System.Console;
class MonthNames
{
   // Creates new enumeration
   enum Month 
   {
      JANUARY = 1,
      FEBRUARY = 2,
      MARCH = 3,
      APRIL = 4,
      MAY = 5,
      JUNE = 6,
      JULY = 7,
      AUGUST = 8,
      SEPTEMBER = 9,
      OCTOBER = 10,
      NOVEMBER = 11,
      DECEMBER = 12
   }

   // Main method
   static void Main()
   {
      // Prompts user to enter a month number
      WriteLine("Enter a month number >> ");
      Month monthNum = (Month) int.Parse(ReadLine());
      
      // Displays the month value
      WriteLine(monthNum);
   }
}
