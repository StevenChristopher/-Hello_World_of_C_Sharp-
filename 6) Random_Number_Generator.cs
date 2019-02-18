/* SOURCE:                
   AUTHOR:   
   FILENAME: Input_and_Output_v2.cs
   PURPOSE:  Demonstrate the StringBuilder class which provides many useful methods for
             representing a mutable string of characters. StringBuilder seems to be much
             more intuitive in certain cases compared to the Console class. Nonetheless,
             both have their place.
   STUDENT:  Steven Christopher
   DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();

            byte[] numArray = new byte[10];
            num.NextBytes(numArray);

            Console.WriteLine("\nTen random byte-sized numbers:");

            foreach (byte byteValue in numArray)
                Console.Write("\n{0, 10}\n", byteValue);

            Console.Write("\n<Press Any Key to Exit>");
            Console.ReadLine();
        }
    }
}