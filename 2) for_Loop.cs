/* SOURCE:                
   AUTHOR:   
   FILENAME: for_Loop.cs
   PURPOSE:  Demonstrate the basic functionality of the for loop control structure.
             This is a very simplistic look at how the for loop is used to step through.
   STUDENT:  Steven Christopher
   DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nDisplay of variable value after each loop iteration:\n");
			
            // for loops are used to iterate through process a known number of times.
            // Variables i, j, and k are normally used a lopp control variables.
	    // The for loop variable must be declared, initialized and incremented.
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");                
            }

            Console.Write("\n\n<Press Any Key to Exit>");
            Console.ReadKey();
        }
    }
}
