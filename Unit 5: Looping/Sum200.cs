/*
Write an application named Sum200 that sums the integers from 1 through 200. Display the running total when the program is halfway complete (after the first 100 numbers), and at the end.
*/

using static System.Console;
class Sum200
{
   static void Main()
   {
      // Variable for holding sum
      int sum200 = 0;

      // Loop for calculating the sum of the first hundred numbers
      for(int c = 1; c <= 100; c++)
      {
        sum200 += c;
      }

      // Displays the total 
      WriteLine(sum200);

      // Loop for calculating the sum of the second hundred numbers
      for(int c = 101; c <= 200; c++)
      {
        sum200 += c;
      }

      // Displays the total 
      WriteLine(sum200);
   }
}
