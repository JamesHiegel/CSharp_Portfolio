// SOURCE: https://www.sanfoundry.com/csharp-program-convert-decimal-binary/
// AUTHOR: Manish Bhojasia
// FILENAME: DecimalToBinary.cs
// PURPOSE: C# Program to Convert a Given Number of Days in terms of Years, Weeks & Days.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added extra Console.WriteLine telling user what the program does

/*
 * C# Program to Convert Decimal to Binary
 */
using System;

namespace JJH
{
    public class DecimalToBinary
    {
        public static void Main()
        {
            int num;
            int quot;
            string rem = "";

            Console.WriteLine("This program converts an integer to a binary number.");
            // collects user input
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            // divides number by two and then saves remainder
            // repeats process until number is less than 1
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }

            // reverses order of rem string to form binary number
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }

            // displays binary number
            Console.WriteLine("The Binary format for given number is {0}", bin);
            Console.Read();
        }
    }
}