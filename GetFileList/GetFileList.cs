// SOURCE: https://www.sanfoundry.com/csharp-program-list-files-directory/
// AUTHOR: Manish Bhojasia
// FILENAME: GetFileList.cs
// PURPOSE: C# Program to List the Files in a Directory.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:

/*
 * C# Program to List the Files in a Directory
 */
using System;
using System.IO;

namespace JJH
{
    class GetFileList
    {
        static void Main()
        {
            // creates an array of strings listing all files in the C:\ directory
            string[] array1 = Directory.GetFiles(@"C:\");

            // iterates over the array listing each file
            Console.WriteLine("Files in the Directory");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}