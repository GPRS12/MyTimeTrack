namespace MyTimeTrack
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOutTimeLabel = new System.Windows.Forms.Label();
            this.LogOutNameLabel = new System.Windows.Forms.Label();
            this.logInTimeLabel = new System.Windows.Forms.Label();
            this.LogInNameLabel = new System.Windows.Forms.Label();
            this.totalTimeNameLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProdTimeLabel = new System.Windows.Forms.Label();
            this.totalTimeWastedLabel = new System.Windows.Forms.Label();
            this.prodHoursNameLabel = new System.Windows.Forms.Label();
            this.totalTimeWastedNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logOutTimeLabel);
            this.groupBox1.Controls.Add(this.LogOutNameLabel);
            this.groupBox1.Controls.Add(this.logInTimeLabel);
            this.groupBox1.Controls.Add(this.LogInNameLabel);
            this.groupBox1.Controls.Add(this.totalTimeNameLabel);
            this.groupBox1.Controls.Add(this.totalTimeLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info :";
            // 
            // logOutTimeLabel
            // 
            this.logOutTimeLabel.AutoSize = true;
            this.logOutTimeLabel.Location = new System.Drawing.Point(270, 16);
            this.logOutTimeLabel.Name = "logOutTimeLabel";
            this.logOutTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.logOutTimeLabel.TabIndex = 3;
            this.logOutTimeLabel.Text = "TIME here";
            // 
            // LogOutNameLabel
            // 
            this.LogOutNameLabel.AutoSize = true;
            this.LogOutNameLabel.Location = new System.Drawing.Point(214, 16);
            this.LogOutNameLabel.Name = "LogOutNameLabel";
            this.LogOutNameLabel.Size = new System.Drawing.Size(51, 13);
            this.LogOutNameLabel.TabIndex = 2;
            this.LogOutNameLabel.Text = "Log Out :";
            this.LogOutNameLabel.Click += new System.EventHandler(this.LogOutNameLabel_Click);
            // 
            // logInTimeLabel
            // 
            this.logInTimeLabel.AutoSize = true;
            this.logInTimeLabel.Location = new System.Drawing.Point(58, 16);
            this.logInTimeLabel.Name = "logInTimeLabel";
            this.logInTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.logInTimeLabel.TabIndex = 1;
            this.logInTimeLabel.Text = "TIME here";
            // 
            // LogInNameLabel
            // 
            this.LogInNameLabel.AutoSize = true;
            this.LogInNameLabel.Location = new System.Drawing.Point(6, 16);
            this.LogInNameLabel.Name = "LogInNameLabel";
            this.LogInNameLabel.Size = new System.Drawing.Size(43, 13);
            this.LogInNameLabel.TabIndex = 0;
            this.LogInNameLabel.Text = "Log In :";
            // 
            // totalTimeNameLabel
            // 
            this.totalTimeNameLabel.AutoSize = true;
            this.totalTimeNameLabel.Location = new System.Drawing.Point(123, 96);
            this.totalTimeNameLabel.Name = "totalTimeNameLabel";
            this.totalTimeNameLabel.Size = new System.Drawing.Size(96, 13);
            this.totalTimeNameLabel.TabIndex = 4;
            this.totalTimeNameLabel.Text = "Total Time Today :";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalTimeLabel.Location = new System.Drawing.Point(70, 110);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(103, 39);
            this.totalTimeLabel.TabIndex = 5;
            this.totalTimeLabel.Text = "TIME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProdTimeLabel);
            this.groupBox2.Controls.Add(this.totalTimeWastedLabel);
            this.groupBox2.Controls.Add(this.prodHoursNameLabel);
            this.groupBox2.Controls.Add(this.totalTimeWastedNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(9, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // ProdTimeLabel
            // 
            this.ProdTimeLabel.AutoSize = true;
            this.ProdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTimeLabel.Location = new System.Drawing.Point(11, 34);
            this.ProdTimeLabel.Name = "ProdTimeLabel";
            this.ProdTimeLabel.Size = new System.Drawing.Size(44, 17);
            this.ProdTimeLabel.TabIndex = 7;
            this.ProdTimeLabel.Text = "TIME";
            this.ProdTimeLabel.Click += new System.EventHandler(this.ProdTimeLabel_Click);
            // 
            // totalTimeWastedLabel
            // 
            this.totalTimeWastedLabel.AutoSize = true;
            this.totalTimeWastedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeWastedLabel.Location = new System.Drawing.Point(225, 34);
            this.totalTimeWastedLabel.Name = "totalTimeWastedLabel";
            this.totalTimeWastedLabel.Size = new System.Drawing.Size(44, 17);
            this.totalTimeWastedLabel.TabIndex = 9;
            this.totalTimeWastedLabel.Text = "TIME";
            this.totalTimeWastedLabel.Click += new System.EventHandler(this.totalTimeWastedLabel_Click);
            // 
            // prodHoursNameLabel
            // 
            this.prodHoursNameLabel.AutoSize = true;
            this.prodHoursNameLabel.Location = new System.Drawing.Point(11, 16);
            this.prodHoursNameLabel.Name = "prodHoursNameLabel";
            this.prodHoursNameLabel.Size = new System.Drawing.Size(95, 13);
            this.prodHoursNameLabel.TabIndex = 6;
            this.prodHoursNameLabel.Text = "Productive Hours :";
            this.prodHoursNameLabel.Click += new System.EventHandler(this.prodHoursNameLabel_Click);
            // 
            // totalTimeWastedNameLabel
            // 
            this.totalTimeWastedNameLabel.AutoSize = true;
            this.totalTimeWastedNameLabel.Location = new System.Drawing.Point(243, 16);
            this.totalTimeWastedNameLabel.Name = "totalTimeWastedNameLabel";
            this.totalTimeWastedNameLabel.Size = new System.Drawing.Size(56, 13);
            this.totalTimeWastedNameLabel.TabIndex = 8;
            this.totalTimeWastedNameLabel.Text = "Time Idle :";
            this.totalTimeWastedNameLabel.Click += new System.EventHandler(this.totalTimeWastedNameLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "My Time Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label logOutTimeLabel;
        public System.Windows.Forms.Label LogOutNameLabel;
        public System.Windows.Forms.Label logInTimeLabel;
        public System.Windows.Forms.Label LogInNameLabel;
        public System.Windows.Forms.Label totalTimeLabel;
        public System.Windows.Forms.Label totalTimeNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Label prodHoursNameLabel;
        public System.Windows.Forms.Label ProdTimeLabel;
        public System.Windows.Forms.Label totalTimeWastedLabel;
        public System.Windows.Forms.Label totalTimeWastedNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

