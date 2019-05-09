// SOURCE:  https://www.dotnetperls.com/reverse-words
// AUTHOR: Sam Allen
// FILENAME: ReverseWords.cs
// PURPOSE: Demonstrates how to reverses the order of strings without reversing the strings.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

/*
 * Summary: This program reverses the order of strings without
 * reversing the strings.
 */
using System;

namespace JJH
{
    public class ReverseWords
    {
        // Driver method
        public static void Main()
        {
            string s1 = "Bill Gates is the richest man on Earth";
            string s2 = "Srinivasa Ramanujan was a brilliant mathematician";

            Console.WriteLine("Original String:");
            Console.WriteLine(s1);

            string rev1 = WordTools.ReverseWords(s1);
            Console.WriteLine("\nReversed Words: {0}", rev1);

            Console.WriteLine("Original String:");
            Console.WriteLine(s2);

            string rev2 = WordTools.ReverseWords(s2);
            Console.WriteLine("Reversed Words: {0}", rev2);
        }
    }

    // The WordTools class has a single method to reverse words in a string
    internal static class WordTools
    {
        // The ReverseWords method reverse the order of words in a string,
        // without reversing the letters of the words
        internal static string ReverseWords(string sentence)
        {
            // creates an array of words by splitting a string at spaces
            string[] words = sentence.Split(' ');

            // reverses the array of words using a built in method
            Array.Reverse(words);

            // returns a string of words connected by a space
            return string.Join(" ", words);
        }
    }
}
