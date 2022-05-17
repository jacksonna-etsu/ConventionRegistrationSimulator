/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         ConventionRegistration.cs
//	Description:       Contains the simulation information, uses the 
//                     helper classes to run the simulation
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Nathaniel Jackson, jacksonna@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Nathaniel Jackson and Michael Malone, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructuresProject4
{
    /// <summary>
    /// Convention Registrartion class - utilizes the PriorityQueue to 
    /// simulate the registration using parameters obtained from the user in the 
    /// PrimaryWindow Form
    /// </summary>
    class ConventionRegistration
    {
        #region Variable Declaration
        public double ExpectedNumberOfRegistrants { get; set; }
        public int NumberOfHoursOpen { get; set; }
        public int NumberOfRegistrationWindows { get; set; }
        public double AverageRegistrationTime { get; set; }
        public double MinimumRegistrationTime { get; set; }
        DateTime OpenTime;
        List<Queue<Registrant>> RegistrationLines;
        List<Registrant> RegistrantList;
        public PriorityQueue<RegistrationEvent> RegistrationEventQueue { get; set; }
        public String CurrentSimulationOutput { get; set; }
        Random RandomNumber;                              //random number generator

        //Variables that are read from the PrimaryWindow for output
        public int LongestLine = 1;
        public double AverageTime = 0.0;
        public DateTime LastExitTime = DateTime.Today;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor - initializes properties to the defaults in the 
        /// project assignment
        /// </summary>
        public ConventionRegistration()
        {
            RandomNumber = new Random();
            ExpectedNumberOfRegistrants = Poisson(1000);
            AverageRegistrationTime = 4.25 * 60;
            MinimumRegistrationTime = 1.5 * 60; 
            NumberOfHoursOpen = 10;
            NumberOfRegistrationWindows = 2;
            RegistrationEventQueue = new PriorityQueue<RegistrationEvent>();
            RegistrantList = new List<Registrant>();
            RegistrationLines = new List<Queue<Registrant>>();
            OpenTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
            CurrentSimulationOutput = "";

            GenerateRegistrantEvents();
        }//end ConventionRegistration()

        /// <summary>
        /// Parameterized constructor - assigns properties to values
        /// obtained from the parameters and runs the simulation
        /// </summary>
        /// <param name="numRegistrants"></param>
        /// <param name="avgTime"></param>
        /// <param name="minTime"></param>
        /// <param name="numHours"></param>
        /// <param name="numWindows"></param>
        public ConventionRegistration(double numRegistrants, double avgTime, double minTime, int numHours, int numWindows)
        {
            RandomNumber = new Random();
            ExpectedNumberOfRegistrants = Poisson(numRegistrants);
            AverageRegistrationTime = avgTime * 60;
            MinimumRegistrationTime = minTime * 60;
            NumberOfHoursOpen = numHours;
            NumberOfRegistrationWindows = numWindows;
            RegistrationEventQueue = new PriorityQueue<RegistrationEvent>();
            RegistrantList = new List<Registrant>();
            RegistrationLines = new List<Queue<Registrant>>();
            OpenTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
            CurrentSimulationOutput = "";
           
            GenerateRegistrantEvents();
        }//end ConventionRegistration(int, double, double, int, int)
        #endregion

        #region Helper and Number Generation Methods
        /// <summary>
        /// Generates a number based on a Poisson distribution
        /// </summary>
        /// <param name="expectedValue"></param>
        /// <returns></returns>
        private int Poisson(double expectedValue)
        {
            int Count;                                      //loop variable

            double Limit = -expectedValue;
            double Sum = Math.Log(RandomNumber.NextDouble());

            
            for (Count = 0; Sum > Limit; Count++)
                Sum += Math.Log(RandomNumber.NextDouble());

            return Count;
        }//end Poisson(double)

        /// <summary>
        /// Generates a number based on a negative exponential distribution
        /// </summary>
        /// <param name="expectedValue"></param>
        /// <returns></returns>
        private double NegExp(double expectedValue)
        {
            return -expectedValue * Math.Log(RandomNumber.NextDouble(), Math.E);
        }//end NegExp(double)

        /// <summary>
        /// Generates the enter event for each registrant in the 
        /// ExpectedNumberOfRegistrants
        /// </summary>
        private void GenerateRegistrantEvents()
        {
            int currentRegistrant;                      //loop variable; current registrant
            TimeSpan start;                             //start time of current registrant
            RegistrationEvent EnterEvent;               //event generated when someone enters the registration building

            for (currentRegistrant = 1; currentRegistrant < ExpectedNumberOfRegistrants; currentRegistrant++)
            {
                start = new TimeSpan(0, RandomNumber.Next(NumberOfHoursOpen * 60), 0);

                EnterEvent = new RegistrationEvent(EVENTTYPE.ENTER, OpenTime.Add(start), currentRegistrant);
                RegistrationEventQueue.Enqueue(EnterEvent);
                RegistrantList.Add(new Registrant(currentRegistrant, EnterEvent));          //reference enter event through registrant number

            }//end for(currentRegistrant)
        }//end GenerateRegistrantEvents()

        /// <summary>
        /// Finds the shortest line available, then puts the given 
        /// registrant in that line, sets their registration time
        /// and then generates their leave event
        /// </summary>
        /// <param name="enterEvent"></param>
        private void AddRegistrantToShortestLine(RegistrationEvent enterEvent)
        {
            int i;                                          //loop variable
            Queue<Registrant> ShortestLine;                 //shortest line in the list of lines
            Registrant CorrespondingRegistrant;             //registrant that matches current enter event
            TimeSpan interval;                              //time it takes the registrant to finish registering
            RegistrationEvent LeaveEvent;                   //event generated when is done registering
            Registrant[] RegistrantArray;                   //array to hold all registrants from one line
            DateTime LeaveTime;                             //represents when the registrant leaves; used to generate a leave event
            Registrant NextInLine;                          //the next person in the line


            NextInLine = null;
            LeaveTime = OpenTime;
            ShortestLine = RegistrationLines[0];            //set default to first line
            CorrespondingRegistrant = null;                 //set default to null
            for (i = 0; i < RegistrantList.Count; i++)
            {
                if (enterEvent.RegistrantNumber == RegistrantList[i].RegistrantNumber)
                {
                    CorrespondingRegistrant = RegistrantList[i];
                }
            }

            for (i = 0; i < RegistrationLines.Count; i++)
            {
                if (RegistrationLines[i].Count < ShortestLine.Count)
                {
                    ShortestLine = RegistrationLines[i];
                }
            }



            if (ShortestLine.Count == 0)
            {
                interval = new TimeSpan(0, 0, (int)(MinimumRegistrationTime + NegExp(AverageRegistrationTime - MinimumRegistrationTime)));
                LeaveTime = CorrespondingRegistrant.EnterEvent.Time;
                LeaveTime = LeaveTime.Add(interval);
                CorrespondingRegistrant.PositionInLine = 1;
                AverageTime += interval.TotalMinutes;
            }
            else
            {
                RegistrantArray = ShortestLine.ToArray();
                NextInLine = RegistrantArray[0];                        //set a default
                interval = new TimeSpan(0, 0, (int)(MinimumRegistrationTime + NegExp(AverageRegistrationTime - MinimumRegistrationTime)));
                CorrespondingRegistrant.PositionInLine = (NextInLine.PositionInLine + 1);
                for (i = 0; i < RegistrantArray.Length; i++)
                {
                    if (RegistrantArray[i].PositionInLine > NextInLine.PositionInLine)
                    {
                        NextInLine = RegistrantArray[i];
                    }
                }
                CorrespondingRegistrant.PositionInLine = (NextInLine.PositionInLine + 1);
                LeaveTime = CorrespondingRegistrant.EnterEvent.Time;
                LeaveTime.Add(interval);
                for (i = 0; i < RegistrantArray.Length; i++)
                {
                    if (RegistrantArray[i].PositionInLine == (CorrespondingRegistrant.PositionInLine - 1))
                    {

                        LeaveTime = RegistrantArray[i].LeaveEvent.Time.Add(interval);
                    }
                }
                if (RegistrantArray.Length > LongestLine)
                {
                    LongestLine = RegistrantArray.Length;
                }
                AverageTime += interval.TotalMinutes;

            }
            LeaveEvent = new RegistrationEvent(EVENTTYPE.LEAVE, LeaveTime, CorrespondingRegistrant.RegistrantNumber);
            ShortestLine.Enqueue(CorrespondingRegistrant);
            CorrespondingRegistrant.CurrentLine = ShortestLine;
            RegistrationEventQueue.Enqueue(LeaveEvent);
            CorrespondingRegistrant.LeaveEvent = LeaveEvent;
                                                                
        }//end AddRegistrantToShortestLine(RegistrationEvent)

        /// <summary>
        /// Exits a registrant from their line and sets their exit time
        /// </summary>
        /// <param name="leaveEvent"></param>
        private void DequeueRegistrant(RegistrationEvent leaveEvent)
        {
            Registrant CorrespondingRegistrant;             //registrant that matches current leave event
            int i;                                          //loop variable

            CorrespondingRegistrant = null;                 //set default to null
            for (i = 0; i < RegistrantList.Count; i++)
            {
                if (leaveEvent.RegistrantNumber == RegistrantList[i].RegistrantNumber)
                {
                    CorrespondingRegistrant = RegistrantList[i];
                }
                if(i == RegistrantList.Count - 1)
                {
                    LastExitTime = CorrespondingRegistrant.LeaveEvent.Time;
                }
            }//end for(i)

            //Console.WriteLine(CorrespondingRegistrant.RegistrantNumber + "Finish time:  " + CorrespondingRegistrant.LeaveEvent.Time);

            CorrespondingRegistrant.CurrentLine.Dequeue();
        }//end DequeueRegistrant(RegistrationEvent)

        /// <summary>
        /// Processes one enter or leave event for the registrant
        /// </summary>
        /// <returns></returns>
        public string ProcessOneEvent()
        {
            if (RegistrationEventQueue.Peek().Type == EVENTTYPE.ENTER)
            {
                //handles enter event
                AddRegistrantToShortestLine(RegistrationEventQueue.Peek());
                RegistrationEventQueue.Dequeue();
            }
            else
            {
                //handles leaving events
                DequeueRegistrant(RegistrationEventQueue.Peek());


                RegistrationEventQueue.Dequeue();
            }

            return GenerateCurrentOutput();
        }//end ProcessOneEvent()

        /// <summary>
        /// Generates the coutput string based on the number
        /// of registration lines and the number of registrants in each line
        /// </summary>
        /// <returns></returns>
        private string GenerateCurrentOutput()
        {
            int i;                              //loop variable
            int j;                              //loop variable
            CurrentSimulationOutput = "";

            for (j = 0; j < RegistrationLines.Count; j++)
            {
                CurrentSimulationOutput += "Booth [" + (j + 1) + "]:  ";
                for (i = 0; i < RegistrationLines[j].Count; i++)
                {
                    CurrentSimulationOutput += "* ";
                }
                CurrentSimulationOutput += "\n";
            }
            return CurrentSimulationOutput;
        }//end GenerateCurrentOutput()

        /// <summary>
        /// Adds registrant queues to the list of lines
        /// </summary>
        public void GenerateRegistrationLines()
        {
            int i;                              //loop variable

            for (i = 0; i < NumberOfRegistrationWindows; i++)
            {
                RegistrationLines.Add(new Queue<Registrant>());
            }//end for(i)
        }//end GenerateRegistrationLines()
        #endregion
    }//end ConventionRegistration
}//end namespace
