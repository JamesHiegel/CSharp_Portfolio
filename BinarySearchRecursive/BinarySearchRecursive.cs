// SOURCE: https://www.geeksforgeeks.org/binary-search/
// AUTHOR: vt_m, RishabhPrabhu, DhruvJain6
// FILENAME: BinarySearchRecursive.cs
// PURPOSE: Given a sorted array arr[] of n elements, write a function to search for a given element x in arr[].
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added access modifiers to class and methods
// Added extra WriteLines to display what is occuring in program

// Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering 
// the whole array. If the value of the search key is less than the item in the middle of the interval, 
// narrow the interval to the lower half. Otherwise narrow it to the upper half. Repeatedly check until the 
// value is found or the interval is empty.
using System;

namespace JJH
{
    public class BinarySearchRecursive
    {
        // The Main method creates and displays the contents of an array,
        // and then call the BinarySearch method to find the index of an element
        public static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            Console.WriteLine("Array contents:\n[{0}]\n", string.Join(" ", arr));

            int x = 10;
            Console.WriteLine("Element to search for is {0}\n", x);

            int result = BinarySearch(arr, 0, arr.Length - 1, x);

            if (result > 0)
                Console.WriteLine("Element found at index " + result);
            else
                Console.WriteLine("Element not present");
        }

        // The BinarySearch method recursively searches the provided array for an element
        internal static int BinarySearch(int[] arr, int l, int r, int x)
        {
            // only runs if right index is greater than left index
            if (r >= l)
            {
                // calculates midpoint
                int mid = l + (r - l) / 2;

                // checks if the element is present at the middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return BinarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
    }
}
