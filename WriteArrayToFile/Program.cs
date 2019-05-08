// https://www.w3resource.com/csharp-exercises/file-handling/csharp-file-handling-exercise-6.php
using System;
using System.IO;


class WriteTextFile
{
    static void Main()
    {
        string fileName = @"mytest.txt";
        string[] ArrLines;
        int n, i;

        Console.Write("\n\n Create a file and write an array of strings  :\n");
        Console.Write("---------------------------------------------------\n");

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }

        Console.Write(" Input number of lines to write in the file  :");
        n = Convert.ToInt32(Console.ReadLine());
        ArrLines = new string[n];
        Console.Write(" Input {0} strings below :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write(" Input line {0} : ", i + 1);
            ArrLines[i] = Console.ReadLine();
        }
        System.IO.File.WriteAllLines(fileName, ArrLines);

        using (StreamReader sr = File.OpenText(fileName))
        {
            string s = "";
            Console.Write("\n The content of the file is  :\n", n);
            Console.Write("----------------------------------\n");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(" {0} ", s);
            }
            Console.WriteLine();
        }
    }
}
