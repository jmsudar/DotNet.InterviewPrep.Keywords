# Sort

It's really not that hard to think about how you might sort something. You've probably done it yourself: dump all your Legos out onto a table and start putting together the ones that are alike. What you're probably doing here is a brute force sort, where you go one at a time and look at everything. That works great for Legos (at least for just a few of them) but if you were dealing with the quantities of items you deal with in computer science, it would quickly get untenable. Because of this, sorting algorithms are a must.

## QuickSort

Let's say that instead of diving into the entire stack of Legos you instead decide to grab an arbitrary chunk of them and divide the pile roughly in half, then work on the smaller half. This is more or less how a quicksort works. Quicksort has an element of randomness to it, where it takes an approximate stab at where to pivot and start sorting. This in most cases works out just fine, however it is possible that you could wind up basically handling every item multiple times. This means that in the average case, you have the complexity `O(N log N)`, which means you logarithmically divide the work then do some linear processing on it, but in the worst case where a bad pivot is chosen, you have `O(N^2)`, exponential time.

Is that risk acceptable? Maybe! It depends on your needs. But enough cases exist where it is acceptable to make quicksort a classic interviewing problem. 

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a QuickSort in action.

```C#
			int[] arr = { 10, 7, 8, 9, 1, 5, 3, 4, 2, 6, 0, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
			Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			QuickSort.RecursiveQuickSort(arr, 0, arr.Length - 1);
			stopwatch.Stop();
			Console.WriteLine("Sorted array: " + string.Join(", ", arr));
			Console.WriteLine("Time elapsed: " + stopwatch.ElapsedTicks + " ticks");
			Console.WriteLine("Due to the nature of quicksort, you might get different");
			Console.WriteLine("time elapsed each time you run this program. Try it!");
```