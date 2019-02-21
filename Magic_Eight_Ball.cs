
/* SOURCE:   https://social.msdn.microsoft.com/Forums/en-US/7e20a14b-98d9-4737-a588-18971098d13b/
             magic-8-ball-random-string-generator?forum=csharpgeneral             
   AUTHOR:   Christopher84
   FILENAME: Magic_Eight_Ball.cs
   STUDENT:  Steven Christopher
   DATE:     FEB 21 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Eight_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWelcome to Fortune Teller Bot");            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWARNING: Only ask questions you want to know!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a question about your future fortune or despair:");
            Console.ReadLine();
            
            Random range = new Random();
            string[] wordList = new string[] { "Most Definitely", "Nope", "It Seems Likely", "I Doubt It", "Yes", "No", "Ask Me Again", "Absolutely", "I Think Not" };
            int index = range.Next(wordList.Length);
            string randomString = wordList[index];

            Console.Write("\nThe All-Knowing Console replies: " + randomString);
            Console.ReadLine();
        }
    }
}
