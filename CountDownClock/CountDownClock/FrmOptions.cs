using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountDownClock
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }
        int firstload = 0;
        private void FrmOptions_Load(object sender, EventArgs e)
        {
            foreach (string name in CDCControls.WavNames)
            {
                listboxWavSlection.Items.Add(name);
            }
            tbDefaultMins.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds / 60);
            tbDefaultSec.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds % 60);

            cbSecondsChime.Checked = Properties.Settings.Default.SecondChime;

            listboxWavSlection.SelectedIndex = Properties.Settings.Default.WavFileSelected;
            udWavPlayTimes.Value = Properties.Settings.Default.WavPlayTimes;
            firstload = 1;
        }

        private void listboxWavSlection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wont play when form loads
            if (firstload != 0)
            {
                int sel = Convert.ToInt32(listboxWavSlection.SelectedIndex);
                string location = CDCControls.WavLocation[sel];
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(location);
                player.Play();
            }
        }

        private void udWavPlayTimes_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WavPlayTimes = Convert.ToInt32(udWavPlayTimes.Value);
            Properties.Settings.Default.WavFileSelected = listboxWavSlection.SelectedIndex;
            Properties.Settings.Default.DefaultSeconds = (Convert.ToInt32(tbDefaultMins.Text) * 60) + Convert.ToInt32(tbDefaultSec.Text);
            Properties.Settings.Default.SecondChime = cbSecondsChime.Checked;

            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(listboxWavSlection.SelectedIndex);
            string location = CDCControls.WavLocation[sel];
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(location);
            player.Play();
        }

        private void tbDefaultMins_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int validInt = Convert.ToInt32(tbDefaultMins.Text);
            }
            catch
            {
                // invalid entry
                tbDefaultMins.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds / 60);
                tbDefaultSec.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds % 60);

            }
        }

        private void tbDefaultSec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int validInt = Convert.ToInt32(tbDefaultSec.Text);
            }
            catch
            { 
                // invalid entry
                tbDefaultMins.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds / 60);
                tbDefaultSec.Text = Convert.ToString(Properties.Settings.Default.DefaultSeconds % 60);

            }
        }


    }
}
