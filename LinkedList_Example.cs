/* SOURCE:   https://www.dotnetperls.com/linkedlist           
 * AUTHOR:   
 * FILENAME: LinkedList_Example.cs
 * PURPOSE:  Demonstrate the basic functionality of a LinkedList<T>.        
 * STUDENT:  Steven Christopher
 * DATE:     MAR 01 2019
*/

// STYLE MODIFICATIONS:
// 1) Added unique console display messaging.
// 2) Put unique values into the list.

// FUNCTIONAL MODIFICATIONS:
// 1) Added a program exit.

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
            
            // A foreach loop seems ideal for outputting values from this data structure.
            foreach (var item in groceries)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
