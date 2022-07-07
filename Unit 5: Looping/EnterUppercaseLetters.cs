/*
Write an application named EnterUppercaseLetters that asks the user to type an uppercase letter from the keyboard. If the character entered is an uppercase letter, display: OK; if it is not an uppercase letter, display the error message: Sorry - that was not an uppercase letter. . The program continues until the user types an exclamation point (!).

An example of the program is shown below:
  Enter an uppercase letter >> T
  OK
  Enter an uppercase letter or ! to quit t
  Sorry - that was not an uppercase letter.
  Enter an uppercase letter or ! to quit !
*/

using System;
using static System.Console;
class EnterUppercaseLetters
{
   static void Main()
   {
    // Declares the char variable
    char character;

    // Do while loop for asking input
    do 
    {
      character = char.Parse(ReadLine());
      if(Char.IsUpper(character))
        WriteLine("OK");
      else 
        WriteLine("Sorry - that was not an uppercase letter");
    }
    while(character != '!');
   }
}
