/* SOURCE:   https://www.dotnetperls.com/do         
   AUTHOR:   UNKNOWN
   FILENAME: Input_and_Output_v2.cs
   PURPOSE:  Demonstrate the use of a do-while loop control structure.
   STUDENT:  Steven Christopher
   DATE:     JAN 27 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the following sorted integer array
            int[] sortedArray = new int[] { 25, 38, 68, 88, 121, 146, 177, 220, 233 };

            // Declaration of two additional integer variables.
            int sum = 0;
            int i = 0;

            // This loop will add each index value with the next in the integer array.
            do
            {
                sum += sortedArray[i];
                i++;
            } while (i < 9);

            // Display the sum of indices
            Console.Write("\n\nSum of Array Indices = ");
            System.Console.WriteLine(sum);
            Console.Write("\n\n<Press Any Key to Exit>");
            Console.ReadLine();
        }
    }
}
