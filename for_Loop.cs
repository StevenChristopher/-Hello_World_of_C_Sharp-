/* SOURCE:   Fundamentals of Computer Programming with C Sharp
 * AUTHOR:   Svetlin Nakov, Veselin Kolev & Co.
 * FILENAME: for_Loop.cs
 * PURPOSE:  Demonstrate the basic functionality of the for loop control structure.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS:
// 1) Added console display message prior to displaying i variable values.
// 2) Changed i variable values to be displayed in the color green.

// FUNCTIONAL MODIFICATIONS:
// 1) Added an exit prompt to program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nVariable 'i' value after each loop iteration: ");

            // for loops are used to step through a process over a known number of iterations.
            // Variables i, j, and k are normally used as 'loop control variables'.
            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");    
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n<Press Any Key to Exit>");
            Console.ReadKey();
        }
    }
}
