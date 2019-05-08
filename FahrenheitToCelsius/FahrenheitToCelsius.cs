// SOURCE: https://www.sanfoundry.com/csharp-program-fahrenheit-celsius/
// AUTHOR: Manish Bhojasia
// FILENAME: FahrenheitToCelsius.cs
// PURPOSE: C# Program to Convert Fahrenheit to Celsius.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added extra Console.WriteLine telling user what the program does
// Exctracted coversion to it's own method
// Used number formats on the celsius display

/*
 *  C# Program to Convert Fahrenheit to Celsius 
 */
using System;

namespace JJH
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts from Fahrenheit to Celsius.");

            // asks user to enter Fahrenheit
            Console.Write("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // displays celsius
            Console.WriteLine("The converted Celsius temperature is {0:N2}", FtoC(fahrenheit));
            Console.ReadLine();
        }

        // The FtoC method converts fahrenheit to celsius
        private static double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}