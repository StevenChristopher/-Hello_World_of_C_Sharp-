/* SOURCE:   https://www.dotnetperls.com/linkedlist           
 * AUTHOR:   
 * FILENAME: LinkedList_Example.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 01 2019
*/

// STYLE MODIFICATIONS:
// 1) Added a basic console display for the return value.

// FUNCTIONAL MODIFICATIONS:
// 1) Passed integer values into the function.
// 2) Return and display the functions' return value.
// 3) Added Main() method and called in return function.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> groceries = new LinkedList<string>();

            groceries.AddLast("Bread");
            groceries.AddLast("Cheese");
            groceries.AddFirst("Milk");
            groceries.AddLast("Eggs");

            foreach (var item in groceries)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}