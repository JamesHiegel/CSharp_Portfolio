// SOURCE: https://www.sanfoundry.com/c-program-days-in-years-weeks-days/
// AUTHOR: Manish Bhojasia
// FILENAME: DaysToWeeks.cs
// PURPOSE: C# Program to Convert a Given Number of Days in terms of Years, Weeks & Days.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added extra Console.WriteLine telling user what the program does

/*
 * C# Program to Convert a Given Number of Days in terms of Years, Weeks & Days
 */
using System;

namespace JJH
{
    class DaysToWeeks
    {
        public static void Main()
        {
            const int DAYSINWEEK = 7;
            int numDays, years, weeks, days;

            Console.WriteLine("This program calculates the number of years, weeks and leftover days");

            // collects user specified number of days
            Console.WriteLine("Enter the number of days");
            numDays = int.Parse(Console.ReadLine());

            // calculates number of years, weeks and leftover days
            years = numDays / 365;
            weeks = (numDays % 365) / DAYSINWEEK;
            days = (numDays % 365) % DAYSINWEEK;

            // displays result to user
            Console.WriteLine("{0} is equivalent to {1}years, {2}weeks and {3}days",
                               numDays, years, weeks, days);
            Console.ReadLine();
        }
    }
}