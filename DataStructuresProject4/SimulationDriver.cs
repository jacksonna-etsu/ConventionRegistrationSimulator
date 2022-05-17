///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         SimulationDriver.cs
//	Description:       SimulationDriver - runs the splash screen and kicks off execution of the simulation
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Michael Malone, malonema@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Michael Malone, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresProject4
{
    /// <summary>
    /// Driver class - handles launching of the program and splash screen
    /// </summary>
    static class SimulationDriver
    {
        /// <summary>
        /// The main entry point for the application - Runs the splash screen for the simulation.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }//end Main()
    }//end SimulationDriver
}//end namespace
