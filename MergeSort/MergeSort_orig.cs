// SOURCE: https://www.c-sharpcorner.com/blogs/merge-sorting-algorithm-in-c-sharp1
// AUTHOR: Abhay Shanker

// FILENAME: MergeSort_orig.cs
// PURPOSE: Demonstrate a merge sort on an integer array.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 

// FUNCTIONAL MODIFICATIONS:


// Merge sort is based on the divide-and-conquer paradigm. We break down
// an array into two sub arrays. This code sample explains how a merge 
// sort algorithm works and how it is implemented in C#.

using System;

namespace MergeSort
{
    class MergeSort_orig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
