// SOURCE: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
// AUTHOR: Unknown

// FILENAME: MergeSort.cs
// PURPOSE: Demonstrate a merge sort on an integer array.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 

// FUNCTIONAL MODIFICATIONS:


// Conceptually, a merge sort works as follows :
// Divide the unsorted list into n sublists, each containing 1 element
// (a list of 1 element is considered sorted). Repeatedly merge sublists 
// to produce new sorted sublists until there is only 1 sublist remaining.
// This will be the sorted list.

using System;
using System.Collections.Generic;

namespace MergeSort
{
    class MergeSort_orig
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();

            Console.WriteLine("Original array elements:");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();

            sorted = MergeSort(unsorted);

            Console.WriteLine("Sorted array elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
        }

    }
}
