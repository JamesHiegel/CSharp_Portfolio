// SOURCE: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
// AUTHOR: Unknown

// FILENAME: MergeSort.cs
// PURPOSE: Demonstrate a merge sort on an integer array.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added comments describing what each method and small blocks of code do.

// FUNCTIONAL MODIFICATIONS:
// None

// Conceptually, a merge sort works as follows :
// Divide the unsorted list into n sublists, each containing 1 element
// (a list of 1 element is considered sorted). Repeatedly merge sublists 
// to produce new sorted sublists until there is only 1 sublist remaining.
// This will be the sorted list.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class MergeSort_orig
    {
        static void Main(string[] args)
        {
            // creates two integer lists to hold the unsorted and eventually sorted data
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();

            // fills unsorted list with random integer values
            // and then displays it
            Console.WriteLine("Original list elements:");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();

            // fills a list with sorted data from a provided list
            sorted = MergeSort(unsorted);

            // displays the sorted integer list
            Console.WriteLine("Sorted list elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
        }

        // This method splits a List into a right and left half and then makes successive recursive calls
        // making smaller and smaller lists until a list becomes a single element in size. Then it uses the 
        // Merge method to stitch the lists back together in sorted order and finally returns a sorted 
        // complete list.
        private static List<int> MergeSort(List<int> unsorted)
        {
            // if the list contains only one element then it is "sorted" and returns
            if (unsorted.Count <= 1)
                return unsorted;

            // creates two new lists, one each for the left and right half
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            
            // splits the list into a left and right half
            for (int i = 0; i < middle; i++)  
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            // recursively calls MergeSort on the left and right half
            left = MergeSort(left);
            right = MergeSort(right);

            // merges the two "sorted" halfs together
            return Merge(left, right);
        }

        // This method merges a left side and right side lists into a single sorted list.
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            // cycles until both the left side and right side list are out of elements
            while (left.Count > 0 || right.Count > 0)
            {
                // executes only if both left and right side have elements
                if (left.Count > 0 && right.Count > 0)
                {
                    // compares first two elements of each side to see which is smaller
                    if (left.First() <= right.First())  
                    {
                        // if the left side has the larger element
                        // add it to the result list
                        // and remove it from the left side list
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        // if the right side has the larger element
                        // add it to the result list
                        // and remove it from the right side list
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                
                // executes only if the left side has elements left over
                else if (left.Count > 0)
                {
                    // adds remaining elements from left side list to result list
                    // and removes them from left side list
                    result.Add(left.First());
                    left.Remove(left.First());
                }

                // executes only if the right side has elements left over
                else if (right.Count > 0)
                {
                    // adds remaining elements from right side list to result list
                    // and removes them from right side list
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            // both the right side and left side list should be empty now
            // and the results list contains the contents of both,
            // but in sorted order
            return result;
        }
    }
}
