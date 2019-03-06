/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.7.2             
 * AUTHOR:   
 * FILENAME: Random_Number_Generator.cs
 * PURPOSE:  Demonstrate a program designed to randomly generate a number using
             the Random() method.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 31 2019
*/

// STYLE MODIFICATIONS: 
// 1) Console display messages are unique.
// 2) Used 'ii' as a control structure variable.

// FUNCTIONAL MODIFICATIONS:
// 1) Iterated through only 3 times.
// 2) Program Exit prompt.
// 3) Changed range to 1 through 10.

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
