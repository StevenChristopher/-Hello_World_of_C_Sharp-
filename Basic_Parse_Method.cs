/* SOURCE:   https://www.dotnetperls.com/parse          
 * AUTHOR:   
 * FILENAME: Basic_Parse_Method
 * PURPOSE:  
 * STUDENT:  Steven Christopher
 * DATE:     MAR 02 2019
*/

// STYLE MODIFICATIONS:


// FUNCTIONAL MODIFICATIONS:

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
