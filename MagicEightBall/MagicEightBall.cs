// source: https://github.com/panditakshay/Magic-8-ball/blob/master/Magic-8-Ball/Program.cs
// author: Pandit Akshay
// FILENAME: MagicEightBall.cs
// PURPOSE: C# Program to represent the Magic 8-Ball
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Extracted displaying the contents of the dictionary into a method.
// Added writelines to output text on console describing what is happening

// FUNCTIONAL MODIFICATIONS:
// Removed foul-mouthed insults and words
// Removed unused using statements
// Added instruction on how to quit
// Changed infinite loop to do-while loop

using System;
using System.Threading;

namespace JJH
{
    /// <summary>
    /// Entry point for Magic 8 Ball program 
    /// </summary>
    public class MagicEightBall
    {
        // Instantiate a randomObject to use later 
        internal static Random randomObject = new Random();

        // Preserve current console text color
        internal static ConsoleColor oldColor = Console.ForegroundColor;

        //Main method invoked 
        internal static void Main(string[] args)
        {

            // displays the program name and creator
            programInfo();

            // asks first question
            string questionString = getQuestion();

            do
            {
                // make the computer pause for seconds
                // to create an illusion of thinking
                int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep);

                //Check if user entered question, if not run the loop back
                if (questionString.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a question!");
                    continue;
                }

                // displays a random reply
                definedBallReplies();

                // asks question again
                questionString = getQuestion();

                //Quit the loop when user types "quit"
            } while (!(questionString.ToLower() == "quit"));
        }

        /// <summary>
        /// This will print the name of the program and the creator of it 
        /// </summary>
        internal static void programInfo()
        {
            // Change Console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ball ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("(By: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Pandit ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Akshay ");
            Console.WriteLine();
        }

        /// <summary>
        /// This function will return text the user types
        /// </summary>
        /// <returns></returns>
        internal static string getQuestion()
        {
            // This block of code will ask user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question? (enter quit to exit): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            String questionString = Console.ReadLine();

            return questionString;
        }

        /// <summary>
        /// This gives the random generated pre defined 8 ball replies
        /// out of 18 given replies
        /// </summary>
        internal static void definedBallReplies()
        {
            // Create a random # (0-19)
            // because 19 replies
            int randomNumber = randomObject.Next(19);

            // Use random number to determine response
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("YES!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("NO!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Maybe");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Possibly");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("It is certain");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("It is decidedly so");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Without a doubt");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("You may rely on it");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Most likely!");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Outlook good!");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Reply hazy try again!");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Ask again later");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Better not tell you now!");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Cannot predict now");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("Concentrate and ask again");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Don't count on it");
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("My sources say no");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Outlook not so good");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Very doubtful");
                        break;
                    }
            }
        }
    }
}