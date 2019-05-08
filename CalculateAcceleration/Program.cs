// SOURCE: https://www.sanfoundry.com/csharp-program-atm-transaction/
// AUTHOR: Sanfoundry
// FILENAME: CalculateAcceleration.cs
// PURPOSE: C# Program to Calculate Acceleration.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;
class program
{
    static void Main(string[] args)
    {
        int v, t, acc;
        Console.WriteLine("Enter the Velocity : ");
        v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Time : ");
        t = int.Parse(Console.ReadLine());
        acc = v / t;
        Console.WriteLine("Acceleration : {0}", acc);
    }
}