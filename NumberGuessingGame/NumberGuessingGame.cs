// SOURCE: https://www.sanfoundry.com/csharp-program-performs-number-guessing-game/
// FILENAME: NumberGuessingGame.cs
// PURPOSE: User guesses numbers and is told higher or lower until the correct number is guessed.
// STUDENT: James Hiegel
// DATE: 16 April 2019

// STYLE MODIFICATIONS:
// Added method descriptions to summarize what their purpose and output is
// Added comments to code to clarify code structure and what key sections do
// Added blank lines, descriptive variable and class names to enhance readability
// Removed "magic numbers" when possible 

// FUNCTIONAL MODIFICATIONS:
// Utilized TryParse instead of Convert to enable input validation without exception handling
// Enclosed input validation inside do-while loop
// Used nested do-while loops that require a criteria to exit instead of infinite while-do loops
// this eliminated the need to use break and continue statements
// Extracted the guess comparison and output into its own method.

using System;

namespace NumberGuessingGame
{
    // This program randomly generates a number between 1 and 100. Then prompts the user
    // to guess a number and provides feedback if the guess is higher or lower.  Once the user 
    // guesses the number the program tells the user how many guesses it took.
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int count = 0;
            int input = 0;
            int exitCode = -1;
            
            do // game loop
            {
                int NumToGuess = RandomInt(min, max);

                do // user guess loop
                {
                    do // user validation loop
                    {
                        Console.Write("Enter a number between 1 and 100 ({0} to quit):", exitCode);

                        // attempts to convert user input into integer
                        // returns a zero if input cannot convert
                        int.TryParse(Console.ReadLine(), out input);

                        // notifies user if input was invalid
                        if (input == 0)
                            Console.WriteLine("ERROR! Invalid input, only enter integers");

                    } while (input == 0); // loops until valid input is entered

                    if (input == exitCode)
                        return; // exits inner do-while loop when user inputs exit code
                    else
                    {
                        // calls a method to tell the user if a number is higher or lower
                        // does not output anything if guess is correct
                        HigherOrLower(input, NumToGuess);

                        // each guess increases the guess count 
                        count++;
                    }

                } while (input != NumToGuess); // loop exits when user inputs the correct number

                Console.WriteLine("You guessed it! The number was {0}!", NumToGuess);
                Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");

                count = 0; // resets guess counter

            } while (input != exitCode); // loop exits when user enters exit code

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
