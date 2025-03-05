# Reverse Order

Why on earth would you want to do something in reverse order? Lots of reasons. Believe it or not, you're doing things in reverse order right now, and do every time you use a computer. Computers at a very low level rely on something called a "call stack," which I'm not even going to try to explain because it's way beyond me right now. Suffice it to say that at a low level, your computer may order things in this way because it makes it allows for arranging the different abstractions necessary to do what you want to have happen.

## Stack

You'll notice I use the term "stack" when I talk about a "call stack." As data structure go, the stack is true foundational computer science. Like the queue, it shares infrastructure in the linked list. The best way to think about a stack is exactly like a "stack of books." You add books one at a time, and you take books from the top of the stack one at a time. Put another way, stacks are **last in, first out**, or **LIFO**.

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a Stack in action.

```C#
			Stack<int> stack = new Stack<int>();

			Console.WriteLine("Pushing 1, 2, 3, 4, 5 to stack");
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Push(5);

			Console.WriteLine("Popping items from stack while IsEmpty() == false");
			while (!stack.IsEmpty())
			{
				Console.WriteLine(stack.Pop());
			}

			Console.WriteLine("The stack is empty!");
```