/*
Pig Latin is a nonsense language. To create a word in pig Latin, you remove the first letter and then add the first letter and “ay” at the end of the word. For example, “dog” becomes “ogday” and “cat” becomes “atcay.”

Write a program named PigLatin that allows the user to enter a word and displays the pig Latin version.
*/

using static System.Console;
class PigLatin
{
   static void Main()
   {
      // Prompts user to enter a word
      WriteLine("Enter a word >> ");
      string word = ReadLine();

      // Displays the word in Pig Latin
      WriteLine(word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay");
   }
}
