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
        }

        // This method generates a random integer between two provided integers, inclusive
        private static int RandomInt(int min, int max)
        {
            Random r = new Random();
            return (r.Next(min, max));
        }
    }
}
