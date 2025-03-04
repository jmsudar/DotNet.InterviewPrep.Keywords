# Prefix

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