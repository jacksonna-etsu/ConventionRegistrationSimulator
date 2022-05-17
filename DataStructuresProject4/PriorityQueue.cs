/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         PriorityQueue.cs
//	Description:       Implementation of PriorityQueue from class powerpoints
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Nathaniel Jackson, jacksonna@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Nathaniel Jackson, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject4
{
    /// <summary>
    /// Organizes registration events based on
    /// enter and leave time
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="DataStructuresProject4.IPriorityQueue{T}" />
    public class PriorityQueue<T> : IPriorityQueue<T>
        where T: IComparable
    {
        #region Properties
        private Node<T> top;                                //reference to the top of the PQ
        public int Count { get; set; }                      //number of items in the PQ
        #endregion

        /// <summary>
        /// Wipes the contents of the PriorityQueue
        /// </summary>
        public void Clear()
        {
            top = null;         //Nodes will be garabage collected
            Count = 0;          //Count is now 0 since PQ is empty
        }//end Clear()

        /// <summary>
        /// Removes first node from the PriorityQueue and 
        /// bumps up the remaining nodes
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot remove from empty queue</exception>
        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot remove from empty queue");
            }

            else
            {
                Node<T> oldNode = top;
                top = top.Next;
                Count--;
                oldNode = null;     //do this so the removed node can be garbage collected
            }
        }//end Dequeue()

        /// <summary>
        /// Puts a given item of type T into the PriorityQueue
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                top = new Node<T>(item, null);
            }
            else
            {
                Node<T> current = top;
                Node<T> previous = null;

                //search for the first node in the linked structure that is smaller than item
                while (current != null && current.Item.CompareTo(item) >= 0)
                {
                    previous = current;
                    current = current.Next;
                }

                //Have found the place to insert the new node
                Node<T> newNode = new Node<T>(item, current);

                //If there is a previous node, set it to link to the new node
                if (previous != null)
                {
                    previous.Next = newNode;
                }
                else
                {
                    top = newNode;
                }
            }
            Count++;                //Add 1 to the number of nodes in the PQ
        }//end Enqueue(T)

        /// <summary>
        /// Checks to find if any items are in the PriorityQueue
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }//end IsEmpty()

        /// <summary>
        /// Peeks the PriorityQueue to view the first item
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Cannot obtain top of empty priority queue.</exception>
        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.Item;
            }
            else
            {
                throw new InvalidOperationException("Cannot obtain top of empty priority queue.");
            }
        }//end Peek()
    }//end PriorityQueue
    
}//end namespace
