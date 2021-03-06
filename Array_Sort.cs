/* SOURCE:   Fundamentals of Computer Programming with C Sharp(pp.239)
 * AUTHOR:   Svetlin Nakov, Veselin Kolev & Co.
 * PURPOSE:  Demonstrate the Array.Sort() method. I used the previously
             generated array from the Single_Dimentional_Array.cs program.
 * FILENAME: Array_Sort.cs
 * STUDENT:  Steven Christopher
 * DATE:     FEB 04 2019
*/

// STYLE MODIFICATIONS:
// 1) Displayed the sorted array.
// 2) Unique dialogue and dialogue options.

// FUNCTIONAL MODIFICATIONS: 
// 1) The array created in the Single_Dimentional_Array.cs program was used.
// 2) Program exit prompt.
// 3) ReadKey() method use to end the program.

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
            int[] numArray = new int[] { 68, 88, 233, 25, 38, 146, 121, 220, 177, 177 };

            Array.Sort(numArray);

            Console.Write("\nSorted Array:\n\n");

            // A foreach loop writes the sorted array to the console display
            foreach (int i in numArray) Console.Write(i + " ");

            Console.WriteLine("\n\n<Press Any Key to Exit>");
            Console.ReadKey(true);
        }
    }
}
