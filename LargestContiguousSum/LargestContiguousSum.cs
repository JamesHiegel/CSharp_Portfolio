// SOURCE: https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
// AUTHORS: vt_m, AnkitRai01, Akanksha_Rai, ChitraNayal
// FILENAME: LargestContiguousSum.cs
// PURPOSE: C# Program to print the largest contiguous array sum.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added second array to run method against
// Added code to display contents of arrays

/*
 * C# program to print the largest contiguous array sum
 */

using System;

namespace JJH
{
    class LargestContiguousSum
    {
        // Driver code 
        public static void Main()
        {
            // array of integers to be passed
            int[] arr = {-2, -3, 4, -1, -2, 1, 5, -3};
            Console.WriteLine("First Array:");
            Console.Write("[");
            foreach(int i in arr)
                Console.Write("{0} ", i);
            Console.WriteLine("]");

            // calls MaxSubArraySum method to display result
            MaxSubArraySum(arr, arr.Length);

            // array of integers to be passed
            int[] arr2 = { -1, 6, 4, -3, 8, 15, -5, -10 };
            Console.WriteLine("\nSecond Array:");
            Console.Write("[");
            foreach (int i in arr)
                Console.Write("{0} ", i);
            Console.WriteLine("]");

            // calls MaxSubArraySum method to display result
            MaxSubArraySum(arr2, arr.Length);

            Console.ReadLine();
        }

        // The MaxSubArraySum method calculates the
        static void MaxSubArraySum(int[] arr, int size)
        {
            // sets max_so_far to smallest value in array
            int max_so_far = int.MinValue;

            int max_ending_here = 0;
            int start = 0;
            int end = 0;
            int s = 0;

            // iterates over array
            for (int i = 0; i < size; i++)
            {
                max_ending_here += arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    // sets start and end index of max sum
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    // increments start index
                    s = i + 1;
                }
            }

            // displays results
            Console.WriteLine("Maximum contiguous " +
                            "sum is " + max_so_far);
            Console.WriteLine("Starting index " +
                                        start);
            Console.WriteLine("Ending index " +
                                        end);
        }
    }

}