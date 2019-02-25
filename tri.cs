/* SOURCE:   https://www.sanfoundry.com/csahrp-program-binarytriangle/           
   AUTHOR:   UNKNOWN
   FILENAME: Binary_Triangle.cs
   PURPOSE:  This program takes user input and parses it into an integer. That
             integer value is ran through for loops in order to print a tri-
             angle consisting of ones and zeroes.
   STUDENT:  Steven Christopher
   DATE:     FEB 07 2019
*/

// STYLE MODIFICATIONS:
// o Unique dialogue prompt to the console display.

// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, lastInt = 0, input;
            Console.WriteLine("Enter the Number of Rows for Your Triangle: ");

            // Parse user input into an integer.
            input = int.Parse(Console.ReadLine());

            // Condition is met if user enters 1 or greater.
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    // The value of lastInt
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                // Return to the next line and to the top of the for loop.
                Console.Write("\n");
            }
            // Program exit.
            Console.ReadLine();
        }
    }
}