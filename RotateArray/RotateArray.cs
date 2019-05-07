// SOURCE: https://www.geeksforgeeks.org/c-program-cyclically-rotate-array-one/
// AUTHOR: jit_t, ChitraNayal, Shiva_Chandel, nitinshivanandmesta, PavanKumar47
// FILENAME: RotateArray.cs
// PURPOSE: Given an array, cyclically rotate the array clockwise by one.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added additional example to show second rotation
// Added extra WriteLines to display what is occuring in program
// Removed redundanct int declaration in RotateArrayByOne method

using System;

namespace JJH
{
    public class RotateArray
    {
        // The Main method creates and displays an integer array,
        // then utilizes the RotateArrayByOne method to rotate,
        // the array twice displaying changes each time
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            // displays unrotated array
            Console.WriteLine("Given Array is: ");
            string Original_array = string.Join(" ", arr);
            Console.WriteLine(Original_array);

            Console.WriteLine("\nRotate Array by 1");
            RotateArrayByOne(arr);

            // displays array rotated once
            Console.WriteLine("\nRotated Array is: ");
            string Rotated_array = string.Join(" ", arr);
            Console.WriteLine(Rotated_array);

            Console.WriteLine("\nRotate Array by 1 again");
            RotateArrayByOne(arr);

            // displays array rotated twice in total
            Console.WriteLine("\nRotated Array is now: ");
            Rotated_array = string.Join(" ", arr);
            Console.WriteLine(Rotated_array);
        }

        // The RotateArrayByOne method moves each value in an array left by one index
        internal static void RotateArrayByOne(int[] arr)
        {
            // saves the right most value in the array
            int x = arr[arr.Length - 1];

            // iterates over the array replacing each value with the once to its left
            for (int i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];

            // replaces the first value with the previously last value
            arr[0] = x;
        }
    }
}
