using System.Collections.Generic;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.Heap
{
    // In many ways, Heaps have the same characteristic at trees,
    // that is to say that they have a structure of root and child
    // nodes, but the difference with a heap is that it's organized
    // based on the relationship between nodes.

    // In these examples we are making heaps that hold integers,
    // but heaps can hold any type of data, as long as the data
    // can be compared to other data of the same type.
    //
    // In .NET you can use the IComparable interface to use a generic
    // while ensuring it can be compared, which is necessary for
    // ranking.

    // You will notice that these Heaps "heapify" the data. This is
    // the process of moving the data up or down the heap to ensure
    // that the heap is in the correct order. This is a key part of
    // how heaps work by keeping them ordered.

    public class MinHeap
    {
        // In a MinHeap, the root node is always the smallest value
        // in the heap. This is a very useful data structure for
        // finding the smallest value in a set of values, and is
        // used in many algorithms for this purpose.

        // Use a list as your internal data structure
        // as this will allow for dynamic resizing.
        private readonly List<int> _heap;

        /// <summary>
        /// Constructor for the MinHeap
        /// </summary>
        public MinHeap()
        {
            // Initialize the heap as an empty list
            _heap = new List<int>();
        }

        /// <summary>
        /// Get the heap as a list
        /// </summary>
        /// <returns>The internal _heap structure</returns>
        public List<int> GetHeap() => _heap;

        /// <summary>
        /// Add a value to the heap
        /// </summary>
        /// <param name="value">The value being added</param>
        public void Add(int value)
        {
            // Add the value to the end of the list
            _heap.Add(value);
            // Heapify the list
            // Heapify in this case is the process of moving the
            // value up the heap until it is in the correct position.
            HeapifyUp(_heap.Count - 1);
        }   

        /// <summary>
        /// Remove the smallest value from the heap
        /// </summary>
        /// <returns>The minimum integer within the heap</returns>
        /// <exception cref="System.InvalidOperationException">Throws an expection if the heap is empty</exception>
        public int RemoveMin()
        {
            // If the heap is empty, throw an exception
            if (_heap.Count == 0) throw new System.InvalidOperationException("Heap is empty");

            // The root of the heap is the smallest value
            int root = _heap[0];
            // Move the last value in the heap to the root
            _heap[0] = _heap[^1];
            // Raemove the last value from the heap
            // As you've moved it to the root as a placeholder
            _heap.RemoveAt(_heap.Count - 1);

            // Heapify the list
            // Heapify in this case is the process of moving the
            HeapifyDown(0);

            // Return the smallest value
            return root;
        }

        /// <summary>
        /// Get the smallest value in the heap without removing it
        /// </summary>
        /// <returns>The smallest value held by the heap</returns>
        public int PeekMin() => _heap[0];

        /// <summary>
        /// Get the number of elements in the heap
        /// </summary>
        public int Count => _heap.Count;

        /// <summary>
        /// Heapify the heap from the bottom up
        /// </summary>
        /// <param name="index">The index from which you're starting your heap operation</param>
        private void HeapifyUp(int index)
        {
            // This finds the parent of the current node.
            // This confused me initially, so I'm going to talk about
            // it a lot more. Basically, this is because we are
            // representing the internal heap as a list/array, we have
            // some weirdness at work here. 
            //
            // If we look at array [1, 3, 5, 7, 9, 6, 2], we can visualize
            // this in tree/heap form as:
            //
            //          1
            //        /   \
            //       3     5
            //      / \   / \
            //     7   9 6   2
            //
            // through this, we can see that the parents are not
            // necessarily directly next to one another in the array, but
            // they are related to one another in tree form.
            int parent = (index - 1) / 2;

            // If the current node is not the root and is smaller than
            // its parent, swap the two.
            if (index > 0 && _heap[index] < _heap[parent])
            {
                // This is known as a tuple swap, and is a way to swap
                // two values without needing a temporary variable.
                // This is a common pattern in C# and other languages.
                (_heap[parent], _heap[index]) = (_heap[index], _heap[parent]);
                
                // Recursively heapify the parent.
                HeapifyUp(parent);
            }
        }

        /// <summary>
        /// Heapify the heap from the top down
        /// </summary>
        /// <param name="i">The index from which you're starting your heap operation</param>
        private void HeapifyDown(int i)
        {
            // Find the left and right children of the current node.
            // For a detailed explanation on how this works, check HeapifyUp
            // where we see how this heap looks as a tree instead of a list.
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // Find the smallest value between the current node and its children.
            int smallest = i;

            // If the left child is smaller than the current node, set it as the smallest.
            if (left < _heap.Count && _heap[left] < _heap[smallest])
            {
                smallest = left;
            }

            // If the right child is smaller than the current node, set it as the smallest.
            if (right < _heap.Count && _heap[right] < _heap[smallest])
            {
                smallest = right;
            }

            // If the smallest value is not the current node, swap the two.
            if (smallest != i)
            {
                // Another tuple swap.
                (_heap[smallest], _heap[i]) = (_heap[i], _heap[smallest]);
                
                // Recursively heapify the child.
                HeapifyDown(smallest);
            }
        }
    }

}