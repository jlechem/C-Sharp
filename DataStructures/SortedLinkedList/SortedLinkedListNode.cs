﻿using System;

namespace DataStructures.SortedLinkedList
{
    /// <summary>
    /// TODO.
    /// </summary>
    /// <typeparam name="T">TODO. 2.</typeparam>
    public class SortedLinkedListNode<T> where T : IComparable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortedLinkedListNode{T}"/> class.
        /// TODO.
        /// </summary>
        /// <param name="data">TODO. 2.</param>
        public SortedLinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }

        /// <summary>
        /// Gets elements from current SortedLinkedList.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Gets or sets tODO. TODO.
        /// </summary>
        public SortedLinkedListNode<T>? Next { get; set; } = null;

        /// <summary>
        /// Gets or sets the previous node.
        /// </summary>
        public SortedLinkedListNode<T>? Previous { get; set; } = null;

    }
}
