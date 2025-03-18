# Smallest (or Largest)

What are some situations you might want to know what is the largest or smallest number in a group? If you remember playing Halo LAN parties, first of all welcome, how's your back? Second of all, that's a case where being keeping an ordered, easy to update collection of player scores is critical for the immediate feedback as you figure out who's taken the lead. I'm by no means saying that's how Halo worked under the hood, that's just a contrived example.

## Heap

Heaps can be implemented in a variety of ways, but broadly speaking all must satisfy the **heap property**. This property dictates the relationship between a node's value and its child values. This is what ensures that the root node holds either the maximum or the minimum value. If you're wondering how this is true, and why a heap couldn't use a different paradigm then... it wouldn't be a heap, it would probably be a binary tree. If this is confusing, don't worry, this is just one of those things in programming where you have to take things not really on faith, but still at their word so that you can make short term progress until a point in the relative future when you need to know these specifics more deeply. That is a very common thing to do in programming by and large.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Heap in action.

```C#
			MinHeap heap = new MinHeap();
			
			Console.WriteLine("Add the following elements to the heap out of order: 5, 3, 17, 10, 84, 19, 6");
			
			heap.Add(5);
			heap.Add(3);
			heap.Add(17);
			heap.Add(10);
			heap.Add(84);
			heap.Add(19);
			heap.Add(6);

			Console.WriteLine("The heap should be ordered as follows: 3, 5, 6, 10, 84, 19, 17");
			Console.WriteLine("The heap is ordered as follows and fetched with the Getheap() method: " + string.Join(", ", heap.GetHeap()));
```