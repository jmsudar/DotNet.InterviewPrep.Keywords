using System.Collections.Generic;

namespace InterviewPrep.Keywords.Proof.Trie
{
    public class Trie
    {
        // The first thing of note here, compared to other examples, is that 
        // the class, Trie, has more than just algorithmic methods. It also has
        // it also has nested classes (TrieNode), fields like _root, and 
        // a constructor. This is because a trie is a data structure, not just
        // an algorithm, and it needs to be able to store data and be initialized.
        //
        // I'm leaving off a detailed explanation for right now because it made
        // more sense and wrote more naturally to put the detailed explanations in
        // the methods where they fit. At a bird's eye level, the important thing
        // to understand right now is that a trie is tree-like in its "shape," and
        // this is useful for storing and searching for words by making a logical
        // progression, one letter at a time, through the list of words that the 
        // trie stores. 

        /// <summary>
        /// A node in the trie.
        /// </summary>
        private class TrieNode
        {
            // Children are stored as a dictionary to allow for O(1) lookup time.
            // This is critical as fast searching is a hallmark of tries.
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
            
            // IsWord is a boolean flag that indicates whether the node represents a word.
            public bool IsWord = false;
        }

        // We need to start with a root node for the trie.
        private readonly TrieNode _root;

        // This is what's called a constructor, and is called
        // when an object is created. In this case, it initializes
        // the root node of the trie.
        public Trie()
        {
            // This initializes the _root node, which is internal to this
            // data structure. This controls how the node can be accessed
            // and is common for keeping data secure.
            _root = new TrieNode();
        }

        /// <summary>
        /// Inserts a word into the trie.
        /// </summary>
        /// <param name="word">The word being inserted</param>
        public void Insert(string word)
        {
            // Start at the root node.
            var node = _root;

            // Iterate over every character in the word to check
            foreach (var c in word)
            {
                // If the character is not already in the trie, add it.
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }

                // Move to the next node.
                node = node.Children[c];
            }

            // As you can see above, you start at the root, but you move to
            // the next node after each character. If you were inserting a 
            // word like "butter", you would start at the root, then add b,
            // move to the b node, add u, move to the u node, and so on.
            // This creates a structure like b => u => t => t => e => r, and
            // this chain is how the trie stores the word. If you then added
            // something like "buckwheat," the first two nodes, b and u, would be
            // reused. This is why tries are efficient for autocomplete, because
            // they do not repeat common prefixes.

            // Once you've added all the characters, you set the IsWord flag to true.
            node.IsWord = true;
        }

        /// <summary>
        /// Gets the node that represents the given word.
        /// </summary>
        /// <param name="word">The word you're searching for</param>
        /// <returns>A TrieNode if the word is found, otherwise null</returns>
        private TrieNode? GetNode(string word)
        {
            // Just like when inserting a word, start at the root.
            var node = _root;

            // Iterate over every character in the word.
            foreach (var c in word)
            {
                // If the character is not in the trie, return null.
                // This means there's no entry for the word in the trie.
                if (!node.Children.ContainsKey(c))
                {
                    return null;
                }

                // If you've found a valid character, move to the next node.
                node = node.Children[c];
            }

            // Think about this in the context of example above with butter and 
            // buckwheat. If you were placing an online grocery order in a system
            // that uses this trie, you might start searching for butter and type in
            // one letter at a time, so b, u, t, and every time you type and there's
            // a new entry in the search box, the system is using GetNode to see if 
            // it can continue the search. If you decide you need bundt cake, the
            // search would cut off when you typed in b, u, n, because there's no
            // node for n in the trie.
            //
            // Note: the example above is a little contrived, since what you'd be
            // doing there is asynchronous programming most likely, as the computer
            // waits for user input at each step, but all the same principles apply.

            // If you've found all the characters, return the node.
            return node;
        }

        /// <summary>
        /// Searches for a word in the trie.
        /// </summary>
        /// <param name="word">The word being searched for</param>
        /// <returns>True if the word is in the trie, false otherwise</returns>
        public bool Search(string word)
        {
            // Get the node for the word.
            TrieNode ?node = GetNode(word);

            // If the node is null, the word is not in the trie.
            // Similarly, check if the node is a word.
            return node != null && node.IsWord;
        }

        /// <summary>
        /// Checks if the trie contains a word with the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix to search for</param>
        /// <returns>The TrieNode with the given prefix, if it's present</returns>
        public bool StartsWith(string prefix)
        {
            // Get the node for the given prefix and assess if it exists.
            return GetNode(prefix) != null;
        }
    }
}