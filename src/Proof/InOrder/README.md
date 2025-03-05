# In Order

Computers process things in order nonstop. It's kind of the number one thing they do, take instructions and execute them sequentially to make something happen. However that's not always the case, and indeed in the age of the internet, asynchronous processing is having a heyday. So since you can't say "um... all of computers?" if an interviewer asks you how you would ensure a collection of data is processed in order, you should consider using a queue.

## Queue

If you're American, the term "queue" may not be as familiar to you as if you're British. If I say "wait in line" though you'll understand exactly what I mean. That's exactly how you should think of a queue as a data structure. Another way queues are presented is **FIFO**, which is an acronym that means **first in, first out**. That means that the queue must maintain some idea of what is the order of its elements.

But how do you do that efficiently? If you have an explicit idea of where everything is, you have a HashSet not a queue. So a queue must have some way of knowing what comes next, as that's the only way you can preserve order without just holding everything in its place. Well, if you haven't stepped over to the section on [Pointers](/src/Proof/Pointers/README.md) yet, you should, because the linked list in that section will underly what we use to make our queue!

As a side effect of this, we are experiencing a concept not really unique to computers, but very important to understand computer science as a field: **layers of abstraction**. You didn't write git, or GitHub, you didn't create the C# language, C, or the assembly language underneath that. But all this stuff works. How? Because of the collaborative nature of computer science, and the fact that someone else did the work with the idea that someone in the future, you in this case, might want to use it! Because we've already written the code for the linked list, we can reuse it, relying on that layer of abstraction to provide verified behavior for our queue. This may be a head scratcher right now, but trust me: it is part and parcel of computer science.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Queue in action.

```C#
			// Queue
			Queue<int> queue = new Queue<int>();

			Console.WriteLine("Entering 1, 2, 3, 4, 5 into an integer queue");
			
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);

			Console.WriteLine("Dequeuing each item from the queue while isEmpty() == false");

			while (queue.IsEmpty() == false)
			{
				Console.WriteLine(queue.Dequeue());
			}

			Console.WriteLine("The queue is now empty!");
```