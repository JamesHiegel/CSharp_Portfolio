// SOURCE: https://www.sanfoundry.com/csharp-program-performs-number-guessing-game/
// FILENAME: NumberGuessingGame.cs
// PURPOSE: User guesses numbers and is told higher or lower until the correct number is guessed.
// STUDENT: James Hiegel
// DATE: 16 April 2019

// STYLE MODIFICATIONS: none

// FUNCTIONAL MODIFICATIONS: none

using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int count = 0;
            int input = 0;
            
            int NumToGuess = RandomInt(min, max);

            do
            {
                do
                {
                    Console.Write("Enter a number between 1 and 100 (0 to quit):");
                    int.TryParse(Console.ReadLine(), out input);

                    if (input == 0)
                        return;
                    else
                    {
                        HigherOrLower(input, NumToGuess);
                        count++;
                    }

                } while (input != NumToGuess);

                Console.WriteLine("You guessed it! The number was {0}!", NumToGuess);
                Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");

            } while (input != 0);
        }

        // This method generates a random integer between two provided integers, inclusive
        private static int RandomInt(int min, int max)
        {
            Random r = new Random();
            return (r.Next(min, max));
        }

        // This method compares two provided integers and returns an integer if the first is higher or lower
        private static void HigherOrLower(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                Console.WriteLine("High, try again.");
            else if (firstNum < secondNum)
                Console.WriteLine("Low, try again.");
        }
    }
}
