// SOURCE: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-7.php
// AUTHOR: w3 resource
// FILENAME: PrimeNumber.cs
// PURPOSE: Check a number is prime number or not.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added additional example


/*
 *  C# program to check whether a number is prime or not using recursion.
 */
using System;

namespace JJH
{
    public class PrimeNumber
    {
        // The main method passes an integer to the isPrimeNumber method and uses the boolean result to display a message
        static void Main(string[] args)
        {
            int number = 89;
            Console.WriteLine(isPrimeNumber(number) ? number + " is prime number" : number + " is not prime number");

            int number2 = 7;
            Console.WriteLine(isPrimeNumber(number2) ? number2 + " is prime number" : number2 + " is not prime number");

            int number3 = 20;
            Console.WriteLine(isPrimeNumber(number3) ? number3 + " is prime number" : number3 + " is not prime number");
        }

        // The isPrimeNumber method uses the countDivisibles helper method to determine if a number is prime
        static bool isPrimeNumber(int number)
        {
            if (countDivisibles(1, number) == 0)
                return true;
            else
                return false;
        }

        // The countDivisibles is a helper method that uses recursion to count the number of divisibles
        public static int countDivisibles(int first, int last)
        {

            if (first == last - 1)
                return 0;
            if (last == 0)
                return 1;

            int result = 0;

            if (last % (first + 1) == 0)
                result = 1;

            return result + countDivisibles(first + 1, last);
        }
    }
}