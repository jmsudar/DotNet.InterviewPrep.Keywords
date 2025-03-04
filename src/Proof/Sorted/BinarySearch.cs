namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.BinarySearch
{
    public class BinarySearch 
    {
        // Binary search is a search algorithm that finds the 
        // position of a target value within a sorted array.
        // The array must be sorted, as it relies on dividing the array
        // in half and comparing the target value to the midpoint.
        //
        // Binary search is valuable, because it divides the work
        // in half at each step, which means it has O(log n) time complexity.

        // Detailed Example based on IterativelyFindIndexOfTarget:
        // Imagine you have a sorted array of integers: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        // You want to find the index of the number 8.
        // You start by finding the midpoint by adding the left and right bounds
        // and dividing by 2: (0 + 9) / 2 = 4.5, which is 4 (integers are whold numbers).
        // The midpoint is 5, which is the value at index 4.
        // You compare the target value, 8, to the midpoint, 5.
        // Since 8 is greater than 5, you know the target is to the right of the midpoint.
        // You move the left bound to the midpoint + 1, which is 5.
        // and you loop, finding the new midpoint by adding the left and right bounds
        // and dividing by 2: (5 + 9) / 2 = 7.
        // The midpoint is 8, which is the value at index 7.
        // You compare the target value, 8, to the midpoint, 8.
        // so now you have the target value's index, which you return!
        //
        // Critically, because the array is sorted and you can divide every time
        // you do an operation, it is a very efficient search, with our
        // while loop only needing to loop twice in the example above.

        /// <summary>
        /// Find the index of a given target in a sorted int array with binary search
        /// </summary>
        /// <param name="arr">The array being search</param>
        /// <param name="target">The target value</param>
        /// <returns>Either the index of the target or -1 if not found</returns>
        public static int IterativelyFindIndexOfTarget(int[] arr, int target)
        {
            // On the left side, start at 0, the beginning of the array.
            // This is where your your search cursor will begin.
            int left = 0;
            
            // On the right side, start at the end of the array
            // (Length - 1 because arrays are 0-indexed).
            int right = arr.Length - 1;

            // Perform the search operation for as long as the cursor has
            // not exceed the bounds of the array.
            while (left <= right)
            {
                // Your midpoint is halfway between what you're searching
                // so you get that by adding your left (lowest) bound to
                // the difference between the right (highest) bound and the left bound
                // and dividing by 2.
                int mid = left + (right - left) / 2;
                
                // If the midpoint is the target, return the index
                // as you have found what you're looking for!.
                if (arr[mid] == target)
                {
                    // This will end the search operation
                    // returning the target's index.
                    return mid;
                }
                // If the midpoint is less than the target, you know
                // the target is to the right side of the midpoint.
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                // If the midpoint is greater than the target, you know
                // the target is to the left side of the midpoint.
                else
                {
                    right = mid - 1;
                }

                // Continue until the left cursor exceeds the right cursor.
            }

            // Return a -1, meaning the target was not found, if the 
            // while loop ends without returning an index.
            return -1;
        }
    }
}