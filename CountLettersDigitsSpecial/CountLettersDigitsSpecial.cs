// SOURCE: https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-7.php
// AUTHOR: w3 resource
// FILENAME: CountLettersDigitsSpecial.cs
// PURPOSE: Calculate the perimeter and area of a circle.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be self labeling

using System;

namespace JJH
{
    public class CountLettersDigitsSpecial
    {
        public static void Main()
        {
            int letters, digits, special, i;
            letters = digits = special = i = 0;


            Console.Write("\n\nCount total number of alphabets, digits and special characters :\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            string str = Console.ReadLine();

            /* Checks each character of string*/

            while (i < str.Length)
            {
                // counts number of letters
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    letters++;
                }
                // counts number of digits
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digits++;
                }
                // counts number of special characters
                else
                {
                    special++;
                }
                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", letters);
            Console.Write("Number of Digits in the string is : {0}\n", digits);
            Console.Write("Number of Special characters in the string is : {0}\n\n", special);
        }
    }
}