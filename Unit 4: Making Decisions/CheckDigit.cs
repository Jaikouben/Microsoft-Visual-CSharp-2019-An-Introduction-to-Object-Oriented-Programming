/*
Account numbers sometimes contain a check digit that is the result of a mathematical calculation. The inclusion of the digit in an account number helps ascertain whether the number is a valid one.

Write an application named CheckDigit that asks a user to enter a four-digit account number and determines whether it is a valid number.

The number is valid if the fourth digit is the remainder when the number represented by the first three digits of the four-digit number is divided by 7. For example, 7770 is valid, because 0 is the remainder when 777 is divided by 7.

If the account number is valid, output The account number is valid. If the account number is invalid output Invalid. If the account number is too short or too long output Account number invalid - it must have 4 digits.
*/

using System;
class CheckDigit 
{
  public static void Main (string[] args) 
  {
    int check;
    string account;
    
    // Prompts user to enter their account number
    Console.WriteLine("Enter the account number: "); 
    account = Console.ReadLine();

    // Prints error message if account number is invalid
    if (account.Length<4)
      Console.WriteLine("Account number invalid - it must have 4 digits.");

    // Checks for validity of the account number
    string checkNum1 = account.Substring(0,3);
    string checkNum2 = account.Substring(3,1);
    int n1 = Convert.ToInt32(checkNum1);
    int n2 = Convert.ToInt32(checkNum2);
    
    // Displays the validity
    if (n1 % 7==n2)
      Console.WriteLine("The account number is valid.");
    else
      Console.WriteLine("Invalid.");
  }
}
