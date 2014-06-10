using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace CountDownClock
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private System.Timers.Timer CDTimer;
        private CountdownClock.MinSec TimeToCountDown = new CountdownClock.MinSec();
        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        private void Form1_Load(object sender, EventArgs e)
        {
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

            
            TimeToCountDown.AddSeconds(Properties.Settings.Default.DefaultSeconds);

            CDCControls.LoadWaves();
            CDCControls.WavSelection = Properties.Settings.Default.WavFileSelected;
            CDCControls.WavPlayTimes = Properties.Settings.Default.WavPlayTimes;

            //string[] array2 = Directory.GetFiles("wavs/", "*.wav");
            //try
            //{
            //    string location = array2[0];
            //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(location);
            //    player.PlaySync();
            //}
            //catch 
            //{
            //    MessageBox.Show("cant play wave");
            //}

            DisplayRefesh();
            CDTimer = new System.Timers.Timer(1000);
            CDTimer.Elapsed += new System.Timers.ElapsedEventHandler(TimerTick);

            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save(); 
        }

        public void DisplayRefesh()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string displaytime = TimeToCountDown.ToString();
            lblMinsSec.Text = displaytime;

            IndicatorChange();
        
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
            if (CDTimer.Enabled == true)
            {
                Pause();
                DisplayRefesh();
            }
            else
            {
                if (TimeToCountDown.HasTimeLeft == true)
                {
                    Start(); 
                    DisplayRefesh();
                }
                else 
                {
                    DisplayRefesh();
                }
                    
            }
        }

        private void btStopReset_Click(object sender, EventArgs e)
        {
            if (CDTimer.Enabled == true)
            {
                Stopped();
                DisplayRefesh();
            }
            else
            {
                Reset();
                DisplayRefesh();
            }
        }

        public void TimerTick(object sender, EventArgs e)
        {
            if (CDTimer.Enabled == true)
            {
                TimeToCountDown.SubtractSeconds(1);
                DisplayRefesh();

                if (TimeToCountDown.HasTimeLeft == false)
                {
                    Fisished();
                    DisplayRefesh();
                }

            }
            DisplayRefesh();
        }

        public void Start()
        {
            IndicatorOn(true);
            CDTimer.AutoReset = true;
            CDTimer.Enabled = true;

            //Active = true;

            btStart.Text = "Pause";
            btStopReset.Text = "Stop";

        }

        public void Stopped()
        {
            IndicatorOn(false);
            CDTimer.Enabled = false;

            btStart.Text = "Start";
            btStopReset.Text = "Reset";


        }
        public void Pause()
        {
            IndicatorOn(true);
            CDTimer.Enabled = false;
            btStart.Text = "Resume";
            btStopReset.Text = "Stop";

        }
        public void Reset()
        {
            IndicatorOn(false);
            CDTimer.Enabled = false;

            TimeToCountDown.Clear();
            DisplayRefesh();

            btStart.Text = "Start";
            btStopReset.Text = "Reset";
        }

        public void Fisished()
        {
            btStart.Text = "Start";
            btStopReset.Text = "Reset";

            IndicatorOn(false);
            CDTimer.Enabled = false;
            TimeToCountDown.Clear();
            DisplayRefesh();

            int sel = Properties.Settings.Default.WavFileSelected;
            string location = CDCControls.WavLocation[sel];
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(location);

            for (int i = 0; i < Properties.Settings.Default.WavPlayTimes; i++)
            {
                player.PlaySync();
            }

            

        }

        private void bt1Sec_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddSeconds(1);
            DisplayRefesh();
        }
        private void tb30Sec_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddSeconds(15);
            DisplayRefesh();
        }

        private void tb1Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(1);
            DisplayRefesh();
        }

        private void tb5Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(5);
            DisplayRefesh();
        }

        private void tb10Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(10);
            DisplayRefesh();
        }

        private void tb15Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(15);
            DisplayRefesh();
        }

        private void tb30Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(30);
            DisplayRefesh();
        }

        private void tb45Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(45);
            DisplayRefesh();
        }

        private void tb60Min_Click(object sender, EventArgs e)
        {
            TimeToCountDown.AddMinites(60);
            DisplayRefesh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOptions myOptions = new FrmOptions();
            myOptions.ShowDialog();
        }





    }





}
