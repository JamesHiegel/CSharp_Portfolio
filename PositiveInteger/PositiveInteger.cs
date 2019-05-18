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
            Console.WriteLine("Hello World!");
        }
    }

    public class Utility
    {
        // The CheckDivisionNoRemainder method returns true if the provided numerator 
        // can be divided by the denominator with no remainder, otherwise the method 
        // returns false. The method throws an exception if denominator is zero.
        public static bool CheckDivisionNoRemainder(int numerator, int denominator)
        {
            // checks to ensure denominator is not zero
            // if it is then throws a DivideByZeroException
            if (denominator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            bool result = false;

            // checks if division results in no remainder
            if (numerator % denominator == 0)
                result = true;

            return result;
        }
    }
}
