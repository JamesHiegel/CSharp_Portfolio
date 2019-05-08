// SOURCE: https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-3.php
// AUTHOR: W3 Resource
// FILENAME: PasswordChecker.cs
// PURPOSE: C# program to take userid and password. After three wrong attempts, user will be rejected.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be clearer on what they are.
// Moved defaults username and password to variable declaration and substituted variable name throughout code
// Changes successful login variable type from int to bool

using System;

namespace JJH
{
    public class PasswordChecker
    {
        public static void Main()
        {
            string username = "",
                password = "";
            string defaultUsername = "username",
                defaultPassword = "password";
            int attempts = 0;
            bool successfulLogin = false;

            // requests username and password
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default username and password is : username and password\n");
            Console.Write("---------------------------------\n");

            // do-while loop continues until correct login information is entered,
            // or if three failed attempts occur
            do
            {
                // requests username
                Console.Write("Input a username: ");
                username = Console.ReadLine();
                
                // requests password
                Console.Write("Input a password: ");
                password = Console.ReadLine();

                // checks if both parts of login information is correct
                if (username == defaultUsername && password == defaultPassword)
                {
                    // valid credentials
                    successfulLogin = true;
                    attempts = 3;
                }
                else
                {
                    // invalid credentials
                    // increments number of attempts
                    successfulLogin = false;
                    attempts++;
                }
            }
            while ((username != defaultUsername || password != defaultPassword)
                    && (attempts != 3));
            
            // valid login message
            if (!successfulLogin)
            {
                Console.Write("\nLogin attempted more than three times. Try later!\n\n");
            }
            // invalid login message
            else if (successfulLogin)
            {
                Console.Write("\nPassword entered successfully!\n\n");
            }
        }
    }
}