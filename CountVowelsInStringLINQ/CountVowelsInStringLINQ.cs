// AUTHOR: James Hiegel
// FILENAME: CountVowelsInStringLINQ.cs
// PURPOSE: Count the number of vowels in a string, both uppercase and lowercase.
// DATE: 18 May 2019

// This program prompts a user to enter a sentence and then counts the 
// uppercase and lowercase vowels in the sentence. The program then 
// outputs the number of vowels

using System;
using System.Collections.Generic;
using System.Linq;

namespace JJH
{
    public class CountVowelsInStringLINQ
    {
        public static void Main(string[] args)
        {
            Utility.Menu();
        }
    }


    public class Utility
    {
        public static int CountVowels(string input)
        {
            char[] VOWELS = { 'a', 'e', 'i', 'o', 'u' };

            IEnumerable<char> query = from c in input.ToLower()
                                      where VOWELS.Contains(c)
                                      select c;

            return query.Count();
        }

        public static void Menu()
        {
            string input;

            do
            {
                Console.WriteLine("This program returns the number of vowels in a sentence.");
                Console.WriteLine("Enter a sentence to be counted:");
                input = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("There are {0} characters in the sentence, and {1} vowels.", input.Length, Utility.CountVowels(input));

                Console.WriteLine();

                do
                {
                    Console.Write("Run again? (y/n):");
                    input = Console.ReadLine();
                } while (!(input == "n" || input == "y"));

                Console.WriteLine();

            } while (input == "y");
        }
    }
}
