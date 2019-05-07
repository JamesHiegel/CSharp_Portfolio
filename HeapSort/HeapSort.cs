// SOURCE: https://www.geeksforgeeks.org/heap-sort/
// AUTHOR: Shivi_Aggarwal, Akanksha_Rai, RishiAdvani, Vibhav Gupta
// FILENAME: HeapSort.cs
// PURPOSE: Heap sort is a comparison based sorting technique based on Binary Heap data structure.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Added access modifiers to class and methods
// Displayed additional information on console during program run

// Since a Binary Heap is a Complete Binary Tree, it can be easily represented as array and array 
// based representation is space efficient.If the parent node is stored at index I, the left child 
// can be calculated by 2 * I + 1 and right child by 2 * I + 2 (assuming the indexing starts at 0).

// Heap Sort Algorithm for sorting in increasing order:
// 1. Build a max heap from the input data.
// 2. At this point, the largest item is stored at the root of the heap.Replace it with the last item of the heap followed by reducing the size of heap by 1. Finally, heapify the root of tree.
// 3. Repeat above steps while size of heap is greater than 1.
using System;

namespace JJH
{
    public class HeapSort
    {
        public static void Main(string[] args)
        {
            // creates new randomized array of size elements
            int size = 40;
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }

            Console.WriteLine("Unsorted array is:\n{0}\n", String.Join(" ", arr));

            HeapSort hs = new HeapSort();
            hs.Sort(arr);

            Console.WriteLine("Sorted array is:\n{0}\n", String.Join(" ", arr));
        }

        // The Sort method uses a series of heapify calls to sort the array
        internal void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // One by one extract an element from heap 
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                Heapify(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        internal void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree 
                Heapify(arr, n, largest);
            }
        }
    }
}
