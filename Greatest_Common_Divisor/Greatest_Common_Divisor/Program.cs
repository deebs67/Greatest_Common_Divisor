using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry
            Console.Title = "Greatest Common Divisor";

            //////////////////////////////////////////////////////////////////
            // Main code
            //////////////////////////////////////////////////////////////////

            // Get first number
            Console.WriteLine("Enter first integer:");
            long first_integer = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"The first integer you chose was: {first_integer}\n");

            // Get second number
            Console.WriteLine("Enter second integer:");
            long second_integer = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"The second integer you chose was: {second_integer}\n");

            // TODO:
            // Write recursive function to carry out a step of the algorithm, as described here:
            // https://en.wikipedia.org/wiki/Euclidean_algorithm

            // Exit
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
