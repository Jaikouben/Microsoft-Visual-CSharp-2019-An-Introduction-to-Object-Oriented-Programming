/*
Write a program named Eggs that declares four variables of type int to hold the number of eggs produced in a month by each of four chickens, and assign a value to each variable. Call these variables chicken1, chicken2, etc.

Sum the eggs, then display the total in dozens and eggs. For example, if the total number of eggs was 95, the output would be 95 eggs is 7 dozen and 11 eggs.

Note: For final submission ensure that the total number eggs equals 127.
*/

using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
     // Declares integer variables representing amount of eggs per chicken
     int chicken1 = 100;
     int chicken2 = 10;
     int chicken3 = 10;
     int chicken4 = 7;

     // Calculates total eggs in dozens
     int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
     int dozens = totalEggs / 12;
     int eggs = totalEggs % 12;

     // Prints results
     WriteLine("{0} eggs is {1} dozen and {2} eggs", totalEggs, dozens, eggs);
   }
}
