using jmsudar.DotNet.InterviewPrep.Keywords.Proof.LinkedList;

namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.Stack
{
    // A lot of what I would say about a stack is the same as what I would say about a queue,
    // so I'm avoiding redundancy here and instead comment in-line where important differences
    // take place.

    public class Stack<T>
    {
        // Since our stack is an extension of a linked list, we
        // need to include our linked list library as a using
        // directive, and then create an internal (private) linked list object.
        private LinkedList<T> _list = new LinkedList<T>();

        /// <summary>
        /// Add a value to the stack
        /// </summary>
        /// <param name="value">The value being added</param>
        public void Push(T value)
        {
            // This is really the meat and potatoes of a stack, and where it critically differs
            // from a queue. In a queue. We are using the regular .Add() method to 
            // add an item to the tail of the internal list. A stack by comparison adds
            // to the head. This might be a little confusing, because if you're adding to the
            // front then don't you have to shift everything to the right?
            //
            // No! Because linked lists use pointers. This means that the list isn't actually
            // arranged in a linear way in memory, each node just always knows where the 
            // next node is, which allows it to behave as though it were linear. So every time 
            // we add something to our stack, we don't directly shift everything to the right,
            // we just tell this list "this is the new head" and have it point to the old head.
            _list.AddHead(value);
        }

        /// <summary>
        /// Remove the first value from the stack
        /// </summary>
        /// <returns>The item at the head of the internal list</returns>
        /// <exception cref="System.InvalidOperationException">Throws error if empty</exception>
        public T Pop()
        {
            // Check to see if the stack is empty. If it is, throw an exception.
            if (_list.Head == null)
            {
                throw new System.InvalidOperationException("Stack is empty");
            }

            // Get the value at the head of the linked list.
            T value = _list.Head.Value;

            // Remove the head of the linked list.
            // While this is more or less the same as what's happening in the queue, since
            // the items are added in reverse order, we get the last item added to the stack
            // instead of the first!
            _list.RemoveHead();

            // Return the value that was at the head of the linked list.
            return value;
        }

        /// <summary>
        /// Look at the first value in the stack without removing it
        /// </summary>
        /// <returns>The item at the head of the linked list</returns>
        /// <exception cref="System.InvalidOperationException">Throws error if empty</exception>
        public T Peek()
        {
            if (_list.Head == null)
            {
                throw new System.InvalidOperationException("Stack is empty");
            }

            return _list.Head.Value;
        }

        /// <summary>
        /// Check if the stack is empty
        /// </summary>
        /// <returns>True if the stack is empty, false otherwise</returns>
        public bool IsEmpty()
        {
            return _list.Head == null;
        }
    }
}