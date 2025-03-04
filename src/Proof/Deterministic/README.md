# Deterministic

Deterministic is actually a philosophical term, and a grim one at that, relating to causality and the idea that everything happens as it does, so why bother changing anything? Bleh.

In computer science, however, this is taken to mean that through a **hashing algorithm**, the same input will always produce the same output. Why does this matter? In broad terms, it matters because hashing algorithms are very fast, much faster than, say, comparing two words to one another and checking that each letter is the same. Let's say the words are 1,000 characters long, but a hashing algorithm always, always parses this down to not just a 24 character string of letters, but to the exact same 24 character string. Would you rather compare the 1,000 character words, or the 24 character ones, knowing with total confidence that the same 1,000 character word will produce the same 24 character one? This is at the heart of why hashing is useful. It's abstract, and the hashing algorithms themselves are very complicated, but unless you have a very long beard and stopped playing chess because you couldn't stop winning, you don't need to worry about the hashing algorithms themselves.

### Dictionary

Some of the most important application of determinism and hashing comes from dictionaries. Dictionaries are among the most important computer science data structures to know about. Unlike some things this repo touches on, such as linked lists, which you may never use, you will almost certainly use a dictionary at some point. If you think about how a linguistic dictionary works, you have an organized structure of all the words in whatever language you're reading, followed by their definitions. In a linquistic dictionary, the word is the **key**, and its definition is the **value**.

In computer science, that's the root of what a dictionary is: a **key value pair**. Every key is unique, meaning you can't have two entries with the same key, and every value can be retrieved using the key. Why does that matter? A couple reasons: the most important one is that, through the magic of computers, it always take the exact same amount of time to get a value using its key, regardless of how big your dictionary is. That's useful in all sorts of things, since your piece of software will likely spend lots and lots of time doing something like manipulating a piece of data every time it comes up; being able to get said data in exactly the same, very short amount of time, will help you have a good piece of software.

[Link to Dictionary](/src/Proof/Deterministic/Dictionary.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Dictionary in action.

```C#
			string input = "supercalifragilisticexpialidocious";
			(char character, int count) = Dictionary.MostCommonCharacter(input);
			Console.WriteLine($"The most common character in \"{input}\" is '{character}' with a count of {count}");
```