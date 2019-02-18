using System;

namespace Hello_While_Loop
{
    class Program
    {
        // Initialization of the required Main() method for the program
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nHello, C# World!");
            Console.Write("\n--Press <ENTER> to exit...");

            // This while ensures the user has to press ENTER to exit the program
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

        }
    }
}
