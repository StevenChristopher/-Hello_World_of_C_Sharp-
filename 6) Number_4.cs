/* SOURCE:   https://www.sanfoundry.com/csharp-programs-generate-sum-digits/           
   AUTHOR:   UNKNOWN
   FILENAME: Number_4.cs
   PURPOSE:  Demonstrate a program designed to accept user input as a number between
             1 and 10. The input is parsed into and integer
   STUDENT:  Steven Christopher
   DATE:     JAN 29 2019
*/

// STYLE MODIFICATIONS: 
// o Console display message is unique.
// o Exit prompt message unique.
// o Dialogue spacing changed.

// FUNCTIONAL MODIFICATIONS:
// o Changed variable names for ease of reading.
// o Alternate exit prompt and program exit.
// o Alternate user input request.
// o Additional mathematically operations in while loop.
// o Additional mathematical operation after Parse.

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
