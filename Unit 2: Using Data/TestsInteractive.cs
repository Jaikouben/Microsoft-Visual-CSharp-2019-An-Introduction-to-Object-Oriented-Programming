/*
Write a program named TestsInteractive that prompts a user to enter eight test scores and displays the average of the test scores to two decimal places.

An example of the program is shown below:
*/

using System;
using static System.Console;
class TestsInteractive
{
   static void Main()
   {
     // Prompts the user to enter different test scores
     WriteLine("Enter test score 1 >> ");
     double score1 = Double.Parse(ReadLine());
     WriteLine("Enter test score 2 >> ");
     double score2 = Double.Parse(ReadLine());
     WriteLine("Enter test score 3 >> ");
     double score3 = Double.Parse(ReadLine());
     WriteLine("Enter test score 4 >> ");
     double score4 = Double.Parse(ReadLine());
     WriteLine("Enter test score 5 >> ");
     double score5 = Double.Parse(ReadLine());
     WriteLine("Enter test score 6 >> ");
     double score6 = Double.Parse(ReadLine());
     WriteLine("Enter test score 7 >> ");
     double score7 = Double.Parse(ReadLine());
     WriteLine("Enter test score 8 >> ");
     double score8 = Double.Parse(ReadLine());

     // Calculates average
     double average = (score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8) / 8;

     // Displays results
     WriteLine("The average test score is {0}", average.ToString("#0.00"));
   }
}
