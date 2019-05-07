// SOURCE: https://www.codeproject.com/Articles/11157/An-improvement-on-capturing-similarity-between-str
// AUTHOR: Thanh Dao
// FILENAME: StringSimilarity.cs
// PURPOSE: Tokenizes and compares two strings returning a similarity degree in the range of 0-1.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:

using System;

namespace JJH
{
    public class StringSimilarity
    {
        public static void Main(string[] args)
        {
            string s1 = "The code project's article";
            string s2 = "The code project's article";
            Console.WriteLine("Let's compare two identical strings:\n{0}\n{1}\n", s1, s2);

            // call the GetSimilarity method and,
            // output the similarity score
            Console.WriteLine("Score is: {0}\n", GetSimilarity(s1, s2));

            s1 = "The code project's article";
            s2 = "Article of The CodeProject";
            Console.WriteLine("Let's compare two similar but different strings:\n{0}\n{1}\n", s1, s2);

            // call the GetSimilarity method and,
            // output the similarity score
            Console.WriteLine("Score is: {0}\n", GetSimilarity(s1, s2));
        }

        // The GetSimilarity method returns a float value in the range 0-1,
        // indicating how similar two strings are
        internal static float GetSimilarity(string string1, string string2)
        {
            // calls the ComputeDistance method
            float dis = ComputeDistance(string1, string2);
            float maxLen = string1.Length;
            if (maxLen < string2.Length)
                maxLen = string2.Length;
            if (maxLen == 0.0F)
                return 1.0F;
            else
                return 1.0F - dis / maxLen;
        }

        // The ComputeDistance method...
        internal static int ComputeDistance(string s, string t)
        {
            // obtains lengths of provided strings
            int n = s.Length;
            int m = t.Length;

            // creates a two dimensional array, i.e. a matrix
            int[,] distance = new int[n + 1, m + 1];

            int cost = 0;

            // if the length of either string is zero, 
            // then the distance is zero
            if (n == 0) return m;
            if (m == 0) return n;
            
            // fills distance matrix
            for (int i = 0; i <= n; distance[i, 0] = i++) ;
            for (int j = 0; j <= m; distance[0, j] = j++) ;

            // iterates length of first string
            for (int i = 1; i <= n; i++)
            {
                // iterates length of second string
                for (int j = 1; j <= m; j++)
                {
                    // finds min distance
                    cost = (t.Substring(j - 1, 1) == s.Substring(i - 1, 1) ? 0 : 1);
                    distance[i, j] = Min3(distance[i - 1, j] + 1,
                    distance[i, j - 1] + 1,
                    distance[i - 1, j - 1] + cost);
                }
            }
            return distance[n, m];
        }

        // The Min3 method is a helper method that returns the minimum of three integers
        internal static int Min3(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
