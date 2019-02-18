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

namespace Single_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of an integer type, Single-Dimentional Array.
            // I used my Random_Number_Generator program to generate ten
            // random, byte-sized numbers and included them in this array.
            int[] numArray = new int[] {68, 88, 233, 25, 38, 146, 121, 220, 177, 177};

            int n = 0;

            // Step through the array with a for loop. The array.Length comparison
            // allows us to determine the length of the array if we didn't know.
            for (int i = 0; i < numArray.Length; i++)
            {
                n++;
            }
            
            Console.WriteLine("\nTotal Array Indices: " + n);
            Console.WriteLine("\n<Press Any Key to Exit>");
            Console.ReadLine();
        }
    }
}