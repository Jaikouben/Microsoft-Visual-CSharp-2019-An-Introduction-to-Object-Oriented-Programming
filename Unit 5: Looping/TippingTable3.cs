/*
In a “You Do It” section of Chapter 5 in your book, you created a tipping table for patrons to use when analyzing their restaurant bills. Now, create a modified program named TippingTable3 in which each of the following values is obtained from user input:
  The lowest tipping percentage
  The highest tipping percentage
  The lowest possible restaurant bill
  The highest restaurant bill
  
Below is a summary of the "You Do It" section's instructions:

Write a program that creates a tipping table that restaurant patrons can use to approximate the correct tip for meals. Prices range from $10 to $100, and tipping percentage rates range from 10 percent to 25 percent. The program uses several loops. An example of the program is shown below:
*/

using System;
using static System.Console;
using System.Globalization;
class TippingTable3
{
   static void Main()
   {
      // Delcares variables
      double dinnerPrice = 10.00;
      double tipRate;
      double tip;
      double lowRate = 0.10;
      double maxRate = 0.25;
      double maxDinner = 100.00;
      const double TIPSTEP = 0.05;
      const double DINNERSTEP = 10.00;

      // Prompts the user to enter tip and price information
      WriteLine("Enter lowest tip rate >>");
      lowRate = double.Parse(ReadLine());
      WriteLine("Enter max tip rate >>");
      maxRate = double.Parse(ReadLine());
      WriteLine("Enter minimum dinner price:");
      dinnerPrice = double.Parse(ReadLine());
      WriteLine("Enter maximum dinner price:");
      maxDinner = double.Parse(ReadLine());

      // Prints table
      Write("   Price");
      for (tipRate = lowRate; tipRate <= maxRate; tipRate += TIPSTEP)
        Write("{0,8}", tipRate.ToString("F"));
          tipRate = lowRate;
          WriteLine();
          WriteLine("----------------------------------------");
          while(dinnerPrice <= maxDinner)
          {
            Write("{0, 8}", dinnerPrice.ToString("C"));
            while(tipRate <= maxRate)
            {
              tip = dinnerPrice * tipRate;
              Write("{0,8}", tip.ToString("F"));
              tipRate += TIPSTEP;
            }
              dinnerPrice += DINNERSTEP;
              tipRate = lowRate;
              WriteLine();
            }

          WriteLine("--End--");
   }
}
