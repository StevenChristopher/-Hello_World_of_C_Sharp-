/* SOURCE:   https://www.geeksforgeeks.org/count-occurences-of-a-word-in-string            
   AUTHOR:   ChitraNayal
   FILENAME: Specific_Word_Count.cs
   PURPOSE:  Program that evaluates a sentence that is typed in by the user
             against a specific word. The occurences of that word are counted
			 and then displayed in the console.
   STUDENT:  Steven Christopher
   DATE:     FEB 03 2019
*/

// STYLE MODIFICATIONS:
// o Changed variable names to be more intuitive throughout program.
// o Unique console display dialogue.
// o Unique console propts.

// FUNCTIONAL MODIFICATIONS:
// o Modified the sentence that is evaluated.
// o Modified search word.
// o Added an program ending prompt.
// o Discovered a future TODO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Program2
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                Console.WriteLine("Let's play ROCK, PAPER, SCISSORS! Type your choice:");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("The computer chose ROCK.");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("DRAW!\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("PLAYER WINS!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS!\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("The computer chose PAPER.");
                        if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("DRAW!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("CPU Wins!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("PLAYER WINS!\n\n");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("The computer chose SCISSORS.");
                        if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("DRAW!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("PLAYER WINS!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("CPU Wins!\n\n");
                            scoreCPU++;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Entry!");
                        break;
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("You've won three times and are the Champion!");
                    Console.WriteLine("Press Any Key to Exit...");
                    Console.ReadLine();
                    return;
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("The CPU won three times and is the Champion!");
                    Console.WriteLine("Press Any Key to Exit...");
                    Console.ReadLine();
                    return;
                }


            }
        }
    }
}
