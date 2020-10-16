using System;
using System.Collections.Generic;
using DataStructures.SinglyLinkedList;

namespace DataStructures.SortedLinkedList
{
    /// <summary>
    /// TODO.
    /// </summary>
    /// <typeparam name="T">TODO. 2.</typeparam>
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        private long length = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortedLinkedList{T}"/> class.
        /// TODO.
        /// </summary>
        public SortedLinkedList()
        {
        }

        /// <summary>
        /// Gets the length of the sorted linked list.
        /// </summary>
        public long Length
        {
            get
            {
                return length;
            }
        }

        /// <summary>
        /// Gets or sets the head of the linked list.
        /// </summary>
        private SortedLinkedListNode<T>? Head { get; set; } = null;

        /// <summary>
        /// Gets or sets the tail of the linked list.
        /// </summary>
        private SortedLinkedListNode<T>? Tail { get; set; } = null;

        /// <summary>
        /// Adds new node to the start of the list,
        /// time complexity: O(1),
        /// space complexity: O(1).
        /// </summary>
        /// <param name="data">Contents of newly added node.</param>
        /// <returns>Added list node.</returns>
        public SortedLinkedListNode<T> Add(T data)
        {
            if (Head == null)
            {
                Head = new SortedLinkedListNode<T>(data)
                {
                    Next = null,
                };

                length = 1;
            }
            else
            {
                // TODO: Get the place to insert the next element.
            }

            return Head;
        }

        /// <summary>
        /// Returns element at index <paramref name="index"/> in the list.
        /// </summary>
        /// <param name="index">Index of an element to be returned.</param>
        /// <returns>Element at index <paramref name="index"/>.</returns>
        public T GetElementByIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var tempElement = Head;

            for (var i = 0; tempElement != null && i < index; i++)
            {
                tempElement = tempElement.Next;
            }

            if (tempElement is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return tempElement.Data;
        }

        /// <summary>
        /// TODO. get the whole list.
        /// </summary>
        /// <returns>TODO.</returns>
        public IEnumerable<T> GetListData()
        {
            // temp ListElement to avoid overwriting the original
            SortedLinkedListNode<T>? tempElement = Head;

            // all elements where a next attribute exists
            while (tempElement != null)
            {
                yield return tempElement.Data;
                tempElement = tempElement.Next;
            }
        }

        /// <summary>
        /// TODO. delete a element.
        /// </summary>
        /// <param name="element">TODO. 2.</param>
        /// <returns>TODO. 3.</returns>
        public bool DeleteElement(T element)
        {
            var currentElement = Head;
            SortedLinkedListNode<T>? previousElement = null;

            // iterates through all elements
            while (currentElement != null)
            {
                // checks if the element, which should get deleted is in this list element
                if ((currentElement.Data is null && element is null) || (currentElement.Data != null && currentElement.Data.Equals(element)))
                {
                    // if element is head just take the next one as head
                    if (currentElement.Equals(Head))
                    {
                        Head = Head.Next;
                        return true;
                    }

                    // else take the prev one and overwrite the next with the one behind the deleted
                    if (previousElement != null)
                    {
                        previousElement.Next = currentElement.Next;
                        return true;
                    }
                }

                // iterating
                previousElement = currentElement;
                currentElement = currentElement.Next;
            }

            return false;
        }

        /// <summary>
        /// Reverses the order of the current sorted linked list
        /// </summary>
        public void Reverse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears the current sorted linked list.
        /// </summary>
        public void Clear()
        {
            Head = null;
            length = 0;
        }
    }
}
