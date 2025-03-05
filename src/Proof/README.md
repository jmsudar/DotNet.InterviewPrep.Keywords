# What are the Keywords?

This document goes through several interviewing keywords. It talks about why each key word means what it does, and then talks about what solution you should choose based on some additional conditions. Finally, it includes some code blocks that you can copy to `Runtime.cs` to see the proven solutions in action.

### Complexity Classes

As a quick aside, I will occasionally reference **complexity classes**. This is a shorthand used by programmers to discuss the complexity of a solution. Complexity, in this case refers to the _time and the memory_ a solution requires. This will seem random, and possibly even confusing, but it's important for you to try and understand these classes, because they are common language from one solution to the next, and as such help programmers to understand one another. You may not be asked about complexity during an interview, but knowing it will deepen your understanding and make you better able to handle questions.

Complexity is most common shared in **big O notation**. That looks something like `O(N)`. `N` in all cases refers to the tightest bottleneck in the code. `O(N)` is called linear complexity, and means that your algorithm does an operation N times. Have 100 items? It happens 100 times. Have 1,000 items? It happens 1,000 times. Have 1,000,000,000,000 items? Your code probably isn't going to finish running. That seems like a ridiculous example, but it's not. Keep in mind that a Terrabyte means one trillion bytes. Numbers of this size exist in a very real way in computing.

## How to use this documentation

I am a big advocate of two things when it comes to code documentation:

1. Docs should live as close to code as possible.
2. Docs, whenever possible, should be living documents.

When I say living documentation, I mean that it's interactive or has some utility beyond just something you refer to. As such, there are three tiers of documentation in this directory:

1. `./Proof/README.md`: The doc you are currently reading. This contains a high level of each keyword covered within the `Proof/` directory, as well as quick links to important code files.
2. `./Proof/<keyword>/README.md`: Each subdirectory is named after a given keyword, and contains code files that relate to solutions for the keyword, but they also contain a top-level `README.md`. These READMEs contain deep dive explanations of each keyword, as well as copy-pasta for trying each example, plus links to different proofs.
2. `./Proof/<keyword>/<solution>.cs`: Each solution for a given keyword serves, itself, as documentation, and indeed as the deepest and most important documentation to review. In each case, there are heavy, heavy code comments, way heavier than you should ever use in production code. The idea is that you can read about each solution as though you have someone walking you through it. These solutions are the meat and potatoes of this repo, and what you should focus most on in order to understand why each solution works for each keyword.

## Table of Contents

### Deterministic

Something is deterministic in computing if the same input will always equal the same output. This is most commonly used to refer to hashing, with the most common implementation in coding interviews relating to hash tables, also known as dictionaries, hashmaps, or maps.

[README.md](/src/Proof/Deterministic/README.md)

[Dictionary](/src/Proof/Deterministic/Dictionary.cs)

### Distinct

Distinct here refers to a collection of things with no repeats. Another common term is deduplication, or "de-duping." Problems referring to finding the distinct items will typically ask you to find all the unique elements in a collection.

[README.md](/src/Proof/Distinct/README.md)

[HashSet](/src/Proof/Distinct/HashSet.cs)

### Fibonacci

The Fibonacci sequence is a mathematical concept in which a number is equal to the sum of the numbers preceding it. This is a more direct clue than most keywords in this repo, but it's germane because Fibonacci questions are common due to the neat and tidy mathematical expression of Fibonacci as `F(N) = F(N - 1) + F(N - 1)`, as this sort of proof is red meat for algorithmic thinking.

[README.md](/src/Proof/Fibonacci/README.md)

[Fibonacci](/src/Proof/Fibonacci/Fibonacci.cs)

### Pointers

Generally speaking, if you are asked about a solution about efficiently assing or removing elements, each element knows its neighbors, or the word **pointers** is used to refer to the relationship one element has to another, you are probably being asked about a linked list.

[README.md](/src/Proof/Pointers/README.md)

[Linked List](/src/Proof/Pointers/LinkedList.cs)


### Prefix

Prefix questions are usually phrased as "how many prefixes of a word are themselves valid words" or similar, and require using data structure that are well-suited to text parsing and traversal.

[README.md](/src/Proof/Prefix/README.md)

[Trie](/src/Proof/Prefix/Trie.cs)

### Sorted

This is actually the word that inspired me to build this repo: when doing programming problems with a friend, I stammered on a problem and he blazed right into it, because he recognized the word, "sorted" as suggesting he start with binary search as a solution.

[README.md](/src/Proof/Sorted/README.md)

[BinarySearch](/src/Proof/Sorted/BinarySearch.cs)