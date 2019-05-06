// SOURCE: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
// AUTHOR: Unknown

// FILENAME: QuickSort.cs
// PURPOSE: Sort an integer array with a quick sort algorithm.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added comments explaining what each method and code block does

// FUNCTIONAL MODIFICATIONS:
// Extracted array display code into its own method.
// Added console display of swapping steps to improve clarity of sorting process.

// Quick sort is a comparison sort, meaning that it can sort items of any 
// type for which a "less-than" relation (formally, a total order) is defined.

using System;

namespace QuickSort
{
    class QuickSort
    {
        // The main method creates an intger array with test data and then calls the quicksort method to sort the array.
        // Both the initial data and sorted data are displayed for comparison.
        static void Main(string[] args)
        {
            // creates and integer array with test data
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            // displays test data
            Console.WriteLine("Original array : ");
            PrintArray(arr);
            Console.WriteLine();

            // sorts the array
            Console.WriteLine("Sorting steps");
            Quick_Sort(arr, 0, arr.Length - 1);
            Console.WriteLine();

            // displays the sorted test data
            Console.WriteLine("Sorted array : ");
            PrintArray(arr);
        }

        // The Quick_Sort method calls the partition method to obtain a pivot point,
        // and then recursively calls itself to sort the array
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // calls the partition method to return a pivot point
                int pivot = Partition(arr, left, right);

                // recursively calls quick sort on left side of pivot point
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }

                // recursively calls quick sort on right side of pivot point
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        // The Partition method returns an integer that is the index to be used as a pivot point in the quick sort method
        private static int Partition(int[] arr, int left, int right)
        {
            // sets pivot point as the leftmost value in the provided array
            int pivot = arr[left];

            // infinite loop
            while (true)
            {
                // iterates the left index forward along the array until it reaches 
                // an element whose value is not less than the pivot value
                while (arr[left] < pivot)
                {
                    left++;
                }

                // iterates the right index backwards down the array until it reaches 
                // an element whose value is greater than the pivot value
                while (arr[right] > pivot)
                {
                    right--;
                }

                // checks if the left index is less than the right index 
                // NOTE: this is not the value of the element in the array
                if (left < right)
                {

                    // if the values of the element at both location is the same,
                    // return the right index
                    if (arr[left] == arr[right])
                    {
                        return right;
                    }

                    // swaps the values at the left and right index
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    Console.WriteLine(" Swapped {0} and {1}", arr[right], arr[left]);

                    PrintArray(arr);
                }
                // if the right index is greater than the left index then returns the right index
                else
                {
                    return right;
                }
            }
        }

        // Helper method to display provided array
        private static void PrintArray(int[] arr)
        {
            Console.Write("[");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.Write("]\n");
        }
    }
}
