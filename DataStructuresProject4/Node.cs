/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         Node.cs
//	Description:       A node of generic type T to be used in a linked priorityqueue
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Nathaniel Jackson, jacksonna@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Nathaniel Jackson, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace DataStructuresProject4
{
    /// <summary>
    /// Generic type Node, implements IComparable to link to other nodes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T> where T: IComparable
    {
        // Properties
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value, Node<T> link)
        {
            Item = value;
            Next = link;
        }//end Node(T, Node<T>)
    }//end Node<T>
}//end namespace
