/* SOURCE:   https://www.sanfoundry.com/csharp-programs-generate-sum-digits/           
 * AUTHOR:   
 * FILENAME: Number_4.cs
 * PURPOSE:  Demonstrate a program designed to accept user input as a number between
             1 and 10. The input is parsed into and integer and basic mathematical operations
             are performed. These mathematical operations represent the arithmetic behind
             the Input_and_Output.cs program. The result is ALWAYS the number 4!
 * STUDENT:  Steven Christopher
 * DATE:     FEB 04 2019
*/

// STYLE MODIFICATIONS: 
// 1) Console display messages are unique.
// 2) Exit prompt message unique.
// 3) Dialogue spacing adjusted.

// FUNCTIONAL MODIFICATIONS:
// 1) Changed variable names for ease of reading.
// 2) Alternate exit prompt and program exit.
// 3) Alternate user input request.
// 4) Additional mathematically operations in while loop.
// 5) Additional mathematical operation after Parse.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, nmbr, rmdr;
            Console.WriteLine("\n\nEnter a Number Between 1 and 10:");

            nmbr = int.Parse(Console.ReadLine());
            nmbr = nmbr * 9;

            while (nmbr != 0 && nmbr >= 10)
            {
                rmdr = nmbr % 10;
                nmbr = nmbr / 10;
                sum = nmbr + rmdr;
                nmbr = sum - 5;
            }

            Console.Write("\nThe new number: " + nmbr);
            Console.Write("\n\nPress Any Key to Exit");
            Console.ReadLine();
        }       
    }
}
