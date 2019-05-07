// SOURCE: https://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/
// AUTHOR: Gaurav Ahirwar, anuj_67
// FILENAME: SearchSortedRotatedArray.cs
// PURPOSE: Devise a way to find an element in the rotated array in O(log n) time.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added access modifiers to class and methods
// Added multiple search examples

// The idea is to find the pivot point, divide the array in two sub-arrays and call binary search.
// The main idea for finding pivot is – for a sorted(in increasing order) and pivoted array, pivot 
// element is the only element for which next element to it is smaller than it. Using above criteria 
// and binary search methodology we can get pivot element in O(logn) time
using System;

namespace JJH
{
    public class SearchSortedRotatedArray
    {
        // The Main method demonstrates using the search to locate an element in an array
        public static void Main(string[] args)
        {
            
            int[] arr1 = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            Console.WriteLine("Array contents:\n[{0}]\n", string.Join(" ", arr1));

            int key = 3;
            Console.WriteLine("Element to search for {0}", key);
            Console.WriteLine("Index of the element is: {0}\n", PivotedBinarySearch(arr1, arr1.Length, key));

            key = 9;
            Console.WriteLine("Element to search for {0}", key);
            Console.WriteLine("Index of the element is: {0}\n", PivotedBinarySearch(arr1, arr1.Length, key));
        }

        // The PivotBinarySearch method finds an element key in a pivoted sorted array arrp[] of size n
        internal static int PivotedBinarySearch(int[] arr, int n, int key)
        {
            // calls the FindPivot method to get a starting pivot point
            int pivot = FindPivot(arr, 0, n - 1);

            // If we didn't find a pivot, then 
            // array is not rotated at all
            if (pivot == -1)
                return BinarySearch(arr, 0, n - 1, key);

            // If we found a pivot, then first compare with pivot
            if (arr[pivot] == key)
                return pivot;

            // and then search in two subarrays around pivot
            if (arr[0] <= key)
                return BinarySearch(arr, 0, pivot - 1, key);

            return BinarySearch(arr, pivot + 1, n - 1, key);
        }

        // The FindPivot method returns a pivot point from the given sorted array
        internal static int FindPivot(int[] arr, int low, int high)
        {
            // base cases 
            if (high < low)
                return -1;
            if (high == low)
                return low;

            // find mid point
            int mid = (low + high) / 2;

            if (mid < high && arr[mid] > arr[mid + 1])
                return mid;

            if (mid > low && arr[mid] < arr[mid - 1])
                return (mid - 1);

            if (arr[low] >= arr[mid])
                return FindPivot(arr, low, mid - 1);

            return FindPivot(arr, mid + 1, high);
        }

        /* Standard Binary Search function */
        internal static int BinarySearch(int[] arr, int low, int high, int key)
        {
            if (high < low)
                return -1;

            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (key == arr[mid])
                return mid;
            if (key > arr[mid])
                return BinarySearch(arr, (mid + 1), high, key);

            return BinarySearch(arr, low, (mid - 1), key);
        }
    }
}
