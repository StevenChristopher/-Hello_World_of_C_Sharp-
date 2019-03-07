/* SOURCE:   https://www.sanfoundry.com/csharp-program-performs-number-guessing-game/             
 * AUTHOR:   
 * FILENAME: Number_Guessing_Game.cs
 * PURPOSE:  The computer generates a random number between 1 and 100. The user has unlimited
             attempts. The total amount of guesses it took to get the correct number is displayed.
 * STUDENT:  Steven Christopher
 * DATE:     MAR 05 2019
*/

// STYLE MODIFICATIONS:
// 1) Unique console display prompts and messaging. 

// FUNCTIONAL MODIFICATIONS:
// 1) Unique number range.
// 2) Removed user guess limits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("Low, try again.");
                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("High, try again.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!",
                                           randno);
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
