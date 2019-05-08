// SOURCE: https://www.sanfoundry.com/csharp-program-check-given-number-even-odd/
// AUTHOR: Manish Bhojasia
// FILENAME: OddOrEven.cs
// PURPOSE: This program determines if the user's input is odd or even.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

using System;

namespace JJH
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");

            // loops until user enters valid number
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Invalid input, please enter a number : ");
            }
            
            // uses the modulus operator to determine if a number is odd or even
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }

            Console.Read();
        }
    }
}
