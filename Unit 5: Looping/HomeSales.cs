/*
Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an application named HomeSales that prompts the user for a salesperson initial (D, E, or F) input as a string. Either uppercase or lowercase initials are valid. While the user does not type Z, continue by prompting for the amount of a sale. Issue the error message "Sorry - invalid salesperson" for any invalid initials entered. Keep a running total of the amounts sold by each salesperson. After the user types Z or z for an initial, display each salesperson’s total, a grand total for all sales, and the name of the salesperson with the highest total unless there is a tie. If there is a tie, indicate this in the program's output with the message: "There was a tie".
*/

using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
   static void Main()
   {
    // Variable for salesperson initial
    char salesperson = ' ';

    // Variables representing sales
    double totalSales = 0, sale = 0, salesD = 0, salesE = 0, salesF = 0;

    bool on = true;
    while(on == true)
    {
      // Prompts user for salesperson initial
      WriteLine("Enter a salesperson initial >>");
      salesperson = char.Parse(ReadLine());

      if(salesperson == 'D' || salesperson == 'd' || salesperson == 'E' || salesperson == 'e' || salesperson == 'F' || salesperson == 'f')
      {
        // Prompts user for amount of sale
        WriteLine("Enter amount of sale >>");
        sale = double.Parse(ReadLine());
        totalSales += sale;

        // Assigns sale to salesperson 
        if(salesperson == 'D' || salesperson == 'd')
          salesD += sale;
        if(salesperson == 'E' || salesperson == 'e')
          salesE += sale;
        if(salesperson == 'F' || salesperson == 'f')
          salesF += sale;

      }
      else
        // Displays sales information
        if(salesperson == 'Z' || salesperson == 'z')
        {
          WriteLine("Danielle sold {0}", salesD.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Edward sold {0}", salesE.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Francis sold {0}", salesF.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Total sales were {0}", totalSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          // Calculates who made the most sales
          if(salesD > salesE || salesD > salesF)
            WriteLine("Danielle sold the most");
          else
            if(salesE > salesD || salesE > salesF)
              WriteLine("Edward sold the most");
            else
              if(salesF > salesD || salesF > salesE)
                WriteLine("Francis sold the most");
              else
                if(salesD == salesE || salesD == salesF || salesE == salesF)
                  WriteLine("There was a tie");
          on = false; // Stops the program

        }
        else
          WriteLine("Sorry - invalid salesperson");
      }
   }
}
