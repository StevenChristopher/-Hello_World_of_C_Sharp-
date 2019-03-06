/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while             
 * AUTHOR:   MS
 * FILENAME: Hello_While_Loop.cs
 * PURPOSE:  Demonstrate the use of a while loop control structure within the
             'Hello, World' program.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS: 
// 1) Added another program exit prompt in the case the user doesn't select Enter key.
// 2) Additional message is displayed in red.

// FUNCTIONAL MODIFICATIONS:
// 1) Used ReadKey() to determine if the user selected desired input.
// 2) Alternative interaction added in the case of incorrect user input.

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
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                // Text color is changed to red to emphasize required user input.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nYou must press <ENTER> to exit.");
            }
        }
    }
}
