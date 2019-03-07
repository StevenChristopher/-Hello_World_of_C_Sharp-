/* SOURCE:   https://www.dotnetperls.com/ienumerable           
 * AUTHOR:   
 * FILENAME: IEnumerable_Example
 * PURPOSE:  Demonstrate some of the basic functionality of IEnumerable and
             showcase some simplistic features of IEnumerable.
 * STUDENT:  Steven Christopher
 * DATE:     MAR 05 2019
*/

// STYLE MODIFICATIONS: None.

// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extended number range.
            IEnumerable<int> result = from value in Enumerable.Range(0, 10)
                                      select value;

            // Iterate the range and write it.
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }

            // We can use extension methods on IEnumerable<int>
            double average = result.Average();

            // Extension methods can convert IEnumerable<int>
            List<int> list = result.ToList();
            int[] array = result.ToArray();
            
            // TODO Exit prompt.
            Console.ReadLine();
            
        }
    }
}
