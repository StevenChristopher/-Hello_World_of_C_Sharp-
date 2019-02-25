/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays            
   AUTHOR:   MS
   FILENAME: Multi_Dimentional_Array.cs
   PURPOSE:  This program initializes and declares a multi-dimentional array with
             dimensions of the array specified. Indices are referenced and displayed
             to the console along with the rank of the array.
   STUDENT:  Steven Christopher
   DATE:     FEB 03 2019
*/

// STYLE MODIFICATIONS:
// o Modified the array name.
// o Specified the number values of indices.
// o Displayed the selected numbers vertically for easier comprehension.

// FUNCTIONAL MODIFICATIONS:
// o Added the rank identifier for the array.
// o Added unique dialogue.
// o Program exit prompt added.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dimentional_Array
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // Access indices on array
            System.Console.Write("\nOutput: ");
            System.Console.WriteLine(array2D [0, 1]);
            System.Console.WriteLine(array2D [2, 0]);
            System.Console.WriteLine(array2D [1, 1]);

            // Display the rank or dimension of the given array
            System.Console.Write("\n\nRank: ");
            System.Console.Write(array2D.Rank);

            System.Console.WriteLine("\n\n<Press Any Key to Exit>");
            System.Console.ReadLine();
        }
    }
}