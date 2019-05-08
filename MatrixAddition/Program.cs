/*
   Source: https://www.sanfoundry.com/csharp-program-performs-matrix-addition/
   Author: Manish Bhojasia
   Summary: This program accepts the dimensions of two matrices from user
            input and displays their corresponding elements' sums.
   Date: 22 Apr 2019
   Modifications: ----

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables m, n, i, and j are declared int type and
            // obtained after being converted into int from the
            // user input's strings.
            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());

            // The program hard codes up to 10 by 10 dimensions
            // for the variable A array (as well as B and C).
            // The initial for loop will iterate and check to see
            // if the variable i will meet the conditions. The i
            // variable will always be less than the m variable which
            // is used for the number of rows.

            // The second for loop shows that j will always be less
            // than n, the number of columns. Both i and j are,
            // respectively, new elements that are stored into A[i, j]
            // array.
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    // Here, the elements of i and j will be converted
                    // from string to int and stored into the A array.
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            // By declaring new int[10, 10] and assigning it to
            // array B, i and j inputs will be considered new and
            // will be independent from the arrays stored in A[i, j]
            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            // The for loops below will print out the elements. The
            // '\t' is similar to the tab key.
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }

            // The third new array C is declared here and
            // its for loop is used to evaluate the sum
            // of arrays A and B's corresponding elements given
            // the same dimensions.
            int[,] C = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
/*
            Example output:
            Enter Number Of Rows And Columns Of Matrices A and B : 3  3
            Enter the First Matrix : 
            1 2 3
            2 3 4
            3 4 5
            Enter the Second Matrix :
            1 2 3
            2 1 4
            1 1 5
            Matrix A :
            1 2 3
            2 3 4
            3 4 5
            Matrix B :
            1 2 3
            2 1 4
            1 1 5
            Sum Matrix :
            2 4 6
            4 4 8
            4 5 10

*/
