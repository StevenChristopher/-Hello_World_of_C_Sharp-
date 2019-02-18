/* SOURCE:                
   AUTHOR:   
   FILENAME: Input_and_Output_v2.cs
   PURPOSE:  Demonstrate the StringBuilder class which provides many useful methods for
             representing a mutable string of characters. StringBuilder seems to be much
             more intuitive in certain cases compared to the Console class. Nonetheless,
             both have their place.
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

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 25, 38, 68, 88, 121, 146, 177, 220, 233 };
            int sum = 0;
            int i = 0;

            do
            {
                sum += sortedArray[i];
                i++;
            } while (i < 9);

            Console.Write("\n\nSum of Array Indices = ");
            System.Console.WriteLine(sum);
            Console.Write("\n\n<Press Any Key to Exit>");
            Console.ReadLine();
        }
    }
}
