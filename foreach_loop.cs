/* SOURCE:   https://www.dotnetperls.com/foreach
 * AUTHOR:   
 * FILENAME: foreach_Loop.cs
 * PURPOSE:  Demonstrate the basic functionality of the foreach loop control structure.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS:
// 1) Added console display message prior to displaying string array values.
// 2) Changed the string array to dogs
// 3) Displayed counter values as a cheesy rocketship countdown.

// FUNCTIONAL MODIFICATIONS:
// 1) Added an exit prompt to program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the following string array of various dogs.
            string[] dogs = { "Labradore", "Terrier", "Pug", "Shephard", "Dachshund", "Pitbull" };
            Console.Write("\nDogs in my string array:\n\n");

            // Considered the easiest, least error prone loop. This type of loop uses no integer
            // index and acts on collections, returning each element in order.
            foreach (string value in dogs)
            {
                Console.WriteLine(value);
            }

            Console.Write("\nPress Any Key to Exit");
            Console.ReadKey();

        }
    }
}
