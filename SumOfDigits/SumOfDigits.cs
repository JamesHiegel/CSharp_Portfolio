// SOURCE: Hands-On Object-Oriented Programming with C#
// AUTHOR: Raihan Taher
// FILENAME: SumOfDigits.cs
// PURPOSE: Adding the digits of a number.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to clarify what is occuring at each code block
// Used blank lines to make code more readable.

// FUNCTIONAL MODIFICATIONS:
// Replaced infinite while-loop with do-while loop that exits when user enters anything other than a "y"

using System;

namespace JJH
{
    class SumOfDigits
    {
        static void Main(string[] args)
        // The entry point of the program.
        {
            do
            // The following code block will execute as long as the if statement at the end is true.
            {
                long sum = 0;

                // Instructs the user to input numbers for the program to calculate.
                Console.Write("Enter a Number : ");

                // Converts the user's input from a string to a long variable type.
                long num = long.Parse(Console.ReadLine());

                // Loops for every digit in the user provided number
                // uses division by 10 to strip each digit off and add it to the sum variable
                while (num != 0)
                {
                    long r = num % 10;
                    num = num / 10;
                    sum = sum + r;
                }

                // displays result of the calculation and asks if user wants to enter another number
                Console.WriteLine("Sum of Digits of the Number : " + sum);
                Console.WriteLine("Try again?  (Y/N) ");

                // Will break loop if the user enters anything other than "y".
            } while (!(Console.ReadLine().ToLower() != "y"));
        }
    }
}