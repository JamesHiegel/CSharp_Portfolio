// SOURCE: https://www.w3resource.com/csharp-exercises/file-handling/csharp-file-handling-exercise-6.php
// AUTHOR: w3 resource
// FILENAME: WriteArrayToFile.cs
// PURPOSE: Write an array of strings to a file.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Moved main method variable declarations closer to usage point
// Removed System.IO from File.WriteAllLines, not needed with using System.IO

/* 
 * A C# program that writes an array of strings to a file.
 */
using System;
using System.IO;

namespace JJH
{
    class WriteArrayToFile
    {
        static void Main()
        {
            // file that will be created to hold lines of strings
            string fileName = @"mytest.txt";

            Console.Write("\n\n Create a file and write an array of strings  :\n");
            Console.Write("---------------------------------------------------\n");

            // checks if the file exists already, if so deletes it
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // asks user to specify number of lines
            Console.Write(" Input number of lines to write in the file  :");
            int numOfLines = int.Parse(Console.ReadLine());

            // creates array to hold lines of strings
            string[] ArrLines = new string[numOfLines];

            // displays content of array
            Console.Write(" Input {0} strings below :\n", numOfLines);
            for (int i = 0; i < numOfLines; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            // creates a file, writes all the lines to it and then closes the file
            // does not need a finally or using statement
            File.WriteAllLines(fileName, ArrLines);

            // creates streamreader object to read the contents of a file
            // the using statement closes the resource when done, even if an exception occurs
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                
                // header of output
                Console.Write("\n The content of the file is  :\n", numOfLines);
                Console.Write("----------------------------------\n");

                // reads eachline from the streamreader object and displays it on the screen,
                // until the line equals null, which is the end of the file
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", s);
                }
                Console.WriteLine();
            }
        }
    }
}