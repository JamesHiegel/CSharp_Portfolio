// SOURCE:  https://www.sanfoundry.com/csharp-program-multiple-exceptions/
// AUTHOR: Manish Bhojasia
// FILENAME: MultipleExceptions.cs
// PURPOSE: Demonstrate Multiple Exceptions.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// None

using System;

namespace JJH
{
    public class MultipleExceptions
    {
        public static void Main()
        {
            double Num1, Num2;
            char op;

            Console.WriteLine("This program calculates single operator expressions.");

            try
            {
                Console.Write("Enter your First Number :  ");
                Num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter an Operator  (+, -, * or /): ");
                op = char.Parse(Console.ReadLine());

                // checks for valid operator
                // throws exception if operator is invalid
                if (op != '+' && op != '-' &&
                    op != '*' && op != '/')
                    throw new Exception(op.ToString());

                Console.Write("Enter your Second Number :");
                Num2 = double.Parse(Console.ReadLine());

                // throws exception if attempt to divde by zeor
                if (op == '/')
                    if (Num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");

                double Result = Calculator(Num1, Num2, op);
                Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);
            }
            // a series of catch statements that handle the various errors that can be thrown by above code
            catch (FormatException)
            {
                Console.WriteLine("The number you typed is not valid");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operation Error: {0} is not a valid op", ex.Message);
            }
            Console.Read();
        }

        // The Calculator method performs the single operator calculation
        // and returns the result
        static double Calculator(double v1, double v2, char op)
        {
            double Result = 0.00;

            switch (op)
            {
                case '+':
                    Result = v1 + v2;
                    break;
                case '-':
                    Result = v1 - v2;
                    break;
                case '*':
                    Result = v1 * v2;
                    break;
                case '/':
                    Result = v1 / v2;
                    break;
            }
            return Result;
        }
    }
}