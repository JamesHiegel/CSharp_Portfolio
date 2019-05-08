/*
   Source: https://www.sanfoundry.com/csharp-program-string-reader/
   Author: Manish Bhojasia
   Summary: This program demonstrates how the StringReader class
            reads each lines of the string in the order of appearance.
   Date: 22 Apr 2019
   Modifications: ----

 */

using System;
using System.IO;

class Program
{
    const string text = @"Sanfoundry
offers Training and Competency
development programs";
    static void Main()
    {
        // The reader variable is assigned to a new StringReader
        // class which will be using the constant string text
        // from above.
        using (StringReader reader = new StringReader(text))
        {
            // The count variable will be used to determine the
            // the line number and set to 0. The textline variable
            // is going to be used to string the text from  the
            // const string text.
            int count = 0;
            string textline;

            // The while loop will execute continuosly until the
            // textline which is set to reader.ReadLine() does not
            // return null or empty, i.e, loop until there are no
            // lines left.
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

/*
            Example output:
            Line 1 : Sanfoundry
            Line 2 : Offers Training and Competency
            Line 3 : development programs

*/
