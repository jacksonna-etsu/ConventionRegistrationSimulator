/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         PrimaryWindow.cs
//	Description:       The PrimaryWindow - Interfaces with the user and runs the simulation
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Michael Malone, malonema@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Michael Malone, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresProject4
{
    /// <summary>
    /// Main window for output to the user
    /// </summary>
    public partial class PrimaryWindow : Form
    {

        ConventionRegistration RegistrationSimulation;

        /// <summary>
        /// Default Constructor - Runs the primary window
        /// </summary>
        public PrimaryWindow()
        {
            InitializeComponent();
            RegistrationSimulation = null;
        }//end PrimaryWindow()

        /// <summary>
        /// Click event handler for the "Exit Application" item in the menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end exitApplicationToolStripMenuItem_Click(object, EventArgs)

        /// <summary>
        /// Loads the primary window for use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimaryWindow_Load(object sender, EventArgs e)
        {
            
        }//end PrimaryWindow_Load(object, EventArgs)

        /// <summary>
        /// Handles the click event of the ExitButton - exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end ExitButton_Click(object, EventArgs)

        /// <summary>
        /// Handles the click event of the RunButton - runs the simulation
        /// with whichever values are in the Input text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunButton_Click(object sender, EventArgs e)
        {
            RegistrationSimulation = new ConventionRegistration(Double.Parse(PeopleBox.Text),
                                                                                       Double.Parse(avgTimeBox.Text),
                                                                                       Double.Parse(minTimeBox.Text),
                                                                                       int.Parse(HoursBox.Text),
                                                                                       int.Parse(WindowsBox.Text));
            RegistrationSimulation.GenerateRegistrationLines();
            timer1.Interval = 1;
            timer1.Start();
        }//end RunButton_Click(object, EventArgs)

        /// <summary>
        /// Handles the click event of the AboutToolStripMenuItem - opens
        /// a messagebox showing information about the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simulation for a convention center event to aid in determining " +
                            "how many registration windows will need to be staffed in order to keep " +
                            "lines at a reasonable length. This application was developed by Michael " +
                            "Malone and Nathaniel Jackson as a class projecr for Don Bailes's Data " +
                            "Structures course.", "About ConventionRegistrationSimulation");
        }//end aboutToolStripMenuItem_Click(object, EventArgs)

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RegistrationSimulation != null)
            {
                if (RegistrationSimulation.RegistrationEventQueue.Count > 0)
                {
                    SimulationOutputLabel.Text = RegistrationSimulation.ProcessOneEvent();
                }
                else
                {
                    RegistrationSimulation.AverageTime = RegistrationSimulation.AverageTime / RegistrationSimulation.ExpectedNumberOfRegistrants;
                    LongestLineBox.Text = RegistrationSimulation.LongestLine.ToString();
                    AverageTimeBox.Text = RegistrationSimulation.AverageTime.ToString().Substring(0, 4);
                    LastExitBox.Text = RegistrationSimulation.LastExitTime.ToShortTimeString();
                    timer1.Stop();
                }
            }
        }//end timer1_Tick(object, EventArgs)

        private void SimulationOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }//end PrimaryWindow
}//end namespace
