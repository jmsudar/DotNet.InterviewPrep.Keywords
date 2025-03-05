using System;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.QuickSort
{
    public class QuickSort
    {
        // Why does the quicksort have more than one time complexity? This is different
        // from other stuff we've looked at. Basically, if you look below you'll see
        // that we're recursively dividing the work being done. That is a dead giveaway
        // that we're looking at O(log N) time complexity. But if you look at the partition
        // method, you'll see that we're iterating through the array once. That's O(N).
        // This is why we get O(N log N) time complexity for quicksort. It's a combination
        // of O(N) and O(log N).
        //
        // As for how we're getting O(N^2) time complexity, that's a little more complicated.
        // If the pivot is the smallest or largest value in the array, we're going to end up
        // with exponential time complexity. This is because we're not actually dividing the
        // work being done. We're just iterating through the array once. This is why it's
        // important to choose a pivot that is not the smallest or largest value in the array.
        // This is also why quicksort is considered an unstable sorting algorithm. That's
        // important to remember, as it works in plenty of cases but not all. If you need more
        // stability, you might want to consider a different sorting algorithm.

        /// <summary>
        /// Recursively orts an array using the quick sort algorithm
        /// </summary>
        /// <param name="arr">The array being sorted</param>
        /// <param name="left">The left bound of the array</param>
        /// <param name="right">The right bound of the array</param>
        public static void RecursiveQuickSort(int[] arr, int left, int right)
        {
            // If the left bound is less than the right bound, we have a valid array
            // to sort. If the left bound is greater than the right bound, we have an
            // empty array, and we don't need to do anything. If the left bound is equal
            // to the right bound, we have an array with one element, and we don't need
            // to do anything.
            if (left < right)
            {
                // Partition the array and get the index of the pivot
                // The pivot is endemic to the quicksort algorithm. It's the value
                // that we're using to compare all the other values in the array.
                // We're going to move all the values less than the pivot to the left
                // of the pivot, and all the values greater than the pivot to the right
                // of the pivot. This is the "partition" step.
                //
                // It is also the riskiest part of the quicksort algorithm. If the pivot
                // is the smallest or largest value in the array, we're going to end up
                // we can wind up with exponential time complexity.
                int partitionIndex = Partition(arr, left, right);

                // Recursively sort the left and right sides of the array.
                RecursiveQuickSort(arr, left, partitionIndex - 1);
                RecursiveQuickSort(arr, partitionIndex + 1, right);
            }
        }

        /// <summary>
        /// Partitions the array and returns the index of the pivot
        /// </summary>
        /// <param name="arr">The array being partitioned</param>
        /// <param name="left">The left bound of the array</param>
        /// <param name="right">The right bound of the array</param>
        /// <returns></returns>
        public static int Partition(int[] arr, int left, int right)
        {
            // The pivot is the last element in the array.
            int pivot = arr[right];

            // The index of the smaller element.
            // We know it's smaller because of the condition in the calling method.
            int i = left - 1;

            // Iterate through the array and compare each element to the pivot.
            for (int j = left; j < right; j++)
            {
                // If the element is less than the pivot, we need to move it to the left
                if (arr[j] < pivot)
                {
                    // We only increment i if we find a value less than the pivot.
                    i++;

                    // Swap the values at i and j
                    // This is a common pattern in sorting algorithms. We're moving
                    // the smaller values to the left and the larger values to the right.
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }        

            // Swap the pivot with the value at i + 1.
            // This is the last step in the partitioning process. We're moving the pivot
            // to the correct position in the array.
            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
            
            // Return the new index of the pivot.
            return i + 1;
        }
    }
}