# Pointers

A pointer refers to a piece of computer memory. I don't want to get too into the weeds here, mostly because I would struggle to explain it well, but memory in computers is very fast if you know exactly what you're looking for. That's what a pointer does, tells you exactly where to look for something.

## Linked List

Pointers matter in reference to linked lists, because linked lists are special for a couple of reasons:

1. They do not have fixed size, unlike arrays, so if you have a question about a data structure with frequent resizing, you might think about linked lists for the solution.
2. They consist of nodes, and each node knows the direct address, via pointers, to the next node in the line. This means they are pretty quick moving from one point to another, but also have `O(N)` complexity for list traversal, as you have to sequentially move from node to node.

As for why this is so important, it's just as important to remember as you learn computer science that you are doing things, especially very early on, at a very high level. This means there is a lot happening under the hood that you may not understand. Linked lists are definitely part of that abstraction, with many friendlier data structures using them in some way or another. In fact, the Queue and Stack examples in this very repo rely on this linked list implementation!

[Link to LinkedList.cs](/src/Proof/Pointers/LinkedList.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Linked List in action.

```C#
			Console.WriteLine("Initializing integer linked list with values 1, 2, 3, 4, 5");

			// Linked list
			LinkedList<int> linkedList = new LinkedList<int>();
			
			linkedList.Add(1);
			linkedList.Add(2);
			linkedList.Add(3);
			linkedList.Add(4);
			linkedList.Add(5);

			Console.WriteLine("Linked List:");
			Console.WriteLine("Head value: " + linkedList.Head?.Value);
			Console.WriteLine("Tail value: " + linkedList.Tail?.Value);
			Console.WriteLine("Next value known by Head: " + linkedList.Head?.Next?.Value);
```