/* SOURCE:   Self-created.             
   AUTHOR:   Steven Christopher
   FILENAME: Input_and_Output.cs
   PURPOSE:  Demonstrate various methods() of the Console class, as well as,
             utilization of the ConsoleKeyInfo constructor. Also, this program
             uses an if statement control structure at the end.
   STUDENT:  Steven Christopher
   DATE:     JAN 28 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input prompt
            Console.Write("\n\n--Please Type Your Name and Press <ENTER>:\n");
            
            // The ReadLine() method reads the next line of characters from the input stream
            string userName = Console.ReadLine();

            // ConsoleKeyInfo variable declaration. This will be used at the end of this console application
            // to determine dialogue outcome based on user input.
            ConsoleKeyInfo consoleKeyInfo;

            // The next few sections use the Console class and some of its methods() to present dialogue
            // and retrieve user input. Also, notice the use of concatenation and the new line character (\n)
            Console.WriteLine("\nWelcome, " + userName + ".");
            Console.WriteLine();
            Console.WriteLine("In your mind, I want you to think of a number between 1 and 10...");
            Console.WriteLine("...then, multiply that number by 9 to create a new number in your head...");
            Console.WriteLine();
            Console.Write("--Press <ENTER> when you have your number--");
            Console.ReadLine();

            // The WriteLine() and Write() methods allow for some options with dialogue text spacing
            Console.WriteLine();
            Console.WriteLine("\nIf your number is larger than 10, add the two digits together to get a new number...");
            Console.WriteLine();
            Console.Write("--Press <ENTER> when you have your new number--");
            Console.ReadLine();

            // The Clear() method will clear the console screen of all the dialogue text previously
            // displayed. This is a nice way to clean up the console screen a bit. Make it a little
            // less busy for the end user. 
            Console.WriteLine();
            Console.WriteLine("\nNow, subtract 5 from that new number to get, yet again, another NEW number!");
            Console.WriteLine();
            Console.Write("Got it? --Press <ENTER>--");
            Console.ReadLine();            
            Console.Clear();

            // Still MORE intriguging dialogue
            Console.WriteLine();
            Console.WriteLine("\n\nStay with me, " + userName + "...");
            Console.WriteLine();
            Console.WriteLine("\nCorrelate the number in your head to a letter in the alphabet where A = 1, B = 2 and so on...");
            Console.WriteLine();
            Console.WriteLine("Once you've determined your letter, think of the name of an ACTUAL country that begins with that letter...");
            Console.WriteLine();
            Console.Write("\n...no abbreviations or nicknames!");
            Console.WriteLine();
            Console.Write("\n--Press <ENTER> when you have your country--");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\nAlmost done! Take the last letter of that country and think of an animal that begins with that letter...");
            Console.WriteLine();
            Console.Write("\nWhen you have your animal --Press <ENTER>--");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\nTake the last letter of that animal and think of a color that begins with that letter...");
            Console.WriteLine();
            Console.WriteLine("Were you thinking of an orange kangaroo in Denmark?");
            Console.WriteLine();
            Console.WriteLine("--Select Y or N--");

            // Read in user input to the CKI variable we declared earlier. The
            // 'true' argument in the ReadKey() ensures that the user input is not visible
            // on the console screen.
            consoleKeyInfo = Console.ReadKey(true);            

            // If-Else statement to determine user input against a 'y' or 'n' keyboard response.
            if (consoleKeyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n\nHow was that for 'predictive analysis?");
                Console.WriteLine();
                Console.Write("Goodbye, " + userName + "." + " --Press any key to Exit--");
                Console.ReadKey();
            }
            else if (consoleKeyInfo.Key == ConsoleKey.N)
            {
                Console.WriteLine("Unfortunately, you failed to successfully complete basic mathematic calculations");
                Console.WriteLine();
                Console.Write("Goodbye, " + userName + "." + " --Press any key to Exit--");
                Console.ReadKey();
            }          
        }   // TODO Modify this last section of code to account for an event where the user selects somethingg
            // other than 'y' or 'n'.
    }
}
