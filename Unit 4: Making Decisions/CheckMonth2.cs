/*
Write a program named CheckMonth2 that prompts a user to enter a birth month and day.

Display an error message that says Invalid date if the month is invalid (not 1 through 12) or the day is invalid for the month (for example, not between 1 and 31 for January or between 1 and 29 for February).

If the month and day are valid, display them with a message. For example, if the month entered is 2, and the day entered is 17, the output should be 2/17 is a valid birthday.
*/

using System;
using static System.Console;
class CheckMonth2
{
   static void Main()
   {
      // Prompts user to enter a birth month and day 
      WriteLine("Enter a month >>");
      int month = int.Parse(ReadLine());
      WriteLine("Enter a day");
      int day = int.Parse(ReadLine());

      // Checks to see if month is valid, then checks to see if date is valid
      if(month >= 1 && month <= 12)
      {
        switch(month)
        {
          case 1:
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 2: 
            if (day >= 1 && day <= 29)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 3: 
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 4:
            if(day >= 1 && day <= 30)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 5: 
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 6:
            if(day >= 1 && day <= 30)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 7:
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 8:
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else
              WriteLine("Invalid date");
            break;
          case 9:
            if(day >= 1 && day <= 30)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else
              WriteLine("Invalid date");
            break;
          case 10:
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else
              WriteLine("Invalid date");
            break;
          case 11:
            if(day >= 1 && day <= 30)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else 
              WriteLine("Invalid date");
            break;
          case 12:
            if(day >= 1 && day <= 31)
              WriteLine("{0}/{1} is a valid birthday", month, day);
            else
              WriteLine("Invalid date");
            break;
        }
      }
      else
        WriteLine("Invalid date");
   }
}
