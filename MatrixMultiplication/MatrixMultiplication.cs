// SOURCE: https://code.fandom.com/wiki/Matrix_multiplication
// AUTHOR: Fandom
// FILENAME: MatrixMultiplication.cs
// PURPOSE: Multiplies two matrices.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

// Program in C# to multiply two matrices using Rectangular arrays.
using System;

namespace JJH
{
    public class MatrixMultiplication
    {
        private int[,] a;
        private int[,] b;
        private int[,] c;

        // Driver method
        public static void Main()
        {
            MatrixMultiplication MM = new MatrixMultiplication();
            MM.ReadMatrix();
            MM.MultiplyMatrix();
            MM.PrintMatrix();
        }

        // Collects user input and builds 2d matrix
        public void ReadMatrix()
        {
            Console.WriteLine("\n Size of Matrix 1:");

            Console.Write("\n Enter the number of rows in Matrix 1 :");
            int m = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the number of columns in Matrix 1 :");
            int n = int.Parse(Console.ReadLine());

            // creates and fills the 2d matrix
            a = new int[m, n];
            Console.WriteLine("\n Enter the elements of Matrix 1:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Size of Matrix 2 :");

            Console.Write("\n Enter the number of rows in Matrix 2 :");
            m = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the number of columns in Matrix 2 :");
            n = int.Parse(Console.ReadLine());

            // creates and fills the 2d matrix
            b = new int[m, n];
            Console.WriteLine("\n Enter the elements of Matrix 2:");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Displays contents of 2d matrix
        public void PrintMatrix()
        {
            Console.WriteLine("\n Matrix 1:");

            // iterates through entire matrix
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("\t" + a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Matrix 2:");

            // iterates through entire matrix
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("\t" + b[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Resultant Matrix after multiplying Matrix 1 & Matrix 2:");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write("\t" + c[i, j]);
                }
                Console.WriteLine();
            }

        }
        
        // Multiplies 2d matricies
        public void MultiplyMatrix()
        {
            if (a.GetLength(1) == b.GetLength(0))
            {
                c = new int[a.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++) // OR k<b.GetLength(0)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("\n Number of columns in Matrix1 is not equal to Number of rows in Matrix2.");
                Console.WriteLine("\n Therefore Multiplication of Matrix1 with Matrix2 is not possible");
                Environment.Exit(-1);
            }
        }
    }
}