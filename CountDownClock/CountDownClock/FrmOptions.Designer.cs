namespace CountDownClock
{
    partial class FrmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSecondsChime = new System.Windows.Forms.CheckBox();
            this.lblDefaultseclbl1 = new System.Windows.Forms.Label();
            this.tbDefaultSec = new System.Windows.Forms.TextBox();
            this.lblDefaultsecSec = new System.Windows.Forms.Label();
            this.tbDefaultMins = new System.Windows.Forms.TextBox();
            this.lblDefaultsecMins = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.udWavPlayTimes = new System.Windows.Forms.NumericUpDown();
            this.btPlay = new System.Windows.Forms.Button();
            this.listboxWavSlection = new System.Windows.Forms.ListBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWavPlayTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbSecondsChime);
            this.tabPage1.Controls.Add(this.lblDefaultseclbl1);
            this.tabPage1.Controls.Add(this.tbDefaultSec);
            this.tabPage1.Controls.Add(this.lblDefaultsecSec);
            this.tabPage1.Controls.Add(this.tbDefaultMins);
            this.tabPage1.Controls.Add(this.lblDefaultsecMins);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Background Color ";
            this.label2.Visible = false;
            // 
            // cbSecondsChime
            // 
            this.cbSecondsChime.AutoSize = true;
            this.cbSecondsChime.Location = new System.Drawing.Point(17, 81);
            this.cbSecondsChime.Name = "cbSecondsChime";
            this.cbSecondsChime.Size = new System.Drawing.Size(123, 17);
            this.cbSecondsChime.TabIndex = 6;
            this.cbSecondsChime.Text = "Play Seconds Chime";
            this.cbSecondsChime.UseVisualStyleBackColor = true;
            this.cbSecondsChime.Visible = false;
            // 
            // lblDefaultseclbl1
            // 
            this.lblDefaultseclbl1.AutoSize = true;
            this.lblDefaultseclbl1.Location = new System.Drawing.Point(14, 49);
            this.lblDefaultseclbl1.Name = "lblDefaultseclbl1";
            this.lblDefaultseclbl1.Size = new System.Drawing.Size(92, 13);
            this.lblDefaultseclbl1.TabIndex = 5;
            this.lblDefaultseclbl1.Text = "Default Start Time";
            // 
            // tbDefaultSec
            // 
            this.tbDefaultSec.Location = new System.Drawing.Point(181, 44);
            this.tbDefaultSec.Name = "tbDefaultSec";
            this.tbDefaultSec.Size = new System.Drawing.Size(41, 20);
            this.tbDefaultSec.TabIndex = 4;
            this.tbDefaultSec.TextChanged += new System.EventHandler(this.tbDefaultSec_TextChanged);
            // 
            // lblDefaultsecSec
            // 
            this.lblDefaultsecSec.AutoSize = true;
            this.lblDefaultsecSec.Location = new System.Drawing.Point(224, 48);
            this.lblDefaultsecSec.Name = "lblDefaultsecSec";
            this.lblDefaultsecSec.Size = new System.Drawing.Size(26, 13);
            this.lblDefaultsecSec.TabIndex = 3;
            this.lblDefaultsecSec.Text = "Sec";
            // 
            // tbDefaultMins
            // 
            this.tbDefaultMins.Location = new System.Drawing.Point(109, 44);
            this.tbDefaultMins.Name = "tbDefaultMins";
            this.tbDefaultMins.Size = new System.Drawing.Size(41, 20);
            this.tbDefaultMins.TabIndex = 2;
            this.tbDefaultMins.TextChanged += new System.EventHandler(this.tbDefaultMins_TextChanged);
            // 
            // lblDefaultsecMins
            // 
            this.lblDefaultsecMins.AutoSize = true;
            this.lblDefaultsecMins.Location = new System.Drawing.Point(152, 48);
            this.lblDefaultsecMins.Name = "lblDefaultsecMins";
            this.lblDefaultsecMins.Size = new System.Drawing.Size(29, 13);
            this.lblDefaultsecMins.TabIndex = 1;
            this.lblDefaultsecMins.Text = "Mins";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto Start On Windows Logon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.udWavPlayTimes);
            this.tabPage2.Controls.Add(this.btPlay);
            this.tabPage2.Controls.Add(this.listboxWavSlection);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sounds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "How Many Times Shoud Chime Play";
            // 
            // udWavPlayTimes
            // 
            this.udWavPlayTimes.Location = new System.Drawing.Point(14, 127);
            this.udWavPlayTimes.Name = "udWavPlayTimes";
            this.udWavPlayTimes.Size = new System.Drawing.Size(120, 20);
            this.udWavPlayTimes.TabIndex = 2;
            this.udWavPlayTimes.ValueChanged += new System.EventHandler(this.udWavPlayTimes_ValueChanged);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(195, 15);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // listboxWavSlection
            // 
            this.listboxWavSlection.FormattingEnabled = true;
            this.listboxWavSlection.Location = new System.Drawing.Point(14, 15);
            this.listboxWavSlection.Name = "listboxWavSlection";
            this.listboxWavSlection.Size = new System.Drawing.Size(175, 95);
            this.listboxWavSlection.TabIndex = 0;
            this.listboxWavSlection.SelectedIndexChanged += new System.EventHandler(this.listboxWavSlection_SelectedIndexChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(209, 221);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(290, 221);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 253);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 291);
            this.Name = "FrmOptions";
            this.Text = "Options For Count Down Clock";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWavPlayTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listboxWavSlection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udWavPlayTimes;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbDefaultSec;
        private System.Windows.Forms.Label lblDefaultsecSec;
        private System.Windows.Forms.TextBox tbDefaultMins;
        private System.Windows.Forms.Label lblDefaultsecMins;
        private System.Windows.Forms.Label lblDefaultseclbl1;
        private System.Windows.Forms.CheckBox cbSecondsChime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}