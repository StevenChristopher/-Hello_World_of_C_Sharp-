/* SOURCE:   https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=netframework-4.7.2             
 * AUTHOR:   
 * FILENAME: Input_and_Output_v2.cs
 * PURPOSE:  Demonstrate the StringBuilder class which provides many useful methods for
             representing a mutable string of characters. StringBuilder seems to be much
             more intuitive in certain cases compared to the Console class. Nonetheless,
             both have their place.
 * STUDENT:  Steven Christopher
 * DATE:     JAN 28 2019
*/

// STYLE MODIFICATIONS: 
// 1) Used a section from previous Input_and_Output.cs program as the output to
//    be displayed.

// FUNCTIONAL MODIFICATIONS:
// 1) Prompt to exit program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_Output_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Here is a section of code from the previous program:
             * 
             * Console.WriteLine();
             * Console.WriteLine("\nIf your number is larger than 10, add the two digits together to get a new number...");
             * Console.WriteLine();
             * Console.Write("--Press <ENTER> when you have your new number--");
             * Console.ReadLine();
             * 
             * Below the StringBuilder class is used to perform the same function.
            */

            StringBuilder build = new StringBuilder();
            string firstLine = "\nIf your number is larger than 10, add the two digits together to get a new number...";

            build.AppendLine(firstLine);
            build.AppendLine();
            build.AppendLine("--Press <ENTER> when you have your new number--");

            Console.WriteLine(build.ToString());
            Console.ReadLine();
        }
    }
}
