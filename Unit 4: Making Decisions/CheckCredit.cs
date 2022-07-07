/*
Write a program named CheckCredit that prompts users to enter a purchase price for an item.

If the value entered is greater than a credit limit of $8,000, display You have exceeded the credit limit; otherwise, display Approved.
*/

using System;
using static System.Console;
class CheckCredit
{
   static void Main()
   {
      // Creates integer representing the credit limit
      int purchaseMax = 8000;

      // Prompts user to enter price of item
      WriteLine("Enter the price of the item >>");
      int purchase = int.Parse(ReadLine());
      
      // Checks if purchase exceeds the credit limit
      if(purchase > purchaseMax)
        WriteLine("You have exceeded the credit limit");
      else
        WriteLine("Approved");
   }
}
