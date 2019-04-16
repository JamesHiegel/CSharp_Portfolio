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

            int NumToGuess = RandomInt(min, max);

            do
            {

            } while (false);
        }

        // This method generates a random integer between two provided integers, inclusive
        private static int RandomInt(int min, int max)
        {
            Random r = new Random();
            return (r.Next(min, max));
        }

        // This method compares two provided integers and returns an integer if the first is higher, lower or the same as the second
        private static int HigherOrLower(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                return 1;
            else if (firstNum < secondNum)
                return -1;
            else
                return 0;
        }
    }
}
