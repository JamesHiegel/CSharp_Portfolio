//https://www.geeksforgeeks.org/c-sharp-params/

// C# program to illustrate the 
// use of params keyword 
using System;
namespace Examples
{

    class Geeks
    {

        // function containing params parameters 
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop 
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }

        // Driver Code	 
        static void Main(string[] args)
        {

            // Calling function by passing 5 
            // arguments as follows 
            int y = Add(12, 13, 10, 15, 56);

            // Displaying result 
            Console.WriteLine(y);
        }
    }
}
