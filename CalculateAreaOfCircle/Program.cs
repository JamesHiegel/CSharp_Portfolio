// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: CalculateAreaOfCircle
// PURPOSE: C# Program to calculate the area of a circle.
// STUDENT: Antonio Santana
// DATE: 13 April 2019
// Changes: 
using System;

namespace CalculateAreaOfCircle
{
    class MainClass
    {
        // Calls 3 functions and introduces new data types.
        public static void Main(string[] args)
        {
            WorkingWithIntegers();

            OrderPrecedence();

            TestLimits();

            WorkWithDoubles();

            // Decimal data types are used for monetary values.
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            // Double data types are used for double precision values.
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }

        static void WorkingWithIntegers()
        {
            // Int data types are used for whole number values.
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        // Modulus operator introduced to capture remainder.
        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }
    }
}
/*
Output:
24
12
108
3
13
18
25
3
quotient: 3
remainder: 2
The range of integers is -2147483648 to 2147483647
An example of overflow: -2147483646
4.5
5.25
The range of double is -1.79769313486232E+308 to 1.79769313486232E+308
0.333333333333333
The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335
0.333333333333333
0.3333333333333333333333333333
19.6349540849362        
      */
