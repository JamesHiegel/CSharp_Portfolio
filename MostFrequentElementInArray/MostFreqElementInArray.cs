// SOURCE: https://www.geeksforgeeks.org/frequent-element-array/
// AUTHORS: kartik, Akash Singh
// FILENAME: MostFreqElementInArray.cs
// PURPOSE: Given an array, find the most frequent element in it. 
// If there are multiple elements that appear maximum number of times, print any one of them.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added method and code block comments describing what was occuring.
// Used white space to make code more readable.

// FUNCTIONAL MODIFICATIONS:
// Added display of array to Main method.
// Converted program from Java to C#.
// Replaced for-loop with foreach-loop in MostFrequenct method.
// Moved frequecy tracking into foreach loop, so data is only check once instead of twice.

// The simple solution is to run two loops. The outer loop picks all elements one by one. 
// The inner loop finds frequency of the picked element and compares with the maximum so far.

// A better solution is to do sorting. We first sort the array, then linearly traverse the array.

// An efficient solution is to use hashing. We create a hash table and store elements and their
// frequency counts as key value pairs. Finally we traverse the hash table and print the key with 
// maximum value.
using System;
using System.Collections.Generic;

namespace JJH
{
    class MostFreqElementInArray
    {
        public static void Main(string[] args)
        {
            // original array
            int[] arr = { 1, 5, 2, 1, 3, 2, 1 };
            int max_count;

            // diplays formatted view of array
            Console.Write("The contents of the array are:\n| ");
            foreach (var i in arr) 
                Console.Write("{0} | ", i);

            Console.WriteLine("\nThe most frequent element in the array is {0}, at {1} times.", MostFrequent(arr, out max_count), max_count);
        }

        // The MostFrequent method interates over the integer array and adds the values to a dictionary,
        // incrementing the value each time the same integer is added
        internal static int MostFrequent(int[] arr, out int max_count)
        {
            int result = -1;
            max_count = 0;

            // creates a dictionary to store integer key pair values
            var dict = new Dictionary<int, int>();

            // iterates through array
            foreach (var i in arr)
            {
                // increments the value of a key, if the key exists in the dictionary,
                // otherwise adds the key value pair to the dictionary
                if (dict.ContainsKey(i))
                    dict[i] = ++dict[i];
                else
                    dict.Add(i, 1);
                
                // keeps track of the highest frequency in the dictionary
                if (max_count < dict[i])
                {
                    result = i;
                    max_count = dict[i];
                }
            }
            return result;
        }
    }
}
