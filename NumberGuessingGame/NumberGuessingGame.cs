// SOURCE: https://www.sanfoundry.com/csharp-program-performs-number-guessing-game/
// FILENAME: NumberGuessingGame.cs
// PURPOSE: The program randomly generates a number between 1 and 100. Then prompts the user
// to guess a number and provides feedback if the guess is higher or lower.  Once the user 
// guesses the number the program tells the user how many guesses it took.
// STUDENT: James Hiegel
// DATE: 16 April 2019

// STYLE MODIFICATIONS: none

// FUNCTIONAL MODIFICATIONS: none

using System;

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
            
            do
            {
                int NumToGuess = RandomInt(min, max);

                do
                {
                    do
                    {
                        Console.Write("Enter a number between 1 and 100 (-1 to quit):");
                        // attempts to convert user input into integer
                        // returns a zero if input cannot convert
                        int.TryParse(Console.ReadLine(), out input);

                        // notifies user if input was invalid
                        if (input == 0)
                            Console.WriteLine("ERROR! Invalid input, only enter integers");

                    } while (input == 0); // loops until valid input is entered

                    if (input == -1)
                        return; // exits inner do-while loop when user inputs -1
                    else
                    {
                        // calls a method to tell the user if a number is higher or lower
                        // does not output anything if guess is correct
                        HigherOrLower(input, NumToGuess);
                        // each guess increases the guess count 
                        count++;
                    }

                } while (input != NumToGuess); // loops until the user inputs the correct number

                Console.WriteLine("You guessed it! The number was {0}!", NumToGuess);
                Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");

                count = 0; // resets guess counter

            } while (input != -1); // loops until user inputs -1

        } // end Main()

        // This method returns a randomly generated integer between two provided integers, inclusive.
        private static int RandomInt(int min, int max)
        {
            Random r = new Random();
            return (r.Next(min, max));
        } // end RandomInt()

        // This method compares two provided integers and outputs text stating 
        // if the second number is higher or lower than the first.
        private static void HigherOrLower(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                Console.WriteLine("High, try again.");
            else if (firstNum < secondNum)
                Console.WriteLine("Low, try again.");
        } // end HigherOrLower()

    } // end class NumberGuessingGame

}
