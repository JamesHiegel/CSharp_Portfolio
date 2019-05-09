// SOURCE: https://www.sanfoundry.com/csharp-program-performs-matrix-addition/
// AUTHORS: Manish Bhojasia
// FILENAME: MatrixAddition.cs
// PURPOSE: This program accepts the dimensions of two matrices from user input and displays their corresponding elements' sums.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Replaced method declaration of i and j with declarations inside for-loops
// Used rows and columns variables throughtout instead of hardcoded values
// Extracted matrix display into seperate method

/*
 * Summary: This program accepts the dimensions of two matrices from user
 */
 using System;

namespace JJH
{
    class MatrixAddition
    {
        public static void Main(string[] args)
        {
            // asks user for size of two matricies
            Console.WriteLine("Enter Number Of Rows And Columns Of Matrices A and B. ");
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nEnter columns: ");
            int columns = Convert.ToInt16(Console.ReadLine());

            // creates matrix A
            int[,] A = new int[rows, columns];

            // asks user to input values for matrix A
            Console.WriteLine("\nEnter The First Matrix : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Here, the elements of i and j will be converted
                    // from string to int and stored into the A array.
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            // creates matrix B
            int[,] B = new int[rows, columns];

            // asks user to input values for matrix A
            Console.WriteLine("\nEnter The Second Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            // displays matrix A
            Console.WriteLine("\nMatrix A : ");
            DisplayMatrix(A);

            // displays matrix B
            Console.WriteLine("\nMatrix B : ");
            DisplayMatrix(B);


            // creates a third matrix and conductes the actual matrix addition
            int[,] C = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            // displays matrix C
            Console.WriteLine("\nSum : ");
            DisplayMatrix(C);

            Console.Read();
        }

        private static void DisplayMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            // The for loops below will print out the elements. The
            // '\t' is similar to the tab key.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
