/*
Modify the Eggs program you wrote in Exercise 8 and create a new program named EggsInteractive that prompts the user for and accepts a number of eggs for each chicken.

Sum the eggs input, then display the total in dozens and eggs. For example, if the input was 30, 40, 35, 22, the output would be 127 eggs is 10 dozen and 7 eggs.
*/

using System;
using static System.Console;
class Eggs
{
   static void Main()
   {
     // Chicken variables
     int chicken1 = Int32.Parse(ReadLine());
     int chicken2 = Int32.Parse(ReadLine());
     int chicken3 = Int32.Parse(ReadLine());
     int chicken4 = Int32.Parse(ReadLine());
     
     // Calculations
     int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
     int dozens = totalEggs / 12;
     int eggs = totalEggs % 12;

     // Prints results
     WriteLine("{0} eggs is {1} dozen and {2} eggs", totalEggs, dozens, eggs);
   }
}
