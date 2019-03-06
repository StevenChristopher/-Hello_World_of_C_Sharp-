/* SOURCE:   https://www.c-sharpcorner.com/UploadFile/c63ec5/reverse-string-in-C-Sharp/             
 * AUTHOR:   Sharad Gupta
 * FILENAME: Reverse_Word_Order.cs
 * PURPOSE:  Demonstration of the Array.Reverse() method. The user is
             prompted to enter a sentence. The sentence is then reversed
             and printed.
 * STUDENT:  Steven Christopher
 * DATE:     FEB 06 2019
*/

// STYLE MODIFICATIONS:
// 1) Added different colors to the console display text.
// 2) Unique dialoge added.
// 3) Changed the names of variables for better readablity.
// 4) Put additional spacing between console messages.

// FUNCTIONAL MODIFICATION: None.

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
            Console.WriteLine("\nEnter a sentence:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string s1 = Console.ReadLine();
           
            // Split() and Reverse() methods are the real players in this proram.
            string[] words = s1.Split(' ');
            Array.Reverse(words);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSentence in reverse:\n");

            for (int i = 0; i <= words.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(words[i] + "" + ' ');            
            }

            Console.ReadKey();
        }
    }
}
