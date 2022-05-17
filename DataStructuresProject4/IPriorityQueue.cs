/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         IPriorityQueue.cs
//	Description:       Generic interface to implement when using a priority queue
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
    /// IPriorityQueue generic interface - implements IContainer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPriorityQueue<T> : IContainer<T>
                            where T : IComparable
    {
        //Inserts item based on its priority
        void Enqueue(T item);
        //Removes first item in the queue
        void Dequeue();
        //Query
        T Peek();
    }//end IPriorityQueue<T>
}//end namespace
