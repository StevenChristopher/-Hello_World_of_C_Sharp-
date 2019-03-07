/* SOURCE:   https://www.dotnetperls.com/parse          
 * AUTHOR:   
 * FILENAME: Basic_Parse_Method
 * PURPOSE:  Demonstrate the basic functionality of the Parse() method and
             how it can take a string and convert it, or, parse it to an integer.
 * STUDENT:  Steven Christopher
 * DATE:     MAR 05 2019
*/

// STYLE MODIFICATIONS:
// 1) Used my favorite number - 254.
// 2) Added console display messaging.

// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Parse_Method
{
    class Program
    {
        static void Main(string[] args)
        {            
                // Convert string to number.
                string text = "254";
                int num = int.Parse(text);
                Console.Write("\nResulting Integer Value: " + num);
                Console.Write("\n\n<Press Any Key To Exit>");
                Console.ReadLine();            
        }
    }
}
