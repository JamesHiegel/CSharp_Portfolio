// SOURCE: https://www.sanfoundry.com/csharp-program-list-files-directory/
// AUTHOR: Manish Bhojasia
// FILENAME: GetFileTime.cs
// PURPOSE: C# Program to list the File creation Time using File Class.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

/*
 * C# Program to Get File Time using File Class
 */
using System;
using System.IO;

namespace JJH
{
    class GetFileTime
    {
        // The Main method creates a file and then displays the file creation time
        static void Main()
        {
            // creates file on c:\ drive
            FileInfo info = new FileInfo("C:\\srip.txt");

            // collects creation time from file
            DateTime time = info.CreationTime;

            // displays creation time info
            Console.WriteLine("File was Created at : ");
            Console.Write(time);
            Console.Read();
        }
    }
}