// SOURCE: https://www.sanfoundry.com/csharp-program-copy-section-onearray-another/
// AUTHOR: W3 Resource
// FILENAME: CopyPartOfArray.cs
// PURPOSE: Copy a Section of One Array to Another.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read
// Cleaned up title case in text and fixed minor grammatical errors

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be clearer on what they are.
// Replaced Convert.ToInt32 with int.TryParse
// Added prompt for entering values of starting array.
// Removed string concatenation.
// Removed reduncant request for array size, instead used size of section to be copied for size of target array

/*
 * C# Program to Copy a Section of One Array to Another
 */
using System;

namespace JJH
{
    public class CopyPartOfArray
    {
        public static void Main()
        {
            // asks for size of source array
            Console.Write("Enter the size of the source array: ");
            int.TryParse(Console.ReadLine(), out int sourceSize);

            // cretaes source array
            int[] sourceArr = new int[sourceSize];

            // collects source array elements
            Console.WriteLine("Enter the elements of the source Array,");
            for (int i = 0; i < sourceSize; i++)
            {
                // request value for each index location
                Console.Write("Enter value at location {0}: ", i);
                int.TryParse(Console.ReadLine(), out sourceArr[i]);
            }

            // displays contents of source array
            Console.WriteLine("\nSource array contents");
            foreach (int i in sourceArr)
                Console.Write("{0} ",i);

            // asks for size of first array to be copied
            Console.Write("\nEnter the size section of the source array that has to be copied: ");
            int.TryParse(Console.ReadLine(), out int targetSize );

            // creates target array
            int[] targetArr = new int[targetSize];

            // copies portion of source array to target array
            Array.Copy(sourceArr, 0, targetArr, 0, targetSize - 1);

            // displays contents of new array
            Console.WriteLine("New array with the specified section of elements from the source array");
            foreach (int i in targetArr)
                Console.Write("{0} ", i);

            Console.Read();
        }
    }
}