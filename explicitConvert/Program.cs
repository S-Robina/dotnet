using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitConvert
{
    internal class Program
    {
        static void Main(string[] args) {

            /*implicit conversion:
             happens automatically if no data will be lost in the conversion.
            That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more).
            explicit conversion: requires a cast operator to convert a data type into another one.
            So if we do want to convert a double to an int, we could use the operator (int).*/

            int myInt = 3;
            // Turn it into a double
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            /* it is not possible to explicitly convert a string into an int (or vice versa) in C#.
             Convert.ToInt32(). This method takes a string and outputs an integer.
             */

            // Ask user for fave number
            Console.WriteLine("Enter your favorite number!: ");
      
      // Turn that answer into an int
      int faveNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(faveNumber);
        
        }
    }
}
