/* SOURCE:   https://www.c-sharpcorner.com/forums/how-to-remove-duplicate-number-in-array             
   AUTHOR:   Surendra Kandira
   FILENAME: Removing_Array_Duplicates.cs
   PURPOSE:  Demonstrate the Distinct() method and the ToArray() method
             in removing duplicates from an array quickly.
   STUDENT:  Steven Christopher
   DATE:     JAN 29 2019
*/

// STYLE MODIFICATIONS: 
// o Added console display dialogue results.
// o Added exit program prompt.

// FUNCTIONAL MODIFICATIONS:
// o Used array from previous Array_Sort.cs program.
// o Added program exit.
// o Displayed results of the duplicate-free and sorted array.

using System;
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

            // Create another integer array and use Distinct() method to remove duplicates.
            // The ToArray() method creates numArray2 without duplicates.
            int[] numArray2 = numArray.Distinct().ToArray();

            Array.Sort(numArray2);            

            Console.Write("\nDuplicate-Free and Sorted Array: ");

            foreach (int i in numArray2) Console.Write(i + " ");
            Console.WriteLine("\n\n<Press Any Key to Exit>");
            Console.ReadKey(true);
        }
    }
}
