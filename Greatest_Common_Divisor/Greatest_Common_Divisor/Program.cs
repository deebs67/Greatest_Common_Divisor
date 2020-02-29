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
            Console.WriteLine("Euclid's algorithm for calculating the Greatest Common Divisor (GCD) of two integers");
            Console.WriteLine("====================================================================================");

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

            // Call GCD function, using Euclid's algorithm as described in the associated README.md:
            Console.WriteLine("We will now execute the recursive steps of Euclid's GCD algorithm...");
            long gcd = Euclid_GCD(first_integer, second_integer);
            Console.WriteLine($"\nThe Greatest Common Divisor of {first_integer} and {second_integer} is {gcd}");

            // Exit
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static long Euclid_GCD(long a, long b)
        // Returns the GCD of a and b, using Euclid's GCD algorithm. This relies upon the observation that the
        // GCD of (a,b) is equal to the GCD of (their difference, the smaller one). So note the recursive structure here,
        // upon which this algorithm relies. Note that if the two numbers 'a' and 'b' are large, and very different,
        // then it could lead to too many steps of recursion, and so it might 'smash the stack' during the programme run,
        // and lead to a stack exception. If you have this problem, then you probably need to investigate more
        // efficient GCD algorithms, which do exist.
        {
            // Define variables
            long larger;
            long smaller;

            // Information for the user
            Console.WriteLine($"a = {a}, b = {b}");

            // If a and b are equal, then they are both the GCD of each other, so we can return, having found the answer
            if (a == b)
            {
                Console.WriteLine($"a and b are now equal, with a value of {a}");
                return a;  // Could equally have been 'return b;', of course!
            }

            // Re-arrange a and b to be the larger and smaller, so that we can conveniently calculate the difference
            if (a >= b)
            {
                larger = a;
                smaller = b;
            }

            else
            {
                larger = b;
                smaller = a;
            }

            long difference = larger - smaller;

            // Now we do the recursive function call (i.e. call another instance of this same function) with
            // the reduced parameters.
            return Euclid_GCD(difference, smaller);
        }
    }
}
