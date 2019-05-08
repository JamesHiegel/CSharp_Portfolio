// SOURCE: https://www.geeksforgeeks.org/csharp-program-to-find-whether-a-no-is-power-of-two/
// AUTHOR: Sam007
// FILENAME: PowerOfTwo.cs
// PURPOSE: Check if a number is a power of two.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read
// Added reference to detailed explaination of logical bitwise AND operator

// FUNCTIONAL MODIFICATIONS:
// Added namespace
// Added additional Console.WriteLines to main method to explain what the program is doing

/*
 * C# Program to check is a number is a power of two
 */
using System;

namespace JJH
{
    public class PowerOfTwo
    {
        // Driver method 
        public static void Main()
        {
            int num1 = 31;
            int num2 = 64;

            Console.Write("Is {0} a power of two? ", num1);
            Console.WriteLine(IsPowerOfTwo(num1) ? "Yes" : "No");

            Console.Write("Is {0} a power of two? ", num2);
            Console.WriteLine(IsPowerOfTwo(num2) ? "Yes" : "No");
        }

        // Method to check if x is power of 2 
        internal static bool IsPowerOfTwo(int input)
        {
            // uses logical bitwise AND to determine if number is a power of two
            // excludes base case of 0
            // detailed explanation at https://stackoverflow.com/questions/600293/how-to-check-if-a-number-is-a-power-of-2
            return input != 0 && ((input & (input - 1)) == 0);
        }
    }
}