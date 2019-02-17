/* SOURCE:   Brian Kernighan is given credit for being the first to use the "Hello, World" program template
             as part of the documentation for the BCPL programming language. It is now a standard for introducing
             novice programmers, like myself, to a new programming language.             
   AUTHOR:   The collective universe of programmers as we know it.
   FILENAME: Hello_World_v1.cs
   PURPOSE:  Demonstrate the most basic architecture for a C# program.
   STUDENT:  Steven Christopher
   DATE:     JAN 25 2019
*/

// STYLE MODIFICATIONS: None.
// FUNCTIONAL MODIFICATIONS: None.

// This line of code simply opens access to libraries and such.
// It is automatically generated when you begin development of a new
// application/program in MS Visual Studio.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace container.
namespace Hello_World_v1
{
    // The program container.
    class Program
    {
        // The Main() method container. Every C# program requires a Main() method.
        // It is the point of entry.
        static void Main(string[] args)
        {
            // Basic instructions for displaying output and reading input from the console.
            Console.WriteLine("\nHello, World of C-Sharp!");
            Console.WriteLine("\nPress <ENTER> to continue...");
            Console.ReadLine();
        }
    }
}
