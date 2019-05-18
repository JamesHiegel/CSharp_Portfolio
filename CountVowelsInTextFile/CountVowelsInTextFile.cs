// AUTHOR: James Hiegel
// FILENAME: CountVowelsInTextFile.cs
// PURPOSE: Count the number of vowels in a text file, both uppercase and lowercase.
// DATE: 18 May 2019

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JJH
{
    // This program prompts a user to enter the path and filename for a text file,
    // and then returns the number of vowels in that file.
    public class CountVowelsInTextFile
    {
        // The Main method runs until the user asks to quit
        public static void Main(string[] args)
        {
            bool opt;

            Console.WriteLine("This program asks for a path and filename to a text file, " +
                "and then returns the number of vowels in that file.");

            // loops until user asks to exit program
            do
            {
                // displays menu and handles user input
                Utility.DisplayMenu();
                // asks user if they want to exit
                opt = Utility.RunAgain();

            } while (opt);
        }
    }

    // The Utility class contains methods to display a menu, 
    // ask a user if they want to quit, count vowels in a 
    // file, and find vowels in a string
    public class Utility
    {
        // The DisplayMenu method displays instructions to a user
        // and captures the user's input, then calls other methods
        public static void DisplayMenu()
        {
            Console.WriteLine("\nEnter path and file name to a text file:");
            string filePath = Console.ReadLine();

            Console.WriteLine();

            int numVowels = CountVowelsInFile(filePath);

            if (numVowels > 0)
                Console.WriteLine("The text file contains {0} vowels.\n");
        }

        // The RunAgain method asks a user if they want to
        // run the program again and returns a bool
        public static bool RunAgain()
        {
            string input;
            // default is to not run program again
            bool ret = false;

            // loops until user input is valid
            do
            {
                Console.Write("Run Again? (y/n): ");
                input = Console.ReadLine();
            } while (!(input == "y" || input == "n"));

            // changes return to true if user says yes
            if (input == "y")
                ret = true;

            return ret;
        }

        public static int CountVowelsInFile(string filePath)
        {
            int ret = 0;
            
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        ret += FindVowelsInString(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                // displays error message when an exception is caught
                // message is different for each subtype of FormatException
                Console.WriteLine("\nEXCEPTION CAUGHT!");
                Console.WriteLine(e.Message);
                Console.WriteLine();

                ret = -1;
            }

            return ret;
        }

        // The CountVowels method returns the number of vowels (A, E, I, O, U)
        // in a provided string using a LINQ query.
        public static int FindVowelsInString(string input)
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
