/* SOURCE:   Fundamentals of Computer Programming with C Sharp(pp.212)
 * AUTHOR:   Svetlin Nakov, Veselin Kolev & Co.
 * FILENAME: while_Loop.cs
 * PURPOSE:  Demonstrate the basic functionality of the while loop control structure.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS:
// 1) Added console display message prior to displaying counter variable values.
// 2) Changed counter variable values to be displayed in the color red.
// 3) Displayed counter values as a cheesy rocketship countdown.

// FUNCTIONAL MODIFICATIONS:
// 1) Added an exit prompt to program.
// 2) Added a decrement to the counter variable.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counter was set to 11 in order to include 10 in our countdown.
            int counter = 11;

            Console.WriteLine("\nPrepare for lift off in:\n\n");

            while (counter != 0)
            {
                // Decrement the counter variable.
                --counter;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(counter);
            }

            Console.WriteLine("Lift Off!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
