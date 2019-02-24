/* SOURCE:   https://www.dotnetperls.com/do         
   AUTHOR:   UNKNOWN
   FILENAME: do_while_Loop.cs
   PURPOSE:  Demonstrate the use of a do-while loop control structure.
   STUDENT:  Steven Christopher
   DATE:     JAN 27 2019
*/

// STYLE MODIFICATIONS:
// o Added console display description of what the results represent.
// o Used the array from the Array_Sort.cs program.
// o Different array name.

// FUNCTIONAL MODIFICATIONS:
// o Used a different number of indices.
// o Added prompt for program exit.

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
            // do-while loops are normally used when you know you have to iterate through
            // the loop at least once. (e.g. a User Selection interface)
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
