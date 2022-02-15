using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Microsoft.Win32;

namespace MyTimeTrack
{
    public partial class MainClass : ApplicationContext
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextOptionsMenuStrip = new ContextMenuStrip();
        private ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
        public ToolStripMenuItem logInMenuStrip = new ToolStripMenuItem();
        public ToolStripMenuItem logOutMenuStrip = new ToolStripMenuItem();
        public ToolStripMenuItem pauseMenuStrip = new ToolStripMenuItem();
        private ToolStripMenuItem exitMenuStrip = new ToolStripMenuItem();
        Timer timer = new Timer();
        TimeSpan LogInTime = new TimeSpan (0, 0, 0);
        TimeSpan LogOutTime = new TimeSpan (0, 0, 0);
        TimeSpan IntermediateTime1 = new TimeSpan (0, 0, 0);
        TimeSpan IntermediateTime2 = new TimeSpan (0, 0, 0);
        TimeSpan ShortTimes = new TimeSpan(0,0,0);
        TimeSpan TimeGood = new TimeSpan (0,0,0);
        TimeSpan TimeWasted = new TimeSpan (0, 0, 0);
        TimeSpan TimeTotal = new TimeSpan (0, 0, 0);

        public MainForm MainForm;
        public bool PClockedFlag = false;
        public bool pausedFlag = false;

        public  MainClass()
        {
            IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);

            InitializeComponent();
       
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "Time Tracker";
            notifyIcon.Icon = Properties.Resources.CC11;
            notifyIcon.DoubleClick += new EventHandler(notifyIcon_DoubleClick);
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "Information!";
            notifyIcon.BalloonTipText = "Log in to start for Today!";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
            notifyIcon.ContextMenuStrip = contextOptionsMenuStrip;

            this.logInMenuStrip.Enabled     = true;
            this.pauseMenuStrip.Enabled     = false;
            this.logOutMenuStrip.Enabled    = false;

            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Interval = 1000;
            
