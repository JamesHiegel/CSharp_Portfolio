// SOURCE: https://www.geeksforgeeks.org/c-sharp-string-vs-stringbuilder/
// AUTHOR: Anshul Aggarwal
// FILENAME: StringBuilderDemo.cs
// PURPOSE: Demonstrates how to use the StringBuilder class.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Reduce program into Main method
// Added additional WriteLine to show what program is doing

// 
using System;
using System.Text;

namespace JJH
{
    class StringBuilderDemo
    {
        // Main Method uses the StringBuilder class to merge two strings
        public static void Main(String[] args)
        {
            String s1 = "Geeks";
            String st = "forGeeks";

            Console.WriteLine("Two seperate strings:\n{0}\n{1}\n", s1, st);

            // Creates a StringBuilder object and appends two strings to it
            StringBuilder s2 = new StringBuilder();
            s2.Append(s1);
            s2.Append(st);

            Console.WriteLine("Combined into new string StringBuilder Class: " + s2);
        }
    }
}
