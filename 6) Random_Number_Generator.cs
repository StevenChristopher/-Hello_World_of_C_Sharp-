/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.7.2             
   AUTHOR:   MS
   FILENAME: Random_Number_Generator.cs
   PURPOSE:  Demonstrate a program designed to randomly generate a number using
             the Random() method. It will do this three times to show that the number
             range is between 1 and 10.
   STUDENT:  Steven Christopher
   DATE:     JAN 28 2019
*/

// STYLE MODIFICATIONS: 
// o Console display message is unique.
// o Exit prompt message.
// o I chose 1 through 10 as the range so that I can
//   demonstrate the mathematical logic in previous Input_and_Output.cs program.

// FUNCTIONAL MODIFICATIONS:
// o Iterated through only 3 times.
// o Exit prompt and program exit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main()
        {
            Random num = new Random();

            Console.WriteLine("\nRandom Number Between 1 and 10:\n");

            // Iterate through and display three different random numbers.
            // Numbers should range between 1 and 10.
            for (int ii = 0; ii <= 2; ii++)
            {
                Console.Write("{0, 8:N0} ", num.Next(1, 11));
            }
            Console.WriteLine();
            Console.Write("\n<Press Any Key to Exit>");
            Console.ReadLine();
        }
    }
}
