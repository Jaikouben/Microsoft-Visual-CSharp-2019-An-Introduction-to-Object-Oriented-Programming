/*
Write a program named StopSign that displays a pattern similar to the image shown below.

The number of spaces for each row in the image shown above are as follows:

1. 3 spaces (all padding left)
2. 9 spaces (1 padding left)
3. 6 spaces
4. 9 spaces (1 padding left)
5. 3 spaces (all padding left)
6. 6 spaces (all padding left)
7. 6 spaces (all padding left)
8. 6 spaces (all padding left)
*/

using static System.Console;
class StopSign
{
   static void Main()
   {
    // Display a stop sign
    WriteLine("   XXXXXX");
    WriteLine(" X        X");
    WriteLine("X   STOP   X");
    WriteLine(" X        X");
    WriteLine("   XXXXXX");
    WriteLine("      X");
    WriteLine("      X");
    WriteLine("      X");
   }
}
