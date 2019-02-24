/* SOURCE:   https://www.geeksforgeeks.org/count-occurences-of-a-word-in-string            
   AUTHOR:   ChitraNayal
   FILENAME: Specific_Word_Count.cs
   STUDENT:  Steven Christopher
   DATE:     FEB 18 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

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
            string[] a = str.Split(' ');

            // search for pattern in string 
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                // if match found increase count 
                if (word.Equals(a[i]))
                    count++;
            }
            return count;
        }

            // Driver code 
            public static void Main()
            {
                string str = "GeeksforGeeks A computer science portal for geeks made by geeks ";
                string word = "geeks";
                Console.WriteLine("\nNumber of Occurences: " + countOccurences(str, word));
                Console.Write("\nPress Any Key to Exit");
                Console.ReadLine();
                
            }       

        // This code is contributed 
        // by ChitraNayal 
    }
}
