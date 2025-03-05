using jmsudar.DotNet.InterviewPrep.Keywords.Proof.LinkedList;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.Queue
{
    // One thing you should note about the implementation below is that
    // it holds the user's hand a bit. It doesn't allow the user to
    // access the linked list directly, which is a good thing.
    // This is because the linked list is a private member of the queue,
    // and the queue only exposes the methods that are necessary to
    // interact with it as a queue.
    //
    // To this end, the queue has three methods: Enqueue, Dequeue, and Peek.
    // Enqueue adds an item to the queue, Dequeue removes the first item
    // from the queue, and Peek allows you to look at the first item
    // and use it if necessary, as it's returned.
    //
    // The queue also has a method, IsEmpty, which allows you to check
    // if the queue is empty. This is useful for knowing when to stop
    // dequeuing items from the queue automatically, meaning that you
    // can trust the implementation of the queue when doing something like
    // a while loop acting on every item in the queue. This is a great example
    // of both how a data structure might build on common infrastructure, a linked
    // list in this case, and why designing a data structure to do something
    // particular can add useful functionality.

    /// <summary>
    /// A queue, first in first out
    /// </summary>
    /// <typeparam name="T">The type of object being stored</typeparam>
    public class Queue<T>
    {
        // Since our queue is an extension of a linked list, we
        // need to include our linked list library as a using
        // directive, and then create an internal (private) linked list object.
        private LinkedList<T> _list = new LinkedList<T>();

        /// <summary>
        /// Add a value to the queue
        /// </summary>
        /// <param name="value">The object being added</param>
        public void Enqueue(T value)
        {
            _list.Add(value);
        }

        /// <summary>
        /// Remove the first value from the queue
        /// </summary>
        /// <returns>The item at the head of the linked list</returns>
        /// <exception cref="System.InvalidOperationException">Thrown if _list is empty</exception>
        public T Dequeue()
        {
            // Check to see if there's an item at the head of _list.
            // If there isn't, it's empty, so throw an exception.
            if (_list.Head == null)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }

            // Get the value at the head of the linked list.
            // Since this is the first value that was put into
            // the list, and since we are only providing this metho
            // of access it, and other methods are not available as the
            // list is private, this is how we ensure the queueing behavior.
            T value = _list.Head.Value;
            
            // When an item is dequeued, we remove it from the list.
            // In the same way that people exit a line in the order they
            // entered it, we remove items from a queue as we go.
            _list.RemoveHead();
            
            // Return the value that was at the head of the list.
            return value;
        }

        /// <summary>
        /// Look at the first value in the queue without removing it
        /// </summary>
        /// <returns>The item at the head of the linked list</returns>
        /// <exception cref="System.InvalidOperationException">Thrown if _list is empty</exception>
        public T Peek()
        {
            // Check to see if there's an item at the head of _list.
            // If there isn't, it's empty, so throw an exception.            
            if (_list.Head == null)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }

            // Return the value at the head of the linked list.
            return _list.Head.Value;
        }

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        /// <returns>True if the queue is empty, false otherwise</returns>
        public bool IsEmpty()
        {
            return _list.Head == null;
        }
    }
}