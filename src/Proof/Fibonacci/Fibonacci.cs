using System;
using System.Collections.Generic;

namespace InterviewPrep.Keywords.Proof.Fibonacci
{
    public class Fibonacci
    {
        // Fibonacci is a sequence of numbers in which each number is the sum of the two preceding ones.
        // The sequence starts with 0 and 1.
        // The sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        //
        // There are two ways to implement Fibonacci: recursively and iteratively.
        // Recursively is the most intuitive way to implement Fibonacci, but it is not the most efficient.
        // Recursively has O(2^n) time complexity.
        // This is exponential time complexity, which is one of the worst cases and must
        // always be avoided.
        // Iteratively is the most efficient way to implement Fibonacci.
        // Iteratively has O(n) time complexity.

        // A note on the Fibonnacci sequence:
        // When I was writing this, I got really stuck on the recursive explanation of the sequence.
        // It turns out that it's just an expression of the mathematical proof behind the
        // Fibonacci sequence itself. The sequence is defined as F(n) = F(n-1) + F(n-2) for all n ≥ 2.
        // But this threw me too, because F(4), finding the fourth Fibonacci number, should be
        // 3, but I expressed it as F(4) = F(4 - 1) + F(4 - 2), aka 3 + 2, aka 5.
        // But that's not what the formula is saying, it's saying that instead of adding 3 + 2, you're adding
        // the third and second Fibonacci numbers, which are 2 and 1, to get 3.
        // This is exactly why the Fibonacci sequence lends itself to recursion, which
        // I will expand on more below.

        // Detailed Example based on FibonacciIterative:
        // Imagine you want to find the 6th Fibonacci number.
        // You start with a as 0 and b as 1 because those are the first two
        // Fibonacci numbers.
        // You set a temporary variable to store the sum of a and b.
        // You iterate from 2 to 6, because you already have 0 and 1.
        // At each step, you calculate the sum of a and b.
        // You set a to b, because you are moving to the next number.
        // You set b to the sum of a and b.
        // You repeat this, moving through the sequence until you reach the 6th number.
        // The 6th Fibonacci number is 8, so you return 8.

        // Detailed Example based on FibonacciRecursive:
        // Recall that above, we established that the Fibonacci sequence is defined
        // as F(n) = F(n-1) + F(n-2) for all n ≥ 2.
        // So let's say you're looking at F(4). That is F(4) = F(4 - 1) + F(4 - 2).
        // Put another way, F(4) = F(3) + F(2). Putting _that_ another way, you're saying
        // that the fourth Fibonacci number is the sum of the third and second Fibonacci numbers.
        // F(3) is F(3) = F(3 - 1) + F(3 - 2), or F(3) = F(2) + F(1).
        // That means that the third Fibonacci number is the sum of the second and first Fibonacci numbers.
        // The second number is going to follow a similar relationship, being the sum of the first and zeroth numbers.
        // Since you already know the first and zeroth numbers, you don't need to keep calculating and you can start
        // adding things back up the recursive call stack.
        // Since every number is going to eventually reach that base case, you're able to work backwards until
        // you get there! This isn't very efficient, but it's clean and a clear example of recursion.

        // Detailed Example based on FibonacciRecursiveWithMemoization:
        // Really, this is very similar to the example above so I'm not going to rehash it,
        // but the core difference is that every time you calculate a Fibonacci number,
        // you log it in a memoization dictionary. This means that the next time you
        // calculate that number, you can just return it from the dictionary instead of
        // recalculating it. This prevents replumbing the same levels of the recursive
        // call stack over and over.

        /// <summary>
        /// A memoization dictionary to store the nth Fibonacci number.
        /// This is used during the second recursive solution to remove
        /// repeat work and increase efficiency.
        /// </summary>
        private static Dictionary<int, int> _memo = new Dictionary<int, int>();

        /// <summary>
        /// Find the nth Fibonacci number recursively
        /// </summary>
        /// <param name="n">How far in the sequence you want to go</param>
        /// <returns>The nth Fibonacci number</returns>
        public static int FibonacciIterative(int n)
        {
            // Since 0 and 1 are your two base cases,
            // you can return them immediately.
            if (n <= 1) return n;

            // Set a as 0, your first number
            int a = 0;
            // and b as 1, your second number.
            int b = 1;

            // You will need a temporary variable to store the sum of a and b.
            int temp;
            
            // Start at 2, because you already have 0 and 1
            // and iterate all the way up to the nth number.
            for (int i = 2; i <= n; i++)
            {
                // The sum of a and b is the next number in the sequence.
                temp = a + b;
                // Set a to b, because you're moving to the next number.
                a = b;
                // Set b to the sum of a and b.
                b = temp;
            }

            // Return the nth number in the sequence, represented by b.
            return b;
        }

        public static int FibonacciRecursive(int n)
        {
            // Recursive Fibonacci looks clean but is very inefficient
            // in terms of complexity class.
            // Additionally, it works backwards from the nth number
            // to the base cases, which is not as intuitive as the iterative solution.

            // Base case: if n is 0 or 1, return n.
            // In a recursive function, having a clear base case is crucial
            // to prevent infinite recursion.
            // If you don't have a base case, the function will keep calling itself
            // until it runs out of memory and crashes.
            if (n <= 1) return n;

            // Recursive case: return the sum of the two preceding numbers.
            // This is the definition of the Fibonacci sequence.
            // It is also the recursive case, because it calls itself.
            // At each step, the function calls itself with n - 1 and n - 2.
            // This works backwards from the nth number to the base cases
            // while adding the numbers together.
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public static int FibonacciRecursiveWithMemoization(int n)
        {
            // Recursive Fibonacci with memoization is more efficient
            // than the standard recursive solution because it never
            // repeats work. At each step there is a check to see if the
            // given value of n has already been calculated, and returns it
            // if it has. This cuts off repeat dives into the recursive
            // call stack.

            // Same base case as the non-memoized recursive solution.
            if (n <= 1) return n;

            // Check to see if the nth number has already been calculated.
            // If it has, return it.
            if (_memo.ContainsKey(n)) return _memo[n];

            // Log the calculate of the nth number directly into the memoization dictionary.
            // This guards against repeat work the next time n occurs, which due to the nature of
            // recursive Fibonacci means it almost certainly will.
            _memo[n] = FibonacciRecursiveWithMemoization(n - 1) + FibonacciRecursiveWithMemoization(n - 2);
            
            // Return the calculated nth number.
            return _memo[n];
        }
    }
}