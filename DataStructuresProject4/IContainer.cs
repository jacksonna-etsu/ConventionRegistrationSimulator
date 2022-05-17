/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         IContainer.cs
//	Description:       Interface for the generic type T to implement
//                     when a class contains quantifiable data
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Nathaniel Jackson, jacksonna@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Nathaniel Jackson, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DataStructuresProject4
{
    /// <summary>
    /// Interface for container-like data structures
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContainer<T>
    {
        //Remove all objects from the container
        void Clear();
        //Returns true if container is empty
        bool IsEmpty();
        //Returns the number of entries in the container
        int Count { get; set; }
    }//end IContainer<T>
}//end namespace
