// SOURCE: https://www.geeksforgeeks.org/write-a-program-to-reverse-an-array-or-string/
// AUTHORS: Sam007, ChitraNayal, pp_pankaj

// FILENAME: ReverseArray.cs
// PURPOSE: Given an array (or string), the task is to reverse the array.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added method and code block comments describing what was occuring.
// Used white space to make code more readable.

// FUNCTIONAL MODIFICATIONS:
// Changed PrintArray method to use foreach instead of for-loop.
// Adjusted Main method to display more info on the console.
// Used array's Length method instead of hardcoded value.

// C# Program that reverses a provided array.
using System;

namespace JJH
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Console.Write("Original array is \n");
            PrintArray(arr);

            // reverses the array
            RvereseArray(arr);
            
            Console.Write("Reversed array is \n");
            PrintArray(arr);
        }

        // The RverseArray method iterates over the provided array swapping elements
        // from one side to another.
        static void RvereseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            int temp;

            // loops until both indexes meet in the middle
            while (start < end)
            {
                // sets value at start aside
                temp = arr[start];
                // replace start value with end value
                arr[start] = arr[end];
                // replace end value with temp value (start value)
                arr[end] = temp;

                // move start and end closer together
                start++;
                end--;
            }
        }

        // Helper method that prints the contents of the array
        static void PrintArray(int[] arr)
        {
            // iterates over array printing each element
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
