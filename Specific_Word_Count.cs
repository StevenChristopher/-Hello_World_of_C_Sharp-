/* SOURCE:   https://www.geeksforgeeks.org/count-occurences-of-a-word-in-string            
 * AUTHOR:   ChitraNayal
 * FILENAME: Specific_Word_Count.cs
 * PURPOSE:  Program that evaluates a sentence that is typed in by the user
             against a specific word. The occurences of that word are counted
			 and then displayed in the console.
 * STUDENT:  Steven Christopher
 * DATE:     FEB 03 2019
*/

// STYLE MODIFICATIONS:
// 1) Changed variable names to be more intuitive throughout program.
// 2) Unique console display dialogue.
// 3) Unique console prompts.

// FUNCTIONAL MODIFICATIONS:
// 1) Modified the sentence that is evaluated.
// 2) Modified search word.
// 3) Added an program exit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific_Word_Count
{
    class Program
    {
        static int countOccurences(string str, string word)
        {
            // split the string by spaces 
            string[] sentence = str.Split(' ');

            // search for pattern in string 
            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                // if match found increment counter 
                if (word.Equals(sentence[i]))
                    count++;
            }
            return count;
        }

            // Main() method
            public static void Main()
            {
                // Notice that I started the sentence in lower case. If I hadn't, the first
                // 'the' would not be counted.
                // TODO find a way to modify above issue
                string str = "the swift brown fox jumped over the fence to get the rabbit";
                string word = "the";
                Console.WriteLine("\nNumber of Occurences: " + countOccurences(str, word));
                Console.Write("\nPress Any Key to Exit");
                Console.ReadLine();                
            }        
    }
}
