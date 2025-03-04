# Fibonacci

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

### Fibonacci - Recursive with Memoization

Solving the Fibonacci sequence with recursion get impractical very quickly, because the complexity class is exponential, aka O(2^N). That is anathema in programming because it invariably means retrodding the same ground multiple times, when the whole point of computers is to save effort and find efficiency. Exponential complexity becomes untenable almost immediately. The work doubles at every step, so even something like N=30 is going to take forever to process.

To solve this, the solution is to store the work that's already been done in some way. This storage is referred to as **memoization**.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see the memoized recursive Fibonacci sequence in action.

```C#
			Console.WriteLine("Comparing runtimes for recursive Fibonacci with and without memoization");

			Stopwatch _stopwatch = new Stopwatch();
			_stopwatch.Start();
			int recusiveResult = Fibonacci.FibonacciRecursive(40);
			_stopwatch.Stop();
			Console.WriteLine($"Recursive Fibonacci without memoization: {recusiveResult} in {_stopwatch.ElapsedMilliseconds}ms");

			_stopwatch.Reset();
			_stopwatch.Start();
			int memoizedResult = Fibonacci.FibonacciRecursiveWithMemoization(40);
			_stopwatch.Stop();
			Console.WriteLine($"Recursive Fibonacci with memoization: {memoizedResult} in {_stopwatch.ElapsedMilliseconds}ms");
```