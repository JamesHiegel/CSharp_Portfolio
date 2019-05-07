// SOURCE: https://www.geeksforgeeks.org/caesar-cipher/
// AUTHORS: Ashutosh Kumar

// FILENAME: CeasarCipher.cs
// PURPOSE: Encrypt a string using a substitution cipher.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added method and code block comments describing what was occuring.
// Used white space to make code more readable.

// FUNCTIONAL MODIFICATIONS:
// Made minor tweaks in Main method to convert from Java to C#
// Added additional examples in Main Method
// Made major changes to Encrypt method to convert from Java to C#
// Changed for-loop in Encrypt method to foreach-loop, and adjusted contained code to suit 

// The Caesar Cipher technique is one of the earliest and simplest method of 
// encryption technique.It’s simply a type of substitution cipher, i.e., each 
// letter of a given text is replaced by a letter some fixed number of positions 
// down the alphabet. For example with a shift of 1, A would be replaced by B, 
// B would become C, and so on.The method is apparently named after Julius Caesar, 
// who apparently used it to communicate with his officials.
// Thus to cipher a given text we need an integer value, known as shift which 
// indicates the number of position each letter of the text has been moved down.
using System;
using System.Text;

namespace JJH
{
    class CeasarCipher
    {
        // The Main method run two example strings through the cipher
        public static void Main(string[] args)
        {
            // original string
            String text = "ATTACKATONCE";
            
            // cipher offset
            int s = 4;

            // displays original string, offset and then encrypted string
            Console.WriteLine("Text : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + Encrypt(text, s));

            // original string
            text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // cipher offset
            s = 4;

            // displays original string, offset and then encrypted string
            Console.WriteLine("\nText : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + Encrypt(text, s));

            // original string
            text = "abcdefghijklmnopqrstuvwxyz";

            // cipher offset
            s = 23;

            // displays original string, offset and then encrypted string
            Console.WriteLine("\nText : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + Encrypt(text, s));

            // original string
            text = "ItsATrap";

            // cipher offset
            s = 23;

            // displays original string, offset and then encrypted string
            Console.WriteLine("\nText : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + Encrypt(text, s));
        }

        // The Encrypt method shifts the letters of a provided string by the provided offset
        public static string Encrypt(String text, int s)
        {
            // StringBuilder object to hold converted characters
            var result = new StringBuilder();

            // iterates over each character in the string
            foreach (char i in text)
            {
                // adjusts character offset to change capitals to capitals
                if (Char.IsUpper(i))
                {
                    // calculates new character and then adds it to the end of the stringbuilder object
                    char ch = (char)(((int)i + s - 65) % 26 + 65);
                    result.Append(ch);
                }
                // otherwise adjusts character offset to change capitals to capitals
                else
                {
                    // calculates new character and then adds it to the end of the stringbuilder object
                    char ch = (char)(((int)i + s - 97) % 26 + 97);
                    result.Append(ch);
                }
            }
            // converts the stringbuilder object back into a string and returns it
            return result.ToString();
        }
    }
}