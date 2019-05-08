// SOURCE: https://www.sanfoundry.com/csharp-program-phonebook-webservice/
// AUTHOR: Manish Bhojasia
// FILENAME: HashtablePhonebook.cs
// PURPOSE: C# Program to list the File creation Time using File Class.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Surrounded file operations with using block, to ensure resources are closed when done

/*
 * C# Program to Implement PhoneBook
 */
using System;
using System.Collections;
using System.IO;

namespace JJH {

    class HashtablePhonebook
    {

        static void Main(string[] arg)
        {
            Console.WriteLine("This program loads a phonebook and outputs phonenumbers for requested names.");

            // creates a hashtable to hold the phonebook
            Hashtable phoneBook = new Hashtable();

            string fileName;

            // reads filename from commandline argument or uses default filename
            if (arg.Length > 0)
            {
                 fileName = arg[0];
            }
            else
            {
                fileName = "phoneBook.txt";
            }

            // creates streamreader object from the file
            // The using statement ensures that Dispose is called even if an exception occurs within the using block.
            using (StreamReader sr = File.OpenText(fileName))
            {

                // reads a single line from the stringreader object
                string line = sr.ReadLine();

                // loops until a line is null, i.e. end of file
                while (line != null)
                {
                    // phonebook record structure:
                    // name = 123456789

                    // find position of the field seperator
                    int pos = line.IndexOf('=');

                    // collects name field and removes lead and trail spaces
                    string name = line.Substring(0, pos).Trim();

                    // collects phone number and converts to long
                    long phoneNum = long.Parse(line.Substring(pos + 1));

                    // adds record to phonebook
                    phoneBook[name] = phoneNum;

                    // reads next line in file
                    line = sr.ReadLine();
                }
            }

            string nameSearch = "";

            do
            {
                Console.Write("\nEnter name to search for (enter quit to exit): ");
                nameSearch = Console.ReadLine().Trim();

                // attempts to find name in phonebook
                var phone = phoneBook[nameSearch];

                // outputs result
                if (nameSearch == "quit")
                    continue;
                else if (phone == null)
                    Console.WriteLine("-- Not Found in Phone Book");
                else
                    Console.WriteLine(phone);

            } while (nameSearch != "quit");
        }
    }
}
