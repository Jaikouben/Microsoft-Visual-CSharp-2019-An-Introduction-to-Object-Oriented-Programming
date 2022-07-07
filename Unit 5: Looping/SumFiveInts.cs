/*
Write an application named SumFiveInts that allows the user to enter five integers and displays their sum.
*/

using System;
using static System.Console;
class SumFiveints
{
   static void Main()
   {
    // Allows the user to enter five integers
    int int1 = int.Parse(ReadLine());
    int int2 = int.Parse(ReadLine());
    int int3 = int.Parse(ReadLine());
    int int4 = int.Parse(ReadLine());
    int int5 = int.Parse(ReadLine());

    // Prints the sum of all five integers
    WriteLine(int1 + int2 + int3 + int4 + int5);
   }
}
