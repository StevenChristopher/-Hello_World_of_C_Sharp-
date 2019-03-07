/* SOURCE:   https://social.msdn.microsoft.com/Forums/en-US/7e20a14b-98d9-4737-a588-18971098d13b/
             magic-8-ball-random-string-generator?forum=csharpgeneral             
 * AUTHOR:   Christopher84
 * FILENAME: Magic_Eight_Ball.cs
 * PURPOSE:  This game emulates an old magic 8-ball toy. A string word list is used to randomly
             select an answer to questions posed by the user.
 * STUDENT:  Steven Christopher
 * DATE:     MAR 05 2019
*/

// STYLE MODIFICATIONS:
// 1) Unique console display prompts and messaging.
// 2) Text colors added.

// FUNCTIONAL MODIFICATIONS:
// 1) Incorporated different, less vulgar responses.

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
            // This may be a more appropriate or apt name for this little whimsy of a game.
            Console.WriteLine("\nWelcome to Fortune Teller Bot");
          
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWARNING: Only ask questions you want to know!\n");
          
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a question you wish to know regarding your uncertain future:");
            Console.ReadLine();
            
            Random range = new Random();
            string[] wordList = new string[] { "Most Definitely", "Nope", "It Seems Likely", "I Doubt It", 
                                               "Yes", "No", "Ask Me Again", "Absolutely", "I Think Not" };
            int index = range.Next(wordList.Length);
            string randomString = wordList[index];

            Console.Write("\nThe All-Knowing Console replies: " + randomString);
            Console.ReadLine();
        }
    }
}
