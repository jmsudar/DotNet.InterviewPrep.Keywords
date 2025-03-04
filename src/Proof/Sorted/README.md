# Sorted

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