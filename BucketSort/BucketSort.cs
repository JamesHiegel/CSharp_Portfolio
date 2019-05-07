// SOURCE: https://www.csharpstar.com/csharp-program-to-perform-bucket-sort/
// AUTHOR: unknown
// FILENAME: BucketSort.cs
// PURPOSE: Use the bucket sort algorithm to sort an array of integers.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added randomly populated array of integers
// Added code block that outputs bucket contents

// Bucket sort, or bin sort, is a sorting algorithm that works by partitioning an array into 
// a number of buckets.Each bucket is then sorted individually, either using a different sorting 
// algorithm, or by recursively applying the bucket sorting algorithm.It is a distribution sort, 
// and is a cousin of radix sort in the most to least significant digit flavour.Bucket sort is a 
// generalization of pigeonhole sort.

// Bucket sort works as follows:
// 1. Set up an array of initially empty “buckets”.
// 2. Scatter: Go over the original array, putting each object in its bucket.
// 3. Sort each non-empty bucket.
// 4. Gather: Visit the buckets in order and put all elements back into the original array
using System;
using System.Collections.Generic;

namespace JJH
{
    public class BucketSort
    {
        // The Main method generates a randomly filled array,
        // passes it to the BuckleSort class and then,
        // displays the result
        public static void Main(string[] args)
        {
            // Creates new randomized array of size elements
            int size = 35;
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(99);
            }

            Console.WriteLine("Unsorted array:\n{0}\n", String.Join(" ", arr));

            List<int> sorted = Sort.BucketSort(arr);

            Console.Write("\nSorted list:\n[");
            foreach (int i in sorted)
                Console.Write("{0} ",i);
            Console.Write("]\n");
        }

        // The Sort class contains a BucketSort method that returns a sorted list from 
        // a array, and a Bubblesort method that returns a sort array from a list
        public static class Sort
        {
            // Bucket sort breaks a list down into sub-lists, you can then use another algorithm to sort the sub-lists
            // In this case, we will focus on building an algorithm that uses bucketsort to sort an array of integers between 1 and 99
            public static List<int> BucketSort(int[] x)
            {
                // Creates a new list to hold the result
                List<int> result = new List<int>();

                // Determine how many buckets you want to create, in this case, the 10 buckets will each contain a range of 10
                // 1-10, 11-20, 21-30, etc. since the passed array is between 1 and 99
                int numOfBuckets = 10;

                // Create buckets
                List<int>[] buckets = new List<int>[numOfBuckets];
                for (int i = 0; i < numOfBuckets; i++)
                    buckets[i] = new List<int>();

                // Iterate through the passed array and add each integer to the appropriate bucket
                for (int i = 0; i < x.Length; i++)
                {
                    int buckitChoice = (x[i] / numOfBuckets);
                    buckets[buckitChoice].Add(x[i]);
                }

                // Displays contents of each bucket
                for (int i = 0; i < numOfBuckets; i++)
                {
                    int[] temp = BubbleSortList(buckets[i]);

                    Console.Write("Bucket {0} contains: [", i * 10);
                    foreach (int j in temp)
                        Console.Write("{0} ",j);
                    Console.WriteLine("]");
                }

                // Sort each bucket and add it to the result List
                // Each sublist is sorted using Bubblesort, but you could substitute any sorting algo you would like
                for (int i = 0; i < numOfBuckets; i++)
                {
                    int[] temp = BubbleSortList(buckets[i]);
                    result.AddRange(temp);
                }
                return result;
            }

            // Bubblesort w/List Input
            public static int[] BubbleSortList(List<int> input)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[i] < input[j])
                        {
                            int temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                return input.ToArray();
            }
        }
    }
}

