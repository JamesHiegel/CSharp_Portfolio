// AUTHOR: James Hiegel
// FILENAME: PositiveInteger.cs
// PURPOSE: Checks if an entered integer is positive and then checks if it is divisble by 3.
// DATE: 18 May 2019

// This program prompts a user to enter an positive integer and then
// checks to ensure it is valid. It throws and handles an exception
// if the input is invalid. Lastly it checks if the integer is 
// divisible by 3.
using System;

namespace JJH
{
    public class PositiveInteger
    {
        public static void Main(string[] args)
        {
            bool opt;

            Console.WriteLine("This program asks for a postive integer and then checks " +
                "that the input is valid and then determines if it is divisible by 3.");

            do
            {
                Utility.Menu();
                opt = Utility.RunAgain();

            } while (opt);
        }
    }

    public class Utility
    {

        public static void Menu()
        {
            const int THREE = 3;

            Console.WriteLine();

            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            int number = CheckPositiveInteger(input);

            Console.Write("The number {0} is ", input);

            if (!CheckDivisionNoRemainder(number, THREE))
                Console.Write("NOT ");

            Console.WriteLine("divible by {0} with no remainder.", THREE);

        }

        public static bool RunAgain()
        {
            string input;
            bool ret = false;

            do
            {
                Console.Write("Run Again? (y/n): ");
                input = Console.ReadLine();
            } while (!(input == "y" || input == "n"));

            if (input == "y")
                ret = true;

            return ret;
        }

        public static int CheckPositiveInteger(string input)
        {
            int result = 0;

            try
            {
                result = Int32.Parse(input);

                if (result < 0)
                    throw new FormatException();
            }
            catch (FormatException e)
            {
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
