/*
The provided file has syntax and/or logical errors. Determine the problem(s) and fix the program.
*/

// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;
class DebugFive3
{
   static void Main()
   {
      char letter;
      int number;
      const int LOW = 0;
      const int HIGH = 99;
      const int NUMINROW = 20;
      for (letter = 'A'; letter <= 'Z'; ++letter)
        for (number = LOW; number <= HIGH; ++number)
        {
        if(number % NUMINROW == 0)
          WriteLine();
          Write("{0}{1} ", letter.ToString(), number.ToString("D2"));
        }
   }
}
