// SOURCE: https://www.sanfoundry.com/csharp-program-indexoutofrange-exception/
// AUTHOR: Manish Bhojasia
// FILENAME: SingleException.cs
// PURPOSE: Handle single exception.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

/*
 * C# Program to Demonstrate IndexOutOfRange Exception
 */

using System;

namespace JJH
{
    public class SingleException
    {
        // driver method
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will throw and handle an exception.\n");
            ArrayOutOfIndex.calculatedifference();
            Console.ReadLine();
        }
    }

    // helper class containing a method that causes and handles an exception
    public class ArrayOutOfIndex
    {
        // method that causes and handles an exception when run
        public static void calculatedifference()
        {
            int difference = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };

            // try-catch block that will handle a IndexOutOfRangeException
            try
            {
                // this is the statement that throws the exception
                for (int init = 1; init <= 5; init++)
                {
                    difference -= number[init];
                }
                Console.WriteLine("The difference of the array is:" + difference);
            }
            // catches the exception and displays an error message
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception Caught!");
                Console.WriteLine(e.Message);
            }
        }
    }

}