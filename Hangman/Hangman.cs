// SOURCE: https://www.sanfoundry.com/csharp-programs-gaming-hangman/
// AUTHOR: Manish Bhojasia, a technology veteran with 20+ years @ Cisco &
//     Wipro, [along with consultancies at IBM, Brocade, Quantum, etc.]
//     is Founder and CTO at Sanfoundry. He is Linux Kernel Developer and
//     SAN Architect and is passionate about competency development....
//     He lives in Bangalore ....
// FILENAME: Hangman.cs
// PURPOSE: C# Program to Create a Hangman Game
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Extracted displaying the contents of the dictionary into a method.
// Added writelines to output text on console describing what is happening

// FUNCTIONAL MODIFICATIONS:
// Changed program so that it exits once all characters are guessed

/*
 *  C# Program to Create a HangMan Game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJH
{
    class Hangman
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");

            // creates array of words
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";

            // randomly picks a word from the array
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];

            // creates an array equal the the length of the word to guess
            // and fills it with stars
            char[] guess = new char[mysteryWord.Length];
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            Console.WriteLine(guess);

            Console.Write("Please enter your guess: ");

            int correct = 0;
            
            // loops until all characters are guessed
            while (correct < mysteryWord.Length)
            {
                // reads the character entered by the user
                char.TryParse(Console.ReadLine(), out char playerGuess);

                // iterates over the star array
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    // at each index, checks if user entered character exisits
                    // if so it replaces the star with the character
                    if (playerGuess == mysteryWord[j])
                    {
                        guess[j] = playerGuess;
                        // increments correct count
                        correct++;
                    }
                }
                Console.WriteLine(guess);
            }
        }
    }
}