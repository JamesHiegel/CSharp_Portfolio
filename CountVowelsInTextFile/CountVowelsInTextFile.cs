// AUTHOR: James Hiegel
// FILENAME: CountVowelsInTextFile.cs
// PURPOSE: Count the number of vowels in a text file, both uppercase and lowercase.
// DATE: 18 May 2019

using System;
using System.Collections.Generic;
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
        // and captures the user's input
        // The Menu method displays instructions and prompts the user for input
        public static void DisplayMenu()
        {

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

        public static void CountVowelsInFile()
        {

        }

        public static void FindVowelsInString()
        {

        }
    }

}
