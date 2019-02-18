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

namespace Array_Sort
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] numArray = new int[] {68, 88, 233, 25, 38, 146, 121, 220, 177, 177};

            Array.Sort(numArray);

            Console.Write("\nSorted Array:\n\n");

            // A foreach loop writes the sorted array to the console display
            foreach (int i in numArray) Console.Write(i + " ");

            Console.WriteLine("\n\n<Press Any Key to Exit>");
            Console.ReadKey(true);
        }
    }
}
