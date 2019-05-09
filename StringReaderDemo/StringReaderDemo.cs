// SOURCE: https://www.sanfoundry.com/csharp-program-string-reader/
// AUTHOR: Manish Bhojasia
// FILENAME: StringReaderDemo.cs
// PURPOSE: Demonstrates how the StringReader class reads each lines of the string in the order of appearance.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Moved constant variable into main method
// Added line breaks into TEXT variable

/* 
 * This program demonstrates how the StringReader class
 * reads each lines of the string in the order of appearance.
 */
using System;
using System.IO;

namespace JJH
{
    public class StringReaderDemo
    {
        public static void Main()
        {
            const string TEXT = "Sanfoundry offers\nTraining and Competency\ndevelopment programs";

            // creates a stringbuilder object to read the text
            using (StringReader reader = new StringReader(TEXT))
            {
                int count = 0;
                string textline = "";

                // reads a line from the stringreader object and checks if its null
                // null indicates end of string
                while ((textline = reader.ReadLine()) != null)
                {
                    // For every line, the count will add 1. The console
                    // will then print "Line (the count value): (corresponding
                    // text that falls within the line).
                    count++;
                    Console.WriteLine("Line {0}: {1}", count, textline);
                }
                Console.ReadLine();
            }
        }
    }
}