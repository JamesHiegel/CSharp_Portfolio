// SOURCE: https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/
// AUTHORS: Mahesh Chand, C# Corner Founder, Author, International Speaker, and Startup Adviser.

// FILENAME: DictionaryDemo.cs
// PURPOSE: Demonstrate the basics of the Dictionary class.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 

// FUNCTIONAL MODIFICATIONS:

// The Dictionary type represents a collection of keys and values pair of data.
// The C# Dictionary class defined in the System.Collections.Generic namespace 
// is a generic class and can store any data types in a form of keys and values. 
// Each key must be unique in the collection.
using System;
using System.Collections.Generic;

namespace JJH
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating dictionary.");
            // Create a dictionary with string key and Int16 value pair    
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();

            // The Count property returns the number of items in the dictionary    
            Console.WriteLine("Count: {0}", AuthorList.Count);

            Console.WriteLine("\nAdding data.");
            // Adds key value pairs to the dictionary
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);

            Console.WriteLine("Count: {0}", AuthorList.Count);
            foreach (var author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }

            Console.WriteLine("\nUpdating Neel Beniwal to 9 and Mahesh Chand to 20.");

            // Updates an exisiting key value pair or adds a new key value pair
            AuthorList["Neel Beniwal"] = 9;

            // Uses the ContainsKey method to check if a key exists in the dictionary
            if (AuthorList.ContainsKey("Mahesh Chand"))
            {
                // updates an exisiting key value pair or adds a new key value pair
                AuthorList["Mahesh Chand"] = 20;
            }

            Console.WriteLine("Count: {0}", AuthorList.Count);
            DisplayDictionary(AuthorList);

            Console.WriteLine("\nSearching for an value 9.");

            // Uses the ContainsValue method to check if a value exists in the dictionary
            if (AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Value 9 found");
            }

            // The Remove method deletes a key value pair
            AuthorList.Remove("Mahesh Chand");

            Console.WriteLine("\nRemoved Mahesh Chand.");

            Console.WriteLine("Count: {0}", AuthorList.Count);
            DisplayDictionary(AuthorList);

            Console.WriteLine("\nClearing dictionary.");

            // The Clear method deletes the entire dictionary    
            AuthorList.Clear();
            Console.WriteLine("Count: {0}", AuthorList.Count);

        }

        // Helper method that iterates over Dictionary and displays contents
        private static void DisplayDictionary(Dictionary<string, short> AuthorList)
        {
            Console.WriteLine("Authors all items:");

            // foreach (KeyValuePair<string, Int16> author in AuthorList)
            // var can be used instead of specifying types
            foreach (var author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }
        }
    }
}
