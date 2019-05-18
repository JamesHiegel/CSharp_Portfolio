// AUTHOR: James Hiegel
// FILENAME: CountVowelsInStringLINQ.cs
// PURPOSE: Count the number of vowels in a string, both uppercase and lowercase.
// DATE: 18 May 2019

using System;
using System.Collections.Generic;
using System.Linq;

namespace JJH
{
    // This program prompts a user to enter a sentence and then counts the 
    // uppercase and lowercase vowels in the sentence. The program then 
    // outputs the number of vowels
    public class CountVowelsInStringLINQ
    {
        // driver method
        public static void Main(string[] args)
        {
            Utility.Menu();
        }
    }

    // The Utility class contains a method to display the menu
    // and a method to count the number of vowels in a string
    public class Utility
    {
        // The Menu method displays a menu for the user and then
        // prompts the user to enter a string. The method then
        // calls the CountVowels method to return the number of 
        // vowels in the sentence.
        public static void Menu()
        {
            string input;

            // loops until user answers no to run again
            do
            {
                // requests user to enter a sentence for counting
                Console.WriteLine("This program returns the number of vowels in a sentence.");
                Console.WriteLine("Enter a sentence to be counted:");
                input = Console.ReadLine();

                Console.WriteLine();

                // displays the number of characters and vowels in the string
                // calls the CountVowels method to obtain the number of vowels
                Console.WriteLine("There are {0} characters in the sentence, and {1} vowels.", input.Length, Utility.CountVowels(input));

                Console.WriteLine();

                // asks the user if they want to run the counting algorithm again
                // repeats the question until the user enters valid input
                do
                {
                    Console.Write("Run again? (y/n):");
                    input = Console.ReadLine();
                } while (!(input == "n" || input == "y"));

                Console.WriteLine();

            } while (input == "y");
        }

        // The CountVowels method returns the number of vowels (A, E, I, O, U)
        // in a provided string using a LINQ query.
        public static int CountVowels(string input)
        {
            // list of vowels, does NOT include Y
            char[] VOWELS = { 'a', 'e', 'i', 'o', 'u' };

            // creates a LINQ query
            // 1) converts string to all lowercase, then iterates over the string
            // 2) checks if each char is a vowel
            // 3) selects only the char's that are vowels
            IEnumerable<char> query = from c in input.ToLower()
                                      where VOWELS.Contains(c)
                                      select c;

            // since the query only contains vowels returning the 
            // count gives the number of vowels in the string
            return query.Count();
        }
    }
}
