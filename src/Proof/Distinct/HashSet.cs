using System.Collections.Generic;
using System.Linq;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.HashSet
{
    public class Hash
    {
        // A HashSet is a collection of unique elements.
        // It does not allow duplicates, which means
        // that it's useful for any situation where you 
        // need to ensure uniqueness in a collection.
        //
        // HashSets have O(1) time complexity for adding, removing, and looking up elements.
        // This is because the address of each element is hashed into
        // memory directly, allowing constant time.
        //
        // Hashing is a process that takes an input and returns a fixed-size string of bytes.
        // The hashing process is "deterministic," meaning that the same input will always
        // return the same output.

        // Unlike other examples, hashing is way beyond the scope of 
        // this project, and I would not be able to explain it anyway
        // so there is no detailed example in this file.
        // Suffice it to say, the most important thing about hashing
        // is that every input through a hashing algorithm will always
        // produce the same output. This is why a HashSet cannot have
        // duplicates, because adding the same thing twice would produce
        // the same hash. Another word for this relationship is "deterministic"
        // which is why that's a valuable keyword, although it's not used here.
        
        public static int[] RemoveDuplicates(int[] arr)
        {
            // Using a HashSet to remove duplicates is easy
            // because by their nature, HashSets do not allow duplicates.

            // Create a new integer HashSet.
            HashSet<int> hashSet = new HashSet<int>();

            // Iterate through the input array.
            foreach (int num in arr)
            {
                // Add each element to the HashSet.
                // If an element is already present, it will not be added.
                hashSet.Add(num);
            }

            // Convert the HashSet back to an array and return it.
            return hashSet.ToArray();
        }
    }
}