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

uusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_Array_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] {68, 88, 233, 25, 38, 146, 121, 220, 177, 177};

            int[] numArray2 = numArray.Distinct().ToArray();

            Array.Sort(numArray2);            

            Console.Write("\nDuplicate-Free and Sorted Array: ");

            foreach (int i in numArray2) Console.Write(i + " ");
            Console.WriteLine("\n\n<Press Any Key to Exit>");
            Console.ReadKey(true);

        }
    }
}
