// SOURCE: https://www.wikihow.com/Sum-the-Integers-from-1-to-N
// AUTHOR: James Hiegel
// FILENAME: SumOfIntegers.cs
// PURPOSE: Calculate the sum of integers.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Condensed into single file
// Extracted sum algorithm into its own method
// Added do-while loop

/* 
 * A C# program that calculates the sum of integers
 */
using System;

namespace JJH
{
    public class SumOfIntegers
    {
        public static void Main(string[] args)
        {
            int input = 0;

            // loops until -1 is entered at prompt
            do
            {
                // asks user for integer to sum
                Console.Write("Enter an integer to find sum of (or -1 to quit): ");
                int.TryParse(Console.ReadLine(), out input);

                // does not process if exit token present
                if (input != -1)
                    Console.WriteLine("The sum of integers is {0}\n", SumIntegers(input));

            } while (input != -1);
        }

        // The SumIntegers method calculates the sum of 1+2+3+...n
        internal static int SumIntegers(int input)
        {
            return ((input + 1) * input) / 2;
        }
    }
}