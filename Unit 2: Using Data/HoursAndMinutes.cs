/*
Write a program named HoursAndMinutes that declares a minutes variable to represent minutes worked on a job, and assign a value to it.

Display the value in hours and minutes. For example, if 98 is assigned to the minutes variable, the output would be: 98 minutes is 1 hours and 38 minutes.

Note: For final submission assign 197 to the minutes variable
*/

using System;
using static System.Console;
class HoursAndMinutes
{
   static void Main()
   {
      // Declares a variable representing minutes
      int minutes = 197;

      // Displays the value in hours and minutes
      WriteLine(minutes + " minutes is " + (minutes / 60) + " hours and " + (minutes % 60) + " minutes ");
   }
}
