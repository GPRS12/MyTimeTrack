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
    public partial class OptionsForm : Form
    {
        public string envirornmentVar;
        public string selectedFolderPath;
        public OptionsForm()
        {
            InitializeComponent();
            
            envirornmentVar = Environment.GetEnvironmentVariable("Time_Track_LOGPath", EnvironmentVariableTarget.User);
            if (envirornmentVar != null)
            {
                selectPathTextBox.Text = Environment.GetEnvironmentVariable("Time_Track_LOGPath", EnvironmentVariableTarget.User);
            }
            else
            {
                selectPathTextBox.Text = "Select folder for storing the data!";
            }
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    selectPathTextBox.Text = folderDialog.SelectedPath;
                    selectedFolderPath = folderDialog.SelectedPath;
                    break;
                default:
                    break;
            }
        }

        private void setPathButton_Click(object sender, EventArgs e)
        {
            envirornmentVar = Environment.GetEnvironmentVariable("Time_Track_LOGPath", EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("Time_Track_LOGPath", selectedFolderPath, EnvironmentVariableTarget.User);
            MessageBox.Show("Path Set!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
