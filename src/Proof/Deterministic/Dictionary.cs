using System.Collections.Generic;
using System.Linq;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.Dictionary
{
    public class Dictionary
    {
        // A dictionary is a collection of key-value pairs.
        // Each key is unique, and it is used to access the corresponding value.
        // Dictionaries are useful when you need to store data in a way that allows
        // you to quickly look up a value based on a key.
        //
        // Dictionaries have O(1) time complexity for adding, removing, and looking up elements.
        // This is because the address of each element is hashed into
        // memory directly, allowing constant time.
        //
        // Hashing is a process that takes an input and returns a fixed-size string of bytes.
        // The hashing process is "deterministic," meaning that the same input will always
        // return the same output.

        // If you are asked to find the most common character in a word (string),
        // you can use a dictionary to store the count of each character.
        // Then, you can find the character with the highest count.
        // This is a common interview question that tests your ability to use a dictionary.
        //
        // Detailed Example based on MostCommonCharacter:
        // Imagine you have the word "hello".
        // You create a dictionary to store the count of each character.
        // You iterate through the word, adding each character to the dictionary.
        // The dictionary would look like this: {'h': 1, 'e': 1, 'l': 2, 'o': 1}.
        // You then use this to find the character with the highest count, which is 'l'.

        public static (char character, int count) MostCommonCharacter(string input)
        {
            // Create a new dictionary to store the count of each character.
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Iterate through the input string.
            foreach (char c in input)
            {
                // If the character is already in the dictionary, increment the count.
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                // Otherwise, add the character to the dictionary with a count of 1.
                else
                {
                    charCount.Add(c, 1);
                }
            }

            // Find the character with the highest count.
            // The line below is a LINQ query that finds the character with the highest count.
            // Linq is an in-line query language that contains many useful functions.
            // In this case, we are using the Aggregate function to find the character with the highest count.
            // The Aggregate function takes a lambda function that compares two elements and returns the one with the higher count.
            char mostCommonChar = charCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            // Return the most common character and its count as a tuple data structure.
            return (mostCommonChar, charCount[mostCommonChar]);
        }
    }
}