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

            // calls the CountVowelsInFile to obtain the number of
            // vowels in the provided file
            int numVowels = CountVowelsInFile(filePath);

            // only displays if count is non-negative
            if (numVowels >= 0)
                Console.WriteLine("The text file contains {0} vowels.\n", numVowels);
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
            
            // returns a bool indicating option selected
            return ret;
        }

        // The CountVowelsInFile method reads each line of text from a
        // specified file. The lines are passed to the FindVowelsInString
        // method which returns the count of vowels in the line. Once
        // the end of file is reached this method returns the number of
        // vowels in the file.
        public static int CountVowelsInFile(string filePath)
        {
            int ret = 0;
            
            // the try-catch block handles any specified exceptions
            // uses a filter in the catch block to specify which
            // exceptions are handled
            try
            {
                // opens a stream for the specified file
                // the using statement ensures IDisposable objects are closed,
                // otherwise you have to the finally block
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // loops until the end of file is reached
                    while (!sr.EndOfStream)
                    {
                        // sums the number of vowels in the file
                        ret += FindVowelsInString(sr.ReadLine());
                    }
                }
            }
            // catches all exceptions but only handles them if they meet a specified filter
            // source: https://blog.pieeatingninjas.be/2016/09/26/how-to-catch-multiple-types-of-exceptions-in-one-catch-block/
            catch (Exception ex)
            {
                // filters exceptions to handle
                if (ex is IOException || ex is UnauthorizedAccessException || ex is ArgumentException)
                {
                    // displays error message when an exception is caught
                    Console.WriteLine("\nEXCEPTION CAUGHT!");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    
                    ret = -1;
                }
                // rethrows exceptions that are in the filter
                else
                    throw;
            }
            // returns number of vowels in file,
            // or -1 to indicate a problem occured
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
