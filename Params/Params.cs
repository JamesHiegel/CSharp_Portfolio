// SOURCE: https://www.geeksforgeeks.org/c-sharp-params/
// AUTHOR: niku123
// FILENAME: Params.cs
// PURPOSE: Demonstrate using param keyword.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added additional example and more descriptive console output

/*
 * C# program to illustrate the use of params keyword 
 */
using System;

namespace JJH
{
    public class Params
    {
        // Driver Code	 
        static void Main(string[] args)
        {
            // Calling function by passing 1 argument
            int x = Add(15);
            Console.WriteLine("Single argument parameter: {0}", x);

            // Calling function by passing 5 arguments 
            int y = Add(12, 13, 10, 15, 56);
            Console.WriteLine("Multiple argument parameter: {0}", y);
        }

        // The Add method utilizes the params keyword to collect an array of integers,
        // it then iterates over the array summing them
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop 
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
    }
}
