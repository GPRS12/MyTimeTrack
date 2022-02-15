using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTimeTrack
{
    public partial class MainForm : Form
    {
        OptionsForm options = new OptionsForm();
        AboutForm about = new AboutForm();
        
        public MainForm()
        {
            InitializeComponent();

            this.prodHoursNameLabel.Enabled = false;
            this.ProdTimeLabel.Enabled = false;
            this.ProdTimeLabel.Text = " ";

            this.LogInNameLabel.Enabled = false;
            this.logInTimeLabel.Enabled = false;
            this.logInTimeLabel.Text = " ";

            this.LogOutNameLabel.Enabled = false;
            this.logOutTimeLabel.Enabled = false;
            this.logOutTimeLabel.Text = " ";

            this.totalTimeNameLabel.Enabled = false;
            this.totalTimeLabel.Enabled = false;
            this.totalTimeLabel.Text = " ";

            this.totalTimeWastedNameLabel.Enabled = false;
            this.totalTimeWastedLabel.Enabled = false;
            this.totalTimeWastedLabel.Text = " ";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            options.ShowDialog();
        }

        private void prodHoursNameLabel_Click (object sender, EventArgs e)
        {

        }

        private void ProdTimeLabel_Click (object sender, EventArgs e)
        {

        }

        private void totalTimeWastedNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTimeWastedLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogOutNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
