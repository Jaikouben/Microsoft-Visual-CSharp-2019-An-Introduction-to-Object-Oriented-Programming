/*
Write a program named Admission for a college’s admissions office. The user enters a numeric high school grade point average (for example, 3.2) and an admission test score.

Display the message Accept if the student meets either of the following requirements:

A grade point average of 3.0 or higher, and an admission test score of at least 60
A grade point average of less than 3.0, and an admission test score of at least 80
If the student does not meet either of the qualification criteria, display Reject.
*/

using System;
using static System.Console;
class Admission
{
   static void Main()
   {
      // Prompts the student to enter their GPA
      WriteLine("Enter your GPA >>");
      double gpa = double.Parse(ReadLine());
      WriteLine("Enter your test score >>");
      int testScore = int.Parse(ReadLine());

      // Determines if the student was accepted or rejected
      if(gpa >= 3.0 && testScore >= 60)
        WriteLine("Accept");
      else
        if(gpa < 3.0 && testScore >= 80)
          WriteLine("Accept");
      else 
        WriteLine("Reject");
   }
}
