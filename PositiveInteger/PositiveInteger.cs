// AUTHOR: James Hiegel
// FILENAME: PositiveInteger.cs
// PURPOSE: Checks if an entered integer is positive and then checks if it is divisble by 3.
// DATE: 18 May 2019

using System;

namespace JJH
{
    // This program prompts a user to enter an positive integer and then
    // checks to ensure it is valid. It throws and handles an exception
    // if the input is invalid. Lastly it checks if the integer is 
    // divisible by 3.
    public class PositiveInteger
    {
        // driver method
        public static void Main(string[] args)
        {
            bool opt;

            Console.WriteLine("This program asks for a postive integer and then checks " +
                "that the input is valid and then determines if it is divisible by 3.");

            // loops until user asks to exit program
            do
            {
                // displays menu and handles user input
                Utility.Menu();
                // asks user if they want to exit
                opt = Utility.RunAgain();

            } while (opt);
        }
    }

    // The Utility class contains methods that displays a menu, checks user 
    // input, checks division, and asks a user if they want to quit
    public class Utility
    {
        // The Menu method displays instructions and prompts the user for input
        public static void Menu()
        {
            const int THREE = 3;

            Console.WriteLine();

            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            // calls the CheckPositiveInteger method to verify and convert
            // the user input
            int number = CheckPositiveInteger(input);

            Console.Write("The number {0} is ", input);

            // uses the CheckDivisionNoRemainder to customize the displayed message
            if (!CheckDivisionNoRemainder(number, THREE))
                Console.Write("NOT ");

            Console.WriteLine("divible by {0} with no remainder.", THREE);
        }

        // The RunAgain method asks a user if they want to
        // run the program again and returns a bool
        public static bool RunAgain()
        {
            string input;
            // default is to not run program again
            bool ret = false;

            // loops until user input is valid
            do
            {
                Console.Write("Run Again? (y/n): ");
                input = Console.ReadLine();
            } while (!(input == "y" || input == "n"));

            // changes return to true if user says yes
            if (input == "y")
                ret = true;

            return ret;
        }

        // The CheckPositiveInteger method attempts to convert a string
        // into an integer and handles the exception thrown if it does not
        // convert. The method also checks to see if the integer is positive
        public static int CheckPositiveInteger(string input)
        {
            int result = 0;

            // the try-catch block handles any FormatExceptions that occur
            try
            {
                // tries to convert string to int
                result = Int32.Parse(input);

                // throws exception if not positive integer
                if (result < 0)
                    throw new FormatException();
            }
            catch (FormatException e)
            {
                // displays error message when an exception is caught
                // message is different for each subtype of FormatException
                Console.WriteLine("\nEXCEPTION CAUGHT!");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            return result;
        }

        // The CheckDivisionNoRemainder method returns true if the provided numerator 
        // can be divided by the denominator with no remainder, otherwise the method 
        // returns false. The method throws an exception if denominator is zero.
        public static bool CheckDivisionNoRemainder(int numerator, int denominator)
        {
            // checks to ensure denominator is not zero
            // if it is then throws a DivideByZeroException
            if (denominator == 0)
                throw new DivideByZeroException();

            bool result = false;

            // checks if division results in no remainder
            if (numerator % denominator == 0)
                result = true;

            return result;
        }
    }
}
