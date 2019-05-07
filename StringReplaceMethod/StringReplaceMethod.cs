// SOURCE: https://www.geeksforgeeks.org/c-sharp-replace-method/
// AUTHOR: Mithun Kumar
// FILENAME: StringReplaceMethod.cs
// PURPOSE: Demonstrates ways to use the Replace method of the String class.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Incorporated three examples into one program
// Extracted each example into its own method
// Used Main method to call each example method

// In C#, Replace() method is a string method. This method is used to replace all the 
// specified Unicode characters or specified string from the current string object and 
// returns a new modified string. This method can be overloaded by passing arguments to it.
using System;

namespace JJH
{
    public class StringReplaceMethod
    {
        // The Main method calls each of the examples in turn
        public static void Main(string[] args)
        {
            FindReplaceCharacter();
            FindReplaceString();
            FindReplaceChained();
        }

        // The FindReplaceCharacter method demonstrates replacing
        // single characters in a string
        internal static void FindReplaceCharacter()
        {
            String str = "Geeks For Geeks";
            Console.WriteLine("OldString: " + str);

            // replace the character 's' with 'G' 
            Console.WriteLine("NewString: " + str.Replace('s', 'G'));

            // oldString will remain unchanged 
            Console.WriteLine("\nOldString: " + str);

            // replace the character 'e' with space ' ' 
            Console.WriteLine("NewString: " + str.Replace('e', ' '));
        }

        // The FindReplaceCharacter method demonstrates replacing
        // a substring of characters in a string
        internal static void FindReplaceString()
        {
            String str = "Geeks For Geeks";
            Console.WriteLine("OldString: " + str);

            // replace the string 'Geeks' with '---' 
            // in string 'Geeks comes two time so replace two times 
            Console.WriteLine("NewString: " + str.Replace("Geeks", "---"));

            // oldString will remain unchanged 
            Console.WriteLine("\nOldString: " + str);

            // replace the string 'For' with 'GFG' 
            Console.WriteLine("NewString: " + str.Replace("For", "GFG"));
        }

        // The FindReplaceChained method demonstrates doing multiple
        // replacements in a row
        internal static void FindReplaceChained()
        {
            String str = "XXXXX";
            Console.WriteLine("Old String: " + str);

            // conducts back to back replacements 
            str = str.Replace('X', 'Y').Replace('Y', 'Z').Replace('Z', 'A');
            Console.WriteLine("New string: " + str);
        }
    }
}
