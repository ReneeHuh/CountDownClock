namespace CountDownClock
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btStopReset = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lblMinsSec = new System.Windows.Forms.Label();
            this.tb1Min = new System.Windows.Forms.Button();
            this.tb5Min = new System.Windows.Forms.Button();
            this.tb10Min = new System.Windows.Forms.Button();
            this.tb45Min = new System.Windows.Forms.Button();
            this.tb30Min = new System.Windows.Forms.Button();
            this.tb15Min = new System.Windows.Forms.Button();
            this.tb30Sec = new System.Windows.Forms.Button();
            this.tb60Min = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arborWingcomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arborWingcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIndicator2 = new System.Windows.Forms.Label();
            this.lblIndicator3 = new System.Windows.Forms.Label();
            this.bt1Sec = new System.Windows.Forms.Button();
            this.lblIndicator4 = new System.Windows.Forms.Label();
            this.lblIndicator1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStopReset
            // 
            this.btStopReset.BackColor = System.Drawing.Color.White;
            this.btStopReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btStopReset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStopReset.Location = new System.Drawing.Point(10, 120);
            this.btStopReset.Name = "btStopReset";
            this.btStopReset.Size = new System.Drawing.Size(85, 36);
            this.btStopReset.TabIndex = 0;
            this.btStopReset.Text = "Reset";
            this.btStopReset.UseVisualStyleBackColor = false;
            this.btStopReset.Click += new System.EventHandler(this.btStopReset_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.White;
            this.btStart.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(107, 120);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(88, 36);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblMinsSec
            // 
            this.lblMinsSec.AutoSize = true;
            this.lblMinsSec.BackColor = System.Drawing.Color.White;
            this.lblMinsSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinsSec.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinsSec.Location = new System.Drawing.Point(11, 35);
            this.lblMinsSec.Name = "lblMinsSec";
            this.lblMinsSec.Size = new System.Drawing.Size(180, 54);
            this.lblMinsSec.TabIndex = 2;
            this.lblMinsSec.Text = "888:88";
            this.lblMinsSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb1Min
            // 
            this.tb1Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb1Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1Min.Location = new System.Drawing.Point(135, 168);
            this.tb1Min.Name = "tb1Min";
            this.tb1Min.Size = new System.Drawing.Size(60, 23);
            this.tb1Min.TabIndex = 5;
            this.tb1Min.Text = "1 Min";
            this.tb1Min.UseVisualStyleBackColor = false;
            this.tb1Min.Click += new System.EventHandler(this.tb1Min_Click);
            // 
            // tb5Min
            // 
            this.tb5Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb5Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5Min.Location = new System.Drawing.Point(10, 197);
            this.tb5Min.Name = "tb5Min";
            this.tb5Min.Size = new System.Drawing.Size(60, 23);
            this.tb5Min.TabIndex = 6;
            this.tb5Min.Text = "5 Min";
            this.tb5Min.UseVisualStyleBackColor = false;
            this.tb5Min.Click += new System.EventHandler(this.tb5Min_Click);
            // 
            // tb10Min
            // 
            this.tb10Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb10Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb10Min.Location = new System.Drawing.Point(73, 197);
            this.tb10Min.Name = "tb10Min";
            this.tb10Min.Size = new System.Drawing.Size(60, 23);
            this.tb10Min.TabIndex = 7;
            this.tb10Min.Text = "10 Min";
            this.tb10Min.UseVisualStyleBackColor = false;
            this.tb10Min.Click += new System.EventHandler(this.tb10Min_Click);
            // 
            // tb45Min
            // 
            this.tb45Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb45Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb45Min.Location = new System.Drawing.Point(73, 224);
            this.tb45Min.Name = "tb45Min";
            this.tb45Min.Size = new System.Drawing.Size(60, 23);
            this.tb45Min.TabIndex = 10;
            this.tb45Min.Text = "45 Min";
            this.tb45Min.UseVisualStyleBackColor = false;
            this.tb45Min.Click += new System.EventHandler(this.tb45Min_Click);
            // 
            // tb30Min
            // 
            this.tb30Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb30Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb30Min.Location = new System.Drawing.Point(10, 224);
            this.tb30Min.Name = "tb30Min";
            this.tb30Min.Size = new System.Drawing.Size(60, 23);
            this.tb30Min.TabIndex = 9;
            this.tb30Min.Text = "30 Min";
            this.tb30Min.UseVisualStyleBackColor = false;
            this.tb30Min.Click += new System.EventHandler(this.tb30Min_Click);
            // 
            // tb15Min
            // 
            this.tb15Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb15Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb15Min.Location = new System.Drawing.Point(136, 197);
            this.tb15Min.Name = "tb15Min";
            this.tb15Min.Size = new System.Drawing.Size(60, 23);
            this.tb15Min.TabIndex = 8;
            this.tb15Min.Text = "15 Min";
            this.tb15Min.UseVisualStyleBackColor = false;
            this.tb15Min.Click += new System.EventHandler(this.tb15Min_Click);
            // 
            // tb30Sec
            // 
            this.tb30Sec.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb30Sec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb30Sec.Location = new System.Drawing.Point(72, 168);
            this.tb30Sec.Name = "tb30Sec";
            this.tb30Sec.Size = new System.Drawing.Size(60, 23);
            this.tb30Sec.TabIndex = 11;
            this.tb30Sec.Text = "15 Sec";
            this.tb30Sec.UseVisualStyleBackColor = false;
            this.tb30Sec.Click += new System.EventHandler(this.tb30Sec_Click);
            // 
            // tb60Min
            // 
            this.tb60Min.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb60Min.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb60Min.Location = new System.Drawing.Point(136, 224);
            this.tb60Min.Name = "tb60Min";
            this.tb60Min.Size = new System.Drawing.Size(60, 23);
            this.tb60Min.TabIndex = 12;
            this.tb60Min.Text = "60 Min";
            this.tb60Min.UseVisualStyleBackColor = false;
            this.tb60Min.Click += new System.EventHandler(this.tb60Min_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.arborWingcomToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // arborWingcomToolStripMenuItem1
            // 
            this.arborWingcomToolStripMenuItem1.Name = "arborWingcomToolStripMenuItem1";
            this.arborWingcomToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.arborWingcomToolStripMenuItem1.Text = "ArborWing.com";
            this.arborWingcomToolStripMenuItem1.Click += new System.EventHandler(this.arborWingcomToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
             // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem.Text = "Help";
            // 
            // perfeToolStripMenuItem
            // 
            this.perfeToolStripMenuItem.Name = "perfeToolStripMenuItem";
            this.perfeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.perfeToolStripMenuItem.Text = "Options";
            // 
            // arborWingcomToolStripMenuItem
            // 
            this.arborWingcomToolStripMenuItem.Name = "arborWingcomToolStripMenuItem";
            this.arborWingcomToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.arborWingcomToolStripMenuItem.Text = "ArborWing.com";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // lblIndicator2
            // 
            this.lblIndicator2.AutoSize = true;
            this.lblIndicator2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator2.ForeColor = System.Drawing.Color.Green;
            this.lblIndicator2.Location = new System.Drawing.Point(70, 89);
            this.lblIndicator2.Name = "lblIndicator2";
            this.lblIndicator2.Size = new System.Drawing.Size(25, 29);
            this.lblIndicator2.TabIndex = 14;
            this.lblIndicator2.Text = "-";
            this.lblIndicator2.Visible = false;
            // 
            // lblIndicator3
            // 
            this.lblIndicator3.AutoSize = true;
            this.lblIndicator3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator3.ForeColor = System.Drawing.Color.Green;
            this.lblIndicator3.Location = new System.Drawing.Point(99, 89);
            this.lblIndicator3.Name = "lblIndicator3";
            this.lblIndicator3.Size = new System.Drawing.Size(25, 29);
            this.lblIndicator3.TabIndex = 15;
            this.lblIndicator3.Text = "-";
            this.lblIndicator3.Visible = false;
            // 
            // bt1Sec
            // 
            this.bt1Sec.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bt1Sec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1Sec.Location = new System.Drawing.Point(10, 168);
            this.bt1Sec.Name = "bt1Sec";
            this.bt1Sec.Size = new System.Drawing.Size(60, 23);
            this.bt1Sec.TabIndex = 16;
            this.bt1Sec.Text = "1 Sec";
            this.bt1Sec.UseVisualStyleBackColor = false;
            this.bt1Sec.Click += new System.EventHandler(this.bt1Sec_Click);
            // 
            // lblIndicator4
            // 
            this.lblIndicator4.AutoSize = true;
            this.lblIndicator4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator4.ForeColor = System.Drawing.Color.Red;
            this.lblIndicator4.Location = new System.Drawing.Point(130, 89);
            this.lblIndicator4.Name = "lblIndicator4";
            this.lblIndicator4.Size = new System.Drawing.Size(25, 29);
            this.lblIndicator4.TabIndex = 17;
            this.lblIndicator4.Text = "-";
            this.lblIndicator4.Visible = false;
            // 
            // lblIndicator1
            // 
            this.lblIndicator1.AutoSize = true;
            this.lblIndicator1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator1.ForeColor = System.Drawing.Color.Green;
            this.lblIndicator1.Location = new System.Drawing.Point(41, 89);
            this.lblIndicator1.Name = "lblIndicator1";
            this.lblIndicator1.Size = new System.Drawing.Size(25, 29);
            this.lblIndicator1.TabIndex = 18;
            this.lblIndicator1.Text = "-";
            this.lblIndicator1.Visible = false;
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modesToolStripMenuItem.Text = "Mode";
            // 
            // countDownToolStripMenuItem
            // 
            this.countDownToolStripMenuItem.Name = "countDownToolStripMenuItem";
            this.countDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countDownToolStripMenuItem.Text = "Count Down";

            // 
            // stopWatchToolStripMenuItem
            // 
            this.stopWatchToolStripMenuItem.Name = "stopWatchToolStripMenuItem";
            this.stopWatchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopWatchToolStripMenuItem.Text = "Stop Watch";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btStopReset;
            this.ClientSize = new System.Drawing.Size(203, 262);
            this.Controls.Add(this.lblIndicator1);
            this.Controls.Add(this.lblIndicator4);
            this.Controls.Add(this.bt1Sec);
            this.Controls.Add(this.lblIndicator3);
            this.Controls.Add(this.lblIndicator2);
            this.Controls.Add(this.tb60Min);
            this.Controls.Add(this.tb30Sec);
            this.Controls.Add(this.tb45Min);
            this.Controls.Add(this.tb30Min);
            this.Controls.Add(this.tb15Min);
            this.Controls.Add(this.tb10Min);
            this.Controls.Add(this.tb5Min);
            this.Controls.Add(this.tb1Min);
            this.Controls.Add(this.lblMinsSec);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btStopReset);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::CountDownClock.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::CountDownClock.Properties.Settings.Default.Location;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(209, 290);
            this.MinimumSize = new System.Drawing.Size(209, 290);
            this.Name = "FormMain";
            this.Text = "Countdown Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStopReset;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lblMinsSec;
        private System.Windows.Forms.Button tb1Min;
        private System.Windows.Forms.Button tb5Min;
        private System.Windows.Forms.Button tb10Min;
        private System.Windows.Forms.Button tb45Min;
        private System.Windows.Forms.Button tb30Min;
        private System.Windows.Forms.Button tb15Min;
        private System.Windows.Forms.Button tb30Sec;
        private System.Windows.Forms.Button tb60Min;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label lblIndicator2;
        private System.Windows.Forms.Label lblIndicator3;
        private System.Windows.Forms.Button bt1Sec;
        private System.Windows.Forms.Label lblIndicator4;
        private System.Windows.Forms.Label lblIndicator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem perfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arborWingcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arborWingcomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

