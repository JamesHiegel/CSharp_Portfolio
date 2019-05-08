// SOURCE: https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-5.php
// AUTHOR: w3 resource
// FILENAME: CalculateAreaOfCircle.cs
// PURPOSE: Calculate the perimeter and area of a circle.
// STUDENT: James Hiegel
// DATE: 08 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be self labeling

using System;

namespace JJH
{
    class CalculateAreaOfCircle
    {
        const double PI = 3.14;

        public static void Main(string[] args)
        {
            Console.WriteLine("Input the radius of the circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Perimeter of Circle : {0}", Perimeter(radius));

            Console.WriteLine("Area of Circle : {0}", Area(radius));
            Console.Read();

        }

        // Calculates the perimeter from provided radius
        internal static double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }

        // Calculates the area from provided radius
        internal static double Area(double radius)
        {
            return PI * radius * radius;
        }
    }
}
