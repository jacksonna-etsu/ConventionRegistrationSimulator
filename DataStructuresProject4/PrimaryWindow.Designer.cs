/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject4/DataStructuresProject4
//	File Name:         PrimaryWindow.Designer.cs
//	Description:       Designer class for the PrimaryWindow
//	Course:            CSCI 2210 - Data Structures - Section 002	
//	Author:            Michael Malone, malonema@etsu.edu
//	Created:           Sunday, November 11, 2018
//	Copyright:         Michael Malone, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DataStructuresProject4
{
    /// <summary>
    /// Sets up the controls for the PrimaryWindow
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class PrimaryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Input = new System.Windows.Forms.Panel();
            this.minTimeBox = new System.Windows.Forms.TextBox();
            this.minTimeLabel = new System.Windows.Forms.Label();
            this.avgTimeBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WindowsBox = new System.Windows.Forms.TextBox();
            this.PeopleBox = new System.Windows.Forms.TextBox();
            this.HoursBox = new System.Windows.Forms.TextBox();
            this.WindowsLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Panel();
            this.LastExitBox = new System.Windows.Forms.TextBox();
            this.AverageTimeBox = new System.Windows.Forms.TextBox();
            this.LongestLineBox = new System.Windows.Forms.TextBox();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SimulationOutputLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Input.SuspendLayout();
            this.Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.BackgroundImage = global::DataStructuresProject4.Properties.Resources.Background;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Transparent;
            this.Input.Controls.Add(this.minTimeBox);
            this.Input.Controls.Add(this.minTimeLabel);
            this.Input.Controls.Add(this.avgTimeBox);
            this.Input.Controls.Add(this.TimeLabel);
            this.Input.Controls.Add(this.WindowsBox);
            this.Input.Controls.Add(this.PeopleBox);
            this.Input.Controls.Add(this.HoursBox);
            this.Input.Controls.Add(this.WindowsLabel);
            this.Input.Controls.Add(this.PeopleLabel);
            this.Input.Controls.Add(this.HoursLabel);
            this.Input.Location = new System.Drawing.Point(0, 31);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(578, 395);
            this.Input.TabIndex = 1;
            // 
            // minTimeBox
            // 
            this.minTimeBox.Location = new System.Drawing.Point(374, 336);
            this.minTimeBox.Name = "minTimeBox";
            this.minTimeBox.Size = new System.Drawing.Size(100, 22);
            this.minTimeBox.TabIndex = 9;
            this.minTimeBox.Text = "1.5";
            // 
            // minTimeLabel
            // 
            this.minTimeLabel.AutoSize = true;
            this.minTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTimeLabel.Location = new System.Drawing.Point(18, 339);
            this.minTimeLabel.Name = "minTimeLabel";
            this.minTimeLabel.Size = new System.Drawing.Size(295, 20);
            this.minTimeLabel.TabIndex = 8;
            this.minTimeLabel.Text = "Minimum Registration Time (minutes):";
            // 
            // avgTimeBox
            // 
            this.avgTimeBox.Location = new System.Drawing.Point(374, 262);
            this.avgTimeBox.Name = "avgTimeBox";
            this.avgTimeBox.Size = new System.Drawing.Size(100, 22);
            this.avgTimeBox.TabIndex = 7;
            this.avgTimeBox.Text = "4.25";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(18, 265);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(288, 20);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Average Registration Time (minutes):";
            // 
            // WindowsBox
            // 
            this.WindowsBox.Location = new System.Drawing.Point(374, 186);
            this.WindowsBox.Name = "WindowsBox";
            this.WindowsBox.Size = new System.Drawing.Size(100, 22);
            this.WindowsBox.TabIndex = 5;
            this.WindowsBox.Text = "6";
            // 
            // PeopleBox
            // 
            this.PeopleBox.Location = new System.Drawing.Point(374, 108);
            this.PeopleBox.Name = "PeopleBox";
            this.PeopleBox.Size = new System.Drawing.Size(100, 22);
            this.PeopleBox.TabIndex = 4;
            this.PeopleBox.Text = "1000";
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(374, 29);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(100, 22);
            this.HoursBox.TabIndex = 3;
            this.HoursBox.Text = "10";
            // 
            // WindowsLabel
            // 
            this.WindowsLabel.AutoSize = true;
            this.WindowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsLabel.Location = new System.Drawing.Point(18, 186);
            this.WindowsLabel.Name = "WindowsLabel";
            this.WindowsLabel.Size = new System.Drawing.Size(223, 20);
            this.WindowsLabel.TabIndex = 2;
            this.WindowsLabel.Text = "Number of Windows Staffed:";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleLabel.Location = new System.Drawing.Point(18, 108);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(150, 20);
            this.PeopleLabel.TabIndex = 1;
            this.PeopleLabel.Text = "Estimated People: ";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(18, 29);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(110, 20);
            this.HoursLabel.TabIndex = 0;
            this.HoursLabel.Text = "Hours Open: ";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.Controls.Add(this.LastExitBox);
            this.Output.Controls.Add(this.AverageTimeBox);
            this.Output.Controls.Add(this.LongestLineBox);
            this.Output.Controls.Add(this.ExitLabel);
            this.Output.Controls.Add(this.WaitLabel);
            this.Output.Controls.Add(this.LengthLabel);
            this.Output.Location = new System.Drawing.Point(592, 31);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(578, 223);
            this.Output.TabIndex = 2;
            // 
            // LastExitBox
            // 
            this.LastExitBox.Location = new System.Drawing.Point(322, 186);
            this.LastExitBox.Name = "LastExitBox";
            this.LastExitBox.Size = new System.Drawing.Size(100, 22);
            this.LastExitBox.TabIndex = 5;
            // 
            // AverageTimeBox
            // 
            this.AverageTimeBox.Location = new System.Drawing.Point(322, 102);
            this.AverageTimeBox.Name = "AverageTimeBox";
            this.AverageTimeBox.Size = new System.Drawing.Size(100, 22);
            this.AverageTimeBox.TabIndex = 4;
            // 
            // LongestLineBox
            // 
            this.LongestLineBox.Location = new System.Drawing.Point(322, 29);
            this.LongestLineBox.Name = "LongestLineBox";
            this.LongestLineBox.Size = new System.Drawing.Size(100, 22);
            this.LongestLineBox.TabIndex = 3;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.Location = new System.Drawing.Point(21, 186);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(127, 20);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Last Exit Time: ";
            // 
            // WaitLabel
            // 
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitLabel.Location = new System.Drawing.Point(21, 108);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(198, 20);
            this.WaitLabel.TabIndex = 1;
            this.WaitLabel.Text = "Average Time (minutes): ";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.Location = new System.Drawing.Point(21, 29);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(143, 20);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Max Line Length: ";
            // 
            // SimulationOutputLabel
            // 
            this.SimulationOutputLabel.AutoSize = true;
            this.SimulationOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.SimulationOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulationOutputLabel.Location = new System.Drawing.Point(587, 269);
            this.SimulationOutputLabel.MinimumSize = new System.Drawing.Size(3000, 3000);
            this.SimulationOutputLabel.Name = "SimulationOutputLabel";
            this.SimulationOutputLabel.Size = new System.Drawing.Size(3000, 3000);
            this.SimulationOutputLabel.TabIndex = 6;
            this.SimulationOutputLabel.Text = "Output Window";
            this.SimulationOutputLabel.Click += new System.EventHandler(this.SimulationOutputLabel_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(12, 448);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(274, 92);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run Simulation";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(307, 449);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(274, 91);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit Application";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrimaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataStructuresProject4.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.SimulationOutputLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "PrimaryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convention Registration Simulation";
            this.Load += new System.EventHandler(this.PrimaryWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel Input;
        private System.Windows.Forms.Panel Output;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WindowsLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label WaitLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox WindowsBox;
        private System.Windows.Forms.TextBox PeopleBox;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.TextBox LastExitBox;
        private System.Windows.Forms.TextBox AverageTimeBox;
        private System.Windows.Forms.TextBox LongestLineBox;
        private System.Windows.Forms.TextBox avgTimeBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox minTimeBox;
        private System.Windows.Forms.Label minTimeLabel;
        private System.Windows.Forms.Label SimulationOutputLabel;
        private System.Windows.Forms.Timer timer1;
    }//end PrimaryWindow
}//end namespace

