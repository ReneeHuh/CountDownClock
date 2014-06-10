using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace CountDownClock
{
   
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public CountDown myCountDown = new CountDown();

        private void isVisable()
        {
            //check to see if the window on the screen
            bool visible = false;
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Contains(this.DesktopLocation))
                {
                    visible = true;
                    break;
                }
            }
            if (!visible)
                this.Location = new Point(100, 100);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            isVisable();

            myCountDown.CountDownChanged += new EventHandler<TimeChangedEventArgs>(myCountDown_CountDownChanged);
            myCountDown.TimeTick +=new EventHandler<EventArgs>(myCountDown_TimeTick);

            myCountDown.AddSeconds(Properties.Settings.Default.DefaultSeconds);

            CDCControls.LoadWaves();
            CDCControls.WavSelection = Properties.Settings.Default.WavFileSelected;
            CDCControls.WavPlayTimes = Properties.Settings.Default.WavPlayTimes;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save(); 
        }


        private void myCountDown_CountDownChanged(object sender, TimeChangedEventArgs e)
        {
            lblMinsSec.Text = e.Time;
            UpDateDisplay();

        }
        private void myCountDown_TimeTick(object sender, EventArgs e)
        {
            IndicatorChange();
        }

        private void UpDateDisplay()
        {
            
            //if CountDown timer is On/Enabled == true   
            if (myCountDown.Enabled == true && myCountDown.State == CountDown.CDState.Started)
            {
                IndicatorOn(true);

                //btStart.Text = "Start";
                //btStopReset.Text = "Reset";
                btStart.Text = "Pause";
                btStopReset.Text = "Stop";
            }
            //else Countdown Timer is Off/Enabled == false
            else
            {
                if (myCountDown.HasTimeLeft == true && myCountDown.State == CountDown.CDState.Started)
                {
                    btStart.Text = "Start";
                    btStopReset.Text = "Stop";
                    IndicatorOn(true);
                }
                else 
                {
                    btStart.Text = "Start";
                    btStopReset.Text = "Reset";
                    IndicatorOn(false);
                }
                
            }

        }
        private void IndicatorOn(bool i)
        { 
            //true = on
            //false = off

            if (i == true)
            {
                lblIndicator1.Visible = true;
                lblIndicator2.Visible = true;
                lblIndicator3.Visible = true;
                lblIndicator4.Visible = true;
            }
            else
            {
                lblIndicator1.Visible = false;
                lblIndicator2.Visible = false;
                lblIndicator3.Visible = false;
                lblIndicator4.Visible = false;
            }
        }

        private void IndicatorChange()
        {
            if (lblIndicator1.ForeColor == Color.Red)
            {
                lblIndicator1.ForeColor = Color.Green;
                lblIndicator2.ForeColor = Color.Red;
                lblIndicator3.ForeColor = Color.Green;
                lblIndicator4.ForeColor = Color.Green;
            }
            else if (lblIndicator2.ForeColor == Color.Red)
            {
                lblIndicator1.ForeColor = Color.Green;
                lblIndicator2.ForeColor = Color.Green;
                lblIndicator3.ForeColor = Color.Red;
                lblIndicator4.ForeColor = Color.Green;
            }
            else if (lblIndicator3.ForeColor == Color.Red)
            {
                lblIndicator1.ForeColor = Color.Green;
                lblIndicator2.ForeColor = Color.Green;
                lblIndicator3.ForeColor = Color.Green;
                lblIndicator4.ForeColor = Color.Red;
            }
            else 
            {
                lblIndicator1.ForeColor = Color.Red;
                lblIndicator2.ForeColor = Color.Green;
                lblIndicator3.ForeColor = Color.Green;
                lblIndicator4.ForeColor = Color.Green;
            }
            
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //if CountDown timer is On/Enabled == true   
            if (myCountDown.Enabled == true)
            {
                myCountDown.Pause();
            }
            //else Countdown Timer is Off/Enabled == false
            else
            {
                if (myCountDown.HasTimeLeft == true)
                {
                    myCountDown.Start();
                }
                else 
                {
                    myCountDown.Pause();
                }
            }
        }

        private void btStopReset_Click(object sender, EventArgs e)
        {
            //if CountDown timer is On/Enabled == true   
            if (myCountDown.Enabled == true)
            {
                myCountDown.Stopped();
            }
            //else Countdown Timer is Off/Enabled == false
            else
            {
                myCountDown.Reset();
            }
        }


        private void bt1Sec_Click(object sender, EventArgs e)
        {
            myCountDown.AddSeconds(1);
        }
        private void tb30Sec_Click(object sender, EventArgs e)
        {
            myCountDown.AddSeconds(15);
        }

        private void tb1Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(1);
        }

        private void tb5Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(5);
        }

        private void tb10Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(10);
        }

        private void tb15Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(15);
        }

        private void tb30Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(30);
        }

        private void tb45Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(45);

        }

        private void tb60Min_Click(object sender, EventArgs e)
        {
            myCountDown.AddMinites(60);
        }

        // used for mode count up/ count down

        //private void countDownToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    stopWatchToolStripMenuItem.Checked = false;
        //    countDownToolStripMenuItem.Checked = true;

        //    myCountDown.Mode = CountDown.CDModes.CountDown;

        //    TimeButtonsOnOff(true);
        //}

        //private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    stopWatchToolStripMenuItem.Checked = true;
        //    countDownToolStripMenuItem.Checked = false;

        //    myCountDown.Mode = CountDown.CDModes.StopWatch;

        //    TimeButtonsOnOff(false);
        //}
        //private void TimeButtonsOnOff(bool e)
        //{
        //    if (e == true)
        //    {
        //        bt1Sec.Enabled = true;
        //        tb30Sec.Enabled = true;
        //        tb1Min.Enabled = true;
        //        tb5Min.Enabled = true;
        //        tb10Min.Enabled = true;
        //        tb15Min.Enabled = true;
        //        tb45Min.Enabled = true;
        //        tb60Min.Enabled = true;
        //    }
        //    else
        //    {
        //        bt1Sec.Enabled = false;
        //        tb30Sec.Enabled = false;
        //        tb1Min.Enabled = false;
        //        tb5Min.Enabled = false;
        //        tb10Min.Enabled = false;
        //        tb15Min.Enabled = false;
        //        tb45Min.Enabled = false;
        //        tb60Min.Enabled = false;
            
        //    }
        
        //}


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOptions myOptions = new FrmOptions();
            myOptions.StartPosition = FormStartPosition.CenterParent;
            myOptions.ShowDialog();
        }

        private void arborWingcomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.arborwing.com/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout myAbout = new FormAbout();
            myAbout.StartPosition = FormStartPosition.CenterParent;
            myAbout.ShowDialog();
        }







    }





}
