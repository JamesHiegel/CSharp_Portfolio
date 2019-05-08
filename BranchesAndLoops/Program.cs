// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: BranchesAndLoops
// PURPOSE: A simple C# Program to demonstrate branches and iteration logic.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;

namespace BranchesAndLoops
{
    class MainClass
    {
        public static void Main()
        {
            ExploreIf();

            //// While loop.
            //// Evaluate condition & execute statements until condition is false.
            //// initializer: int index = 0; declares counter as a loop variable, 
            //// and sets its initial value to 0.
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //}

            //// Do while loop.
            //// Executes code first and then evaluates if condition is true.
            //// Loop continues to execute as long as the value of counter 
            //// is less than 10.
            //counter = 0;
            //do
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //} while (counter < 10);

            //// For loop.
            //// Three parts that control are initializer, condition, and iterator.
            //// iterator: index++ specifies how to modify the loop variable
            //// after executing the block following the for statement. 
            //// index should be incremented by 1 each time the block executes.
            //for (int index = 0; index < 10; index++)
            //{
            //    Console.WriteLine($"Hello World! The index is {index}");
            //}
        }

        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            int c = 1;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
    }
}