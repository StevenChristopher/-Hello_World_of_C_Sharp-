/* SOURCE:   https://www.sanfoundry.com/csharp-program-universal-time/            
 * AUTHOR:   
 * FILENAME: Retrieve_Universal_Time_Example
 * PURPOSE:  
 * STUDENT:  Steven Christopher
 * DATE:     MAR 02 2019
*/

// STYLE MODIFICATIONS:


// FUNCTIONAL MODIFICATIONS:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_Universal_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Universal Time Zone Retrieval
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime univ = zone.ToUniversalTime(DateTime.Now);
            Console.WriteLine("Universal Time is {0}", univ);
            Console.Read();
        }
    }
}
