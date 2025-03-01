namespace InterviewPrep.Keywords.Proof.BinarySearch
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