using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CountDownClock
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblAppName.Text = Properties.Settings.Default.AppName;
            lblVerison.Text = "Verison " + Properties.Settings.Default.AppVersion;
            this.Text = "About " + Properties.Settings.Default.AppName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.arborwing.com/");
        }


    }
}
