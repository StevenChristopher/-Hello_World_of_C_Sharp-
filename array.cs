/* SOURCE:   https://www.c-sharpcorner.com/UploadFile/c63ec5/reverse-string-in-C-Sharp/             
   AUTHOR:   Sharad Gupta
   FILENAME: Reverse_Word_Order_v2.cs
   PURPOSE:  Demonstrate an alternate way of reversing a sentence that
             is entered by a user. In the previous Reverse_Word_Order.cs
             program, Array.Reverse() method was used. In this version,
             loop control variables and a for loop are used.
   STUDENT:  Steven Christopher
   DATE:     JAN 31 2019
*/

// STYLE MODIFICATIONS:
// o Unique console display dialogue

// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Word_Order_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.WriteLine("\nEnter a sentence:\n");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            int k = words.Length - 1;
            temp = k;

            for (int i = k; temp >= 0; k--)
            {
                Console.WriteLine("\nSentence Reversed:\n");
                Console.Write(words[temp] + "" + ' ');
                --temp;
            }

            Console.ReadKey();
        }
    }
}