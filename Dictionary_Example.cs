/* SOURCE:   https://www.dotnetperls.com/dictionary            
 * AUTHOR:   
 * FILENAME: Dictionary_Example.cs
 * PURPOSE:  Demonstrate the basic functionality of a Dictionary<T> variable.        
 * STUDENT:  Steven Christopher
 * DATE:     MAR 01 2019
*/

// STYLE MODIFICATIONS:
// 1) Unique console display messages.
// 2) Unique dictionary keys and values.

// FUNCTIONAL MODIFICATIONS:
// 1) Program prompt and exit added.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Very Mild");
            dictionary.Add(2, "Mild");
            dictionary.Add(3, "Mild");
            dictionary.Add(4, "Fairly Mild");

            // TODO Attempt to Add() a duplicate key with a try-catch

            Console.WriteLine("\nDictionary Count: " + dictionary.Count);
            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }
    }
}
