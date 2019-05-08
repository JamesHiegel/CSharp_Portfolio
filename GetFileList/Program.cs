/*
 * C# Program to List the Files in a Directory
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] array1 = Directory.GetFiles(@"D:\");
        Console.WriteLine("Files in the Directory");
        foreach (string name in array1)
        {
            Console.WriteLine(name);
        }
        Console.Read();
    }
}