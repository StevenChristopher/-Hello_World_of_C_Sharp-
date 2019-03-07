/* SOURCE:   
 * AUTHOR:   
 * PURPOSE:  While it is true that computers don't have hands, they can still
             defeat you in a game of rock, paper, scissors!
 * FILENAME: Rock_Paper_Scissors_Game.cs
 * STUDENT:  Steven Christopher
 * DATE:     FEB 09 2019
*/

// STYLE MODIFICATIONS: None.

// FUNCTIONAL MODIFICATIONS: None.

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
            // Variable declarations. A decent amount compared to other basic
	    // programs I've coded thus far.
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
		    
                // I decided to use a switch-case here to evaluate against
		// our possible outcomes.
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
