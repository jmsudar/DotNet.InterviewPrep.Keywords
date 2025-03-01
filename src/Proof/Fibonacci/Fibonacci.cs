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
        // Imagine you want to find the 10th Fibonacci number.
        // You start with the base case: if n is 0 or 1, return n.
        // It's important to remember that in this case, you're working backwards
        // compared to when you're doing it iteratively. This is the
        // only way that you can get base cases of 0 and 1 to work.
        // You call the function the first time with n = 10.
        // The function calls itself with n = 9 and n = 8.
        // These function calls call themselves with n = 8 and n = 7, and so on.
        // So if you look at what's getting added together,
        // you're adding 9 + 8 + 8 + 7 + 7 + 6 + 6 + 5 + 5 + 4 + 4 + 3 + 3 + 2 + 2 + 1 + 1 + 0 + 0.
        // This is a lot of repeated work, which is why the recursive solution is inefficient.
        // Mathemically, this can be expressed as F(n) = F(n-1) + F(n-2) for all n ≥ 2.

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
    }
}