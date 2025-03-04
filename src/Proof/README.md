# What are the Keywords?

This document goes through several interviewing keywords. It talks about why each key word means what it does, and then talks about what solution you should choose based on some additional conditions. Finally, it includes some code blocks that you can copy to `Runtime.cs` to see the proven solutions in action.

### Complexity Classes

As a quick aside, I will occasionally reference **complexity classes**. This is a shorthand used by programmers to discuss the complexity of a solution. Complexity, in this case refers to the _time and the memory_ a solution requires. This will seem random, and possibly even confusing, but it's important for you to try and understand these classes, because they are common language from one solution to the next, and as such help programmers to understand one another. You may not be asked about complexity during an interview, but knowing it will deepen your understanding and make you better able to handle questions.

Complexity is most common shared in **big o notation**. That looks something like `O(N)`. `N` in all cases refers to the tightest bottleneck in the code. `O(N)` is called linear complexity, and means that your algorithm does an operation N times. Have 100 items? It happens 100 times. Have 1,000 items? It happens 1,000 times. Have 1,000,000,000,000 items? Your code probably isn't going to finish running. That seems like a ridiculous example, but it's not. Keep in mind that a Terrabyte means one trillion bytes. Numbers of this size exist in a very real way in computing.

## Deterministic

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

## Distinct

Finding or creating a distinct collection of items is part and parcel of computer engineering. If you think for a moment about passwords, you want to make sure that you don't allow multiple passwords for the same login, for example. So how do you achieve distinctness? Doing something like iterating over an array and checking its contents would be terrible as it would have O(N) complexity, growing with your usercount. That would be the kiss of death for something like Facebook.

### HashSet

I'm jumping straight into the HashSet (aka Set, aka HashTable) because it's by far the most common way to de-dupe something. HashSets are unique for a couple of features:
- They do not allow duplicates
- Every values location is "hashed" in memory, which means lookup time is constant (O(1))
- They are unordered

Simply turning an array into a HashSet is enough to remove duplicates from the array. And in fact, that's exactly what you'll do in the HashSet practice problem!

[Link to HashSet](/src/Proof/Distinct/HashSet.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a HashSet sequence in action.

```C#
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
			Console.WriteLine("Original Array: " + string.Join(", ", arr));
			int[] uniqueArr = Hash.RemoveDuplicates(arr);
			Console.WriteLine("Unique Array: " + string.Join(", ", uniqueArr));
```

## Fibonacci

This one is a little trickier to generalize, because it's not actually a keyword so much as an implicit instruction. AKA, you may be asked to solve the Fibonacci sequence. If you're unaware, the Fibonacci sequence is a sequence wherein every next number is the sum of the two numbers preceding it. So 0, 1, 1, 2, 3, 5, 8, 13, 21, and so on. As for when you'll use this in a programming job? Probably never. But it has a tidy mathematic proof, which means it's useful for algorithmic thinking. Broadly speaking, there are two common implementations of the Fibonacci sequence you might see in an interview: iteratively and recursively.

[Link to Fibonacci](/src/Proof/Fibonacci/Fibonacci.cs)

### Fibonacci - Iterative

**Iterative** means that you iterate over, basically, touch, each item in a collection. So an iterative solution moves over every item and does something with it. Because of this, it is complexity `O(N)`. However, since arithmetic is such a simple thing to do for a computer, and iterative solution to the Fibonacci sequence is still generally preferred.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see the iterative Fibonacci sequence in action.

```C#
			int n = 10;
			Console.WriteLine("Finding the " + n + "th Fibonacci number iteratively");
			int fib = Fibonacci.FibonacciIterative(n);
			Console.WriteLine($"Fibonacci: {fib}");
```

### Fibonacci - Recursive

**Recursion** means that a formula calls itself. Well why on earth would you want to do that? First off, if you know what you're looking at, it can be a lot cleaner. Recursive solutions tend to be pretty clean in terms of how much code space they take up, since you'll have a single block that will call itself as many times as it needs to. If that's confusing, go take a look at `Fibonacci.cs` and it will hopefully make more sense. The problem with recursive solutions is they can be difficult to understand for junior developers, and if you don't adequately set your floor case, you can wind up with something leaky that crashes your app.

Additionally, in the case of the Fibonacci sequence, its complexity isn't great without **memoization**. All the same, I've seen this one as a whiteboarding problem because it demonstrates good knowledge of principles, so I'd recommend learning it.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see the recursive Fibonacci sequence in action.

```C#
			int n = 10;
			Console.WriteLine("Finding the " + n + "th Fibonacci number recursively");
			int fib = Fibonacci.FibonacciRecursive(n);
			Console.WriteLine("The " + n + "th Fibonacci number is " + fib);
```

## Prefix

Sort of like Fibonacci, this is one of those things where you're likely to be asked a fairly specific question instead of something general that you then connect with a larger idea. In terms of programming problems, you might be asked "given word foo, how can you tell what prefixes make up the beginning of foo?" If that sounds wonky, welcome to computer science, but in reality this is valuable. Thank about autocomplete, one of those nice responsive boxes you type into that shows you what options you can choose that are supported. There can be many, many options available with something like this, so you want to be sure and write something efficient to parse them. Well, parsing a portion of what someone has written means you're doing a lot of prefix handling!

### Trie

Tries, pronounced tree, unhelpfully, are also known as prefix trees. Writing this, I realize I haven't written what trees are yet, so boo on me for forgetting that, I'll do it next. In the meantime, you can think of a tree data structure as a series of branching nodes. Each node is a value in the data structure, and it forks hither and yon to lead to the next nodes. Why? Because it's a valuable, and if done correctly, effient, way to visualize connections in data.

It's valuable to think of trees as prefix trees, both because of the name of this section, and because it explains well what they do in the context of autocomplete. If you think about how an autocomplete flow might work, you start typing something into the search box of the movie location terminal at your local Blockbuster (just go with it). You're looking for an action movie, so you start typing, U and get options like

```
U-571
Under Siege
Under Siege 2: Trains this time
Up
...
```

What's happening is the program is trying to figure out what you're going to type next. You can think of this as a prefix tree, with the first node being U, and every branch leading to a possible next letter in the alphabet. You follow U with N, and your searches are winnowed down

```
Under Siege
Under Siege 2: Trains This Time
...
```

You've locked yourself into Stephen Seagal movies, god help you. But importantly, in terms of trie traversal, you've gone from U, to N, and it's up to you to pick the next letter to winnow down your search. Generally speaking, this has good complexity, with O(N), aka linear time, aka it will take as long as the word you're searching for is long. That is good time complexity, though space complexity if you have many, many words to store, could be tough.

[Link to Trie](/src/Proof/Prefix/Trie.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Trie in action.

```C#
			Console.WriteLine("Storing the following words: hello, world, trie, tree, try");
			Trie trie = new Trie();
			trie.Insert("hello");
			trie.Insert("world");
			trie.Insert("trie");
			trie.Insert("tree");
			trie.Insert("try");
			Console.WriteLine("Searching for the word 'trie'");
			Console.WriteLine(trie.Search("trie"));
			Console.WriteLine("Searching for the word 'try'");
			Console.WriteLine(trie.Search("try"));
			Console.WriteLine("Searching for the word 'hello'");
			Console.WriteLine(trie.Search("hello"));
			Console.WriteLine("Searching for the word 'hella'");
			Console.WriteLine(trie.Search("hella"));
```

## Sorted

**Sorted**, in this case, is referring to a collection, like an array of values. Arrays by their nature to not store a sorted collection, so if your interviewer tells you they want you to find something in a sorted array, they are likely giving you a hint.

Think of it with this example: if you were given a stack of resumés and told to find someone's, you'd right away want to know if they were in order by last name. If they weren't, you'd have to leaf through every single resumé. This is `O(N)` complexity, because you have to touch every single resumé until you find the right one. If your boss gives you 10,000 resumés, I hope you didn't have any weekend plans.

But let's say the stack of resumés is sorted alphabetically. If you're asked to find Snake Plissken's resumé, you know it's going to be somewhere in the second half, with P coming after M. So you'll probably want to start halfway through the stack of resumés, seeing where you land, and then determining if you overshot or if you need to go bigger. If you apply this again, dividing your work once again in half, you can quickly find Snake's resumé.

This is a real world example of a very common algorithm called **binary search**. _If you are in an interview and your interviewer says they want you to find something in a sorted array, binary search is the best place to start_.

### Binary Search

Binary search divides the work in half at each step. It starts by finding the middle of the work, then determining if what it's looking for is smaller or bigger than where it is, just like in the example with the stack of resumés. This is why it will only work with a sorted collection: if you tried to divide the resumés in half when they were random, you're just guessing every time instead of intelligently reducing the work you have to do. This is called a **brute force** solution, and it is nearly always the worst thing to do.

Because it divides the work at each step, binary search is `O(log N)`, or **logarithmic** in its complexity. A logarithm is the inverse of an exponent, aka "2 to the power N." Because it divides the work in half at each step, it can even handle searching trillions of values with relative ease. This is both important to understand for your edification as a programmer, and why this is the first keyword expanded on in this project.

[Link to BinarySearch.cs](/src/Proof/Sorted/BinarySearch.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a binary search in action.

```C#
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int target = 16;

            Console.WriteLine("Binary Search Proof");
            Console.WriteLine("Array: " + string.Join(", ", arr));
            Console.WriteLine("Target: " + target);

            int index = BinarySearch.IterativelyFindIndexOfTarget(arr, target);

            if (index != -1)
            {
                Console.WriteLine($"The target {target} was found at index {index}");
            }
            else
            {
                Console.WriteLine($"The target {target} was not found in the array");
            }
```