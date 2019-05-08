/*
   Source: https://www.sanfoundry.com/csharp-program-check-given-number-even-odd/
   Author: Manish Bhojasia
   Summary: This program determines if the user's input is odd or even.
   Date: 5 Apr 2019
   Modifications: Modified program requesting user input and moved Console.Read
                  below the else statement to avoid redundant use as shown in the
                  original program.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The original program does not account for the possibility that an input
            // may not be a number. Inputs other than a numeric value returns an exception.

            int i;
            Console.Write("Enter a Number : ");

            // Using while loop in conjunction with TryParse(), the program will now
            // let the user know if the input is a number. It will continue to loop the
            // invalid message until the user inputs a number.
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Invalid input, please enter a number : ");
            }

            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }

            Console.Read();
        }
    }
}

/*                  
        Modified Output:
        User Input: x
        Invalid input, please enter a number :
        5
        Entered Number is an Odd Number
*/
