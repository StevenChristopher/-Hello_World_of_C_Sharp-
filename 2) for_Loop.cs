/* SOURCE:                
   AUTHOR:   
   FILENAME: for_Loop.cs
   PURPOSE:  Demonstrate the basic functionality of the for loop control structure.
   STUDENT:  Steven Christopher
   DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS:
// o Added console display message prior to displaying i variable values.
// o Changed i variable values to be displayed in the color blue.

// FUNCTIONAL MODIFICATIONS:
// o 

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
            Console.Write("\n\nVariable 'i' value after each loop iteration:");
			
            // for loops are used to step through a process over a known number of iterations.
            // Variables i, j, and k are normally used as 'loop control variables'.
	    // The for loop variable must be initialized and incremented.
            for (int i = 0; i < 10; i++)
            {
		    Console.ForgroundColor = ConsoleColor.
                Console.Write(i + " ");                
            }

            Console.Write("\n\n<Press Any Key to Exit>");
            Console.ReadKey();
        }
    }
}
