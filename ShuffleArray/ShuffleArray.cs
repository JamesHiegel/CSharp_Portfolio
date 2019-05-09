// SOURCE: https://www.geeksforgeeks.org/shuffle-a-given-array-using-fisher-yates-shuffle-algorithm/
// AUTHORS: Sam007
// FILENAME: ShuffleArray.cs
// PURPOSE: This program shuffles elements in an array.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Moved display of array contents to main method
// Added labels to console output

/*
 * C# program to shuffle elements in an array
 */

using System;

namespace JJH
{
    public class ShuffleArray
    {
        // Driver Code 
        static void Main()
        {
            // array to be shuddled
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine("Starting array:");
            foreach (int i in arr)
                Console.Write(i + " ");

            // calls method to shuffle array
            RandomizeArray(arr, arr.Length);

            // Prints the random array 
            Console.WriteLine("\n\nShuffled array:");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.ReadLine();
        }

        // A Function to generate a 
        // random permutation of arr[] 
        public static void RandomizeArray(int[] arr, int n)
        {
            Random r = new Random();

            // iterates backwards along array
            for (int i = n - 1; i > 0; i--)
            {
                // gets the value of a random element
                int j = r.Next(0, i + 1);

                // Swap arr[i] with the 
                // element at random index 
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}