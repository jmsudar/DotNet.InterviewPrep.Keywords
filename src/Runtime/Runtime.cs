using System;
using System.Diagnostics;
using jmsudar.DotNet.InterviewPrep.Keywords.Practice;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.BinarySearch;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.Dictionary;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.HashSet;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.Fibonacci;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.LinkedList;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.Queue;
using jmsudar.DotNet.InterviewPrep.Keywords.Proof.Trie;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Runtime
{
	class Runtime
	{
		static void Main(string[] args)
		{
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
		}
	}
}
