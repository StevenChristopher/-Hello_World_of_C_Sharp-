/* SOURCE:   https://www.sanfoundry.com/csharp-program-bitwise-swapping/            
 * AUTHOR:   
 * FILENAME: Swap_Numbers_Bitwise_Example
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

namespace Swap_Numbers_Bitwise_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            Console.WriteLine("Enter two integers: \n");
            // TODO Numbers are entered separately. Handle this better.
            i = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Before swapping i= {0} and k = {1}", i, k);
            i = i ^ k;
            k = i ^ k;
            i = i ^ k;
            Console.WriteLine("\n After swapping i= {0} and k = {1}", i, k);
            // TODO Prompt user to Exit
            Console.ReadLine();
        }
    }
}