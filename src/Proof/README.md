# What are the Keywords?

This document goes through several interviewing keywords. It talks about why each key word means what it does, and then talks about what solution you should choose based on some additional conditions. Finally, it includes some code blocks that you can copy to `Runtime.cs` to see the proven solutions in action.

### Complexity Classes

As a quick aside, I will occasionally reference **complexity classes**. This is a shorthand used by programmers to discuss the complexity of a solution. Complexity, in this case refers to the _time and the memory_ a solution requires. This will seem random, and possibly even confusing, but it's important for you to try and understand these classes, because they are common language from one solution to the next, and as such help programmers to understand one another. You may not be asked about complexity during an interview, but knowing it will deepen your understanding and make you better able to handle questions.

Complexity is most common shared in **big o notation**. That looks something like `O(N)`. `N` in all cases refers to the tightest bottleneck in the code. `O(N)` is called linear complexity, and means that your algorithm does an operation N times. Have 100 items? It happens 100 times. Have 1,000 items? It happens 1,000 times. Have 1,000,000,000,000 items? Your code probably isn't going to finish running. That seems like a ridiculous example, but it's not. Keep in mind that a Terrabyte means one trillion bytes. Numbers of this size exist in a very real way in computing.

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

## Fibonacci

This one is a little trickier to generalize, because it's not actually a keyword so much as an implicit instruction. AKA, you may be asked to solve the Fibonacci sequence. If you're unaware, the Fibonacci sequence is a sequence wherein every next number is the sum of the two numbers preceding it. So 0, 1, 1, 2, 3, 5, 8, 13, 21, and so on. As for when you'll use this in a programming job? Probably never. But it has a tidy mathematic proof, which means it's useful for algorithmic thinking. Broadly speaking, there are two common implementations of the Fibonacci sequence you might see in an interview: iteratively and recursively.

[Link to Fibonaccy](/src/Proof/Fibonacci/Fibonacci.cs)

### Iterative Fibonacci

**Iterative** means that you iterate over, basically, touch, each item in a collection. So an iterative solution moves over every item and does something with it. Because of this, it is complexity `O(N)`. However, since arithmetic is such a simple thing to do for a computer, and iterative solution to the Fibonacci sequence is still generally preferred.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see the iterative Fibonacci sequence in action.

```C#
			int n = 10;
			Console.WriteLine("Finding the " + n + "th Fibonacci number iteratively");
			int fib = Fibonacci.FibonacciIterative(n);
			Console.WriteLine($"Fibonacci: {fib}");
```

### Recursive Fibonacci

**Recursion** means that a formula calls itself. Well why on earth would you want to do that? First off, if you know what you're looking at, it can be a lot cleaner. Recursive solutions tend to be pretty clean in terms of how much code space they take up, since you'll have a single block that will call itself as many times as it needs to. If that's confusing, go take a look at `Fibonacci.cs` and it will hopefully make more sense. The problem with recursive solutions is they can be difficult to understand for junior developers, and if you don't adequately set your floor case, you can wind up with something leaky that crashes your app.

Additionally, in the case of the Fibonacci sequence, its complexity isn't great without **memoization**. All the same, I've seen this one as a whiteboarding problem because it demonstrates good knowledge of principles, so I'd recommend learning it.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see the recursive Fibonacci sequence in action.

```C#
			int n = 10;
			Console.WriteLine("Finding the " + n + "th Fibonacci number iteratively");
			int fib = Fibonacci.FibonacciRecursive(n);
			Console.WriteLine("The " + n + "th Fibonacci number is " + fib);
```