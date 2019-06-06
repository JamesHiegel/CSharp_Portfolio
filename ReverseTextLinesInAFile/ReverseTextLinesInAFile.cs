using System;
using System.Collections.Generic;
using System.IO;

namespace JJH
{
    // Utilizes a stack to reverse the lines of text in a file
    class ReverseTextLinesInAFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reverses the lines of text in a file.");

            Utility.ReverseLines("input.txt", "output.txt");

        }

        // The Utility class contains helper methods
        public class Utility
        {
            // The ReverseLines method reads a file, 
            // reverses the contained lines of text,
            // and writes the result to a new file
            public static void ReverseLines(string inputFile, string outputFile)
            {
                // creates the stack to hold the data from the file
                Stack<string> st = new Stack<string>();

                // try-catch block to handle exceptions
                try
                {
                    // opens a file with a StreamReader object
                    using (StreamReader sr = new StreamReader(inputFile))
                    {
                        // iterates over the lines of the file and pushes them onto the stack
                        while (!sr.EndOfStream)
                        {
                            st.Push(sr.ReadLine());
                        }
                    }

                    // creates a new file with a StreamWriter object
                    using (StreamWriter sw = new StreamWriter(outputFile))
                    {
                        // pops every element from the stack and writes it to the file
                        // thereby reversing the lines of text in the file
                        while (st.Count != 0)
                        {
                            sw.WriteLine(st.Pop());
                        }
                    }
                }
                // catches Exceptions and displays the error message to the console
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
