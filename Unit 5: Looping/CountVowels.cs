/*
Write a program named CountVowels that accepts a phrase from the user and counts the number of vowels in the phrase. For this exercise, count both uppercase and lowercase vowels, but do not consider y to be a vowel.
*/

using System;
using static System.Console;
class CountVowels
{
   static void Main()
   {
      // Creates variables
      string phrase = "";
      int vowelCount = 0;
      char checkLetter;

      // Prompts the user to enter a phrase
      WriteLine("Enter a phrase >>");
      phrase = ReadLine();

      // Searches for vowels
      for (int i = 0; i < phrase.Length; ++i)
      {
        checkLetter = char.ToUpper(phrase[i]);
        switch(checkLetter)    
        {
          case 'A':
            vowelCount++;
            break;
          case 'E':
            vowelCount++;
            break;
          case 'I':
            vowelCount++;
            break;
          case 'O':
            vowelCount++;
            break;
          case 'U':
            vowelCount++;
            break;
        }
      }
      WriteLine("Vowels: " + vowelCount);
   }
}
