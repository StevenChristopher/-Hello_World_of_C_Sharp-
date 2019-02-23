/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while             
   AUTHOR:   MS
   FILENAME: Hello_While_Loop.cs
   PURPOSE:  Demonstrate the while loop control structure and its' basic functionality.
   STUDENT:  Steven Christopher
   DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS: 
// o Added another program exit prompt in the case the user doesn't select Enter key.
// o Additional message is displayed in red.

// FUNCTIONAL MODIFICATIONS:
// o Used ReadKey() to determine if the user selected desired input.
// o Alternative interaction added in the case of incorrect user input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello, C# World!");
            Console.Write("\n--Press <ENTER> to exit...");

            // This while loop ensures the user has to press ENTER to exit the program.
            // So long as the while condition in the partentheses is met, the loop continues.
            // In this case, the user will be prompted to press <ENTER> and the program
            // won't exit until the <ENTER> key is selected.
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nYou must press <ENTER> to exit.");
            }
        }
    }
}
