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

namespace Reverse_Word_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a sentence:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string s1 = Console.ReadLine();

            string[] words = s1.Split(' ');
            Array.Reverse(words);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sentence in reverse:\n");

            for (int i = 0; i <= words.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(words[i] + "" + ' ');            
            }

            Console.ReadKey();
        }
    }
}
