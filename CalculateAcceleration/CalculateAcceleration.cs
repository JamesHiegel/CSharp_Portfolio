// SOURCE: https://www.sanfoundry.com/csharp-program-acceleration/
// AUTHOR: Sanfoundry
// FILENAME: CalculateAcceleration.cs
// PURPOSE: C# Program to Calculate Acceleration.
// STUDENT: James Hiegel
// DATE: 19 April 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be self labeling

// C# Program to Calculate Acceleration.
using System;

namespace JJH
{
    public class CalculateAcceleration
    {
        static void Main(string[] args)
        {
            // collects velocity from user
            int velocity, time, accel;
            Console.WriteLine("Enter the Velocity : ");
            velocity = int.Parse(Console.ReadLine());

            // collects time from user
            Console.WriteLine("Enter the Time : ");
            time = int.Parse(Console.ReadLine());

            // calculates and outputs acceleration
            accel = velocity / time;
            Console.WriteLine("Acceleration : {0}", accel);
        }
    }
}