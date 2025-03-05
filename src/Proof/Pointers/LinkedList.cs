namespace jmsudar.DotNet.InterviewPrep.Keywords.Proof.LinkedList
{
    // One of the reasons why linked lists are valuable is
    // the way they know what's in the contents of their list.
    // By its nature it's very lightweight, and this lets it
    // be extended to become other things.
    //
    // Generally speaking, a linked list always knows
    // where its head is, and from there it can either find the tail
    // or the tail may also be known, allowing you to start from the
    // beginning or end of the list and traverse it.
    //
    // Later on, we will see how this allows us to create two
    // other, much more widely used data structures: stacks and queues.

    /// <summary>
    /// A simple linked list implementation
    /// </summary>
    /// <typeparam name="T">The type of object the linked list is storing</typeparam>
    public class LinkedList<T>
    {
        // The head of the linked list
        // This represents the first node, and generally
        // speaking is known at all times to the calling
        // program as the entry point to the list.
        public LinkedListNode<T>? Head { get; set; }
        
        // The tail of the linked list
        // This represents the last node, and generally
        // speaking is known at all times to the calling
        // program as the exit point to the list.
        public LinkedListNode<T>? Tail { get; set; }

        // Initialized the linked list with nothing currently stored.
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        // Add a new value to the linked list
        public void Add(T value)
        {
            // First, create a node to represent the new value
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            
            // If the head is null, then the list is empty
            // and the new node is both the head and the tail.
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            // Otherwise, the new node is the new tail
            // and the old tail's next is the new node.
            else
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                Tail.Next = node;
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                Tail = node;
            }
        }
    }

    /// <summary>
    /// A node in a linked list
    /// </summary>
    /// <typeparam name="T">The type of object stored by the node</typeparam>
    public class LinkedListNode<T>
    {
        // The actual value stored by the node.
        // This is what is used by the linked list
        // to store data or do work.
        public T Value { get; set; }
        
        // The next node in the linked list.
        public LinkedListNode<T>? Next { get; set; }

        // The node is initialized with a value but without
        // a known, next value in the list because that is handled
        // by the upstream LinkedList class.
        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}