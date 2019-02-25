using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGuesses = 0;

            Console.Write("\n\n<< Welcome to HANGMAN >>\n");
            Console.WriteLine("***HINT: This hangman game uses words themed on 'SpongeBob SquarePants'***\n");

            // Create a string type array with 20 distinct words
            string[] wordlist = new string[20];
            wordlist[0] = "starfish";
            wordlist[1] = "bikini";
            wordlist[2] = "krabbypatty";
            wordlist[3] = "snail";
            wordlist[4] = "patrick";
            wordlist[5] = "lifeguard";
            wordlist[6] = "krusty";
            wordlist[7] = "pineapple";
            wordlist[8] = "ocean";
            wordlist[9] = "jellyfish";
            wordlist[10] = "sandy";
            wordlist[11] = "barnicle";
            wordlist[12] = "nautical";
            wordlist[13] = "squidward";
            wordlist[14] = "clarinet";
            wordlist[15] = "squirrel";
            wordlist[16] = "spatula";
            wordlist[17] = "dutchman";
            wordlist[18] = "tartarsauce";
            wordlist[19] = "treasure";

            // Randomly select an index from the above list and 
            // assign it to a string variable called mysteryWord
            Random randGen = new Random();
            var index = randGen.Next(0, 19);
            string mysteryWord = wordlist[index];

            // Create a new character array with the same length 
            // as the randomly generated word
            char[] guess = new char[mysteryWord.Length];

            //  Increment through guess[] array to determine array
            //  length and place an asterisk in each index of the random word
            for (int ii = 0; ii < mysteryWord.Length; ii++)
                guess[ii] = '*';

            Console.WriteLine("\nGUIDELINES:\n");
            Console.Write("1) Asterisks display the length of the word after you guess your first letter\n");
            Console.Write("2) If you guess a correct letter, it replaces the corresponding asterisk\n");
            Console.Write("3) Continue until you have replaced all asterisks with a complete word!\n");
            Console.Write("4) You get 10 guesses. No more. Choose wisely and good luck...\n");
            Console.Write("\nSelect a Letter: ");            

            
            while (true)
            {
                // Parse user input to a char
                char playerGuess = char.Parse(Console.ReadLine());
                
                // This for loop will step through each index for our mysteryword
                // and replace asterisks with a matching user guess char
                for (int jj = 0; jj < mysteryWord.Length; jj++)
                {
                    if (playerGuess == mysteryWord[jj])

                        guess[jj] = playerGuess;
                }
                totalGuesses++;
                
                // Write the new version of mysteryWord and determine a win or a loss
                // TODO Periodically clear the screen so display isn't too busy
                Console.WriteLine(guess);

                if (guess.Contains('*') && totalGuesses < 10)
                    {
                        Console.WriteLine("Keep trying...");
                    }
                    else if (!guess.Contains('*'))
                    {
                        Console.WriteLine("You did it!!! I guess you'll live to see another day...");
                        Console.Write("\n<<Press Any Key to Exit>>");
                        Console.ReadLine();
                    }
                else if (totalGuesses == 10)
                {
                    Console.Write("You feel the noose tighten around your neck..." +
                                  "...the platform drops and it all goes black...\n\n");
                    Console.Write("\n<<Press Any Key to Exit>>");
                    Console.ReadLine();
                }
                
            } 
        }
    }
}