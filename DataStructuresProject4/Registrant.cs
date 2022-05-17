/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         Registrant.cs
//	Description:       A registrant object - enters the convention to register, 
//                     stands in line, then leaves
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
    /// Registrant class - holds entering and leaving 
    /// properties along with queue properties
    /// </summary>
    class Registrant
    {
        #region Properties
        public RegistrationEvent EnterEvent { get; set; }
        public RegistrationEvent LeaveEvent { get; set; }
        public int RegistrantNumber { get; set; }
        public Queue<Registrant> CurrentLine { get; set; }                //the line this registrant has entered
        public int PositionInLine { get; set; }
        #endregion

        /// <summary>
        /// Parameterized constructor - takes the sequentially generated registrant number
        /// along with the registrant's enter event
        /// </summary>
        /// <param name="registrantNumber"></param>
        /// <param name="enterEvent"></param>
        public Registrant(int registrantNumber, RegistrationEvent enterEvent)
        {
            RegistrantNumber = registrantNumber;
            EnterEvent = enterEvent;
            LeaveEvent = null;
            CurrentLine = null;
            PositionInLine = 1;
        }//end Registrant(int, RegistrationEvent)
    }//end Registrant
}//end namespace
