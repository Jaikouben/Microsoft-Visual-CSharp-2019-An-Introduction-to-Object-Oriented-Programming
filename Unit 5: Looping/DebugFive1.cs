/*
The provided file has syntax and/or logical errors. Determine the problem and fix the program.
*/

// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using static System.Console;
class DebugFive1
{
   static void Main()
   {
      const string PASS1 = "home";
      const string PASS2 = "lady";
      const string PASS3 = "mouse";
      string password;

      Write("Please enter your password ");
      password = ReadLine();
      if(password.Equals(PASS1) || password.Equals(PASS2) || password.Equals(PASS3))
        WriteLine("Valid password");   
      else
        WriteLine("Invalid password. Please enter again. ");
      password = ReadLine();
   }
}