            MainForm = new MainForm();
            notifyIcon.Text = MainForm.Text;
        }

        private void InitializeComponent()
        {
            this.contextOptionsMenuStrip.SuspendLayout();
            // 
            // contextOptionsMenuStrip
            // 
            this.contextOptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInMenuStrip,
            this.pauseMenuStrip,
            this.logOutMenuStrip,
            this.toolStripSeparator1,
            this.exitMenuStrip});
            this.contextOptionsMenuStrip.Name = "contextOptionsMenuStrip";
            this.contextOptionsMenuStrip.Size = new System.Drawing.Size(118, 76);
            // 
            // logInMenuStrip
            // 
            this.logInMenuStrip.Name = "logInMenuStrip";
            this.logInMenuStrip.Size = new System.Drawing.Size(117, 22);
            this.logInMenuStrip.Text = "Log In";
            this.logInMenuStrip.Click += new System.EventHandler(this.logInMenuStrip_Click);
            // 
            // logOutMenuStrip
            // 
            this.logOutMenuStrip.Name = "logOutMenuStrip";
            this.logOutMenuStrip.Size = new System.Drawing.Size(117, 22);
            this.logOutMenuStrip.Text = "Log Out";
            this.logOutMenuStrip.Click += new System.EventHandler(this.logOutMenuStrip_Click);
            // 
            // PauseMenuStrip
            // 
            this.pauseMenuStrip.Name = "pauseMenuStrip";
            this.pauseMenuStrip.Size = new System.Drawing.Size(117, 22);
            this.pauseMenuStrip.Text = "Pause";
            this.pauseMenuStrip.Click += new System.EventHandler(this.pauseMenuStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.Size = new System.Drawing.Size(117, 22);
            this.exitMenuStrip.Text = "Exit";
            this.exitMenuStrip.Click += new System.EventHandler(this.CloseMenuItem_Click);
            this.contextOptionsMenuStrip.ResumeLayout(false);
        }

        void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                PClockedFlag = true;
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                PClockedFlag = false;
            }
        }

        void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!MainForm.Visible)
            {
                MainForm.ShowDialog();
            }
        }

        void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really wanna exit the software?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            IntermediateTime2 = DateTime.Now.TimeOfDay;
            if (PClockedFlag || pausedFlag)
            {
                TimeWasted = TimeWasted.Add (IntermediateTime2.Subtract (IntermediateTime1));
            }
            else
            {
                TimeGood = TimeGood.Add (IntermediateTime2.Subtract (IntermediateTime1));
            }
            IntermediateTime1 = IntermediateTime2;
            TimeTotal = TimeGood.Add (TimeWasted);

            MainForm.ProdTimeLabel.Text = TimeGood.Hours.ToString() + "Hrs " + TimeGood.Minutes.ToString() + "Mins ";
            MainForm.totalTimeLabel.Text = TimeTotal.Hours.ToString() + "Hrs " + TimeTotal.Minutes.ToString() + "Mins ";
            MainForm.totalTimeWastedLabel.Text = TimeWasted.Hours.ToString() + "Hrs " + TimeWasted.Minutes.ToString() + "Mins ";

            if (TimeTotal.Hours <= 9)
            {
                MainForm.totalTimeLabel.ForeColor = Color.Black;
            }
            if (TimeTotal.Hours > 9 && TimeTotal.Hours < 11)
            {
                MainForm.totalTimeLabel.ForeColor = Color.Green;
            }
            if (TimeTotal.Hours > 11)
            {
                MainForm.totalTimeLabel.ForeColor = Color.Red;
            }

            if (TimeGood.Hours <= 8.5)
            {
                MainForm.ProdTimeLabel.ForeColor = Color.Black;
            }
            if (TimeGood.Hours > 8.5 && TimeTotal.Hours <= 10)
            {
                MainForm.ProdTimeLabel.ForeColor = Color.Green;
            }
            if (TimeGood.Hours > 10)
            {
                MainForm.ProdTimeLabel.ForeColor = Color.Red;
            }

            this.notifyIcon.Text = "Its been " + TimeTotal.Hours.ToString () + "Hrs " + TimeTotal.Minutes.ToString () + "Min since you've logged in!";
        }

        private void logInMenuStrip_Click(object sender, EventArgs e)
        {
            MainForm.logInTimeLabel.Text = DateTime.Now.ToShortTimeString();
            LogInTime = DateTime.Now.TimeOfDay;
            IntermediateTime1 = DateTime.Now.TimeOfDay;
            logInMenuStrip.Enabled = false;
            pauseMenuStrip.Enabled = true;
            logOutMenuStrip.Enabled = true;
            this.timer.Enabled = true;
            this.timer.Start();
            MainForm.totalTimeLabel.ForeColor = Color.Black;
            MainForm.ProdTimeLabel.ForeColor = Color.Black;
            this.notifyIcon.Text = "Tracking has been started!";
            MainForm.LogInNameLabel.Enabled = true;
            MainForm.logInTimeLabel.Enabled = true;

            MainForm.LogOutNameLabel.Enabled = false;
            MainForm.logOutTimeLabel.Enabled = false;
            MainForm.logOutTimeLabel.Text = " ";

            MainForm.totalTimeNameLabel.Enabled = true;
            MainForm.totalTimeLabel.Enabled = true;
            MainForm.totalTimeLabel.Text = "0Hrs 0Mins";

            MainForm.prodHoursNameLabel.Enabled = true;
            MainForm.ProdTimeLabel.Enabled = true;
            MainForm.ProdTimeLabel.Text = "0Hrs 0Mins";
            
            MainForm.totalTimeWastedNameLabel.Enabled = true;
            MainForm.totalTimeWastedLabel.Enabled = true;
            MainForm.totalTimeWastedLabel.Text = "0Hrs 0Mins";
        }

        private void logOutMenuStrip_Click(object sender, EventArgs e)
        {
            MainForm.LogOutNameLabel.Enabled = true;
            MainForm.logOutTimeLabel.Enabled = true;
            pauseMenuStrip.Enabled = false;
            MainForm.logOutTimeLabel.Text = DateTime.Now.ToShortTimeString();

            LogOutTime = DateTime.Now.TimeOfDay;
            ShortTimes = new TimeSpan (0, 0, 0);
            IntermediateTime1 = new TimeSpan (0, 0, 0);
            IntermediateTime2 = new TimeSpan (0, 0, 0);
            TimeGood = new TimeSpan (0, 0, 0);
            TimeWasted = new TimeSpan (0, 0, 0);
            TimeTotal = new TimeSpan (0, 0, 0);           

            logInMenuStrip.Enabled = true;
            logOutMenuStrip.Enabled = false;
            this.timer.Stop();
            this.notifyIcon.Text = "Tracking has been stopped!";
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void pauseMenuStrip_Click(object sender, EventArgs e)
        {
            if (pausedFlag)
            {
                pauseMenuStrip.Text = "Pause";
                MainForm.totalTimeWastedLabel.ForeColor = Color.Black;
                pausedFlag = false;
            }
            else
            {
                pauseMenuStrip.Text = "Continue";
                MainForm.totalTimeWastedLabel.ForeColor = Color.Gray;
                pausedFlag = true;
            }
        }
    }
}
