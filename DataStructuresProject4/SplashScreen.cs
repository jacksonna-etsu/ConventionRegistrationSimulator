///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         SplashScreen.cs
//	Description:       The SplashScreen - used to display relevant information about the application
//                          before its launch
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresProject4
{
    /// <summary>
    /// SplashScreen - launches, runs a progress bar while displaying
    /// important, relevation information and then launches into the simulation
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Default constructor for the SplashScreen class - displays the splash screen
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }//end SplashScreen()

        /// <summary>
        /// Handles the Tick event of the timer1 control. Timer is used to 
        /// only display the splash screen for a couple seconds before
        /// timing out and going to the main window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                new PrimaryWindow().ShowDialog();
            }
        }//end timer1_Tick_1(object, EventArgs)
    }//end SplashScreen
}//end namespace
