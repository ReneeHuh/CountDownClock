using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CountDownClock
{
    class CDCControls
    {

        public static string[] WavLocation;
        public static string[] WavNames;
        public static int WavSelection;
        public static int WavPlayTimes;

        public static void LoadWaves()
        {
            WavLocation = Directory.GetFiles("wavs/", "*.wav");
            WavNames = Directory.GetFiles("wavs/", "*.wav");

            for (int i = 0; i < WavNames.Length; i++)
            {
                int slashlocation = WavNames[i].IndexOf('/') + 1;
                int extlocation = WavNames[i].IndexOf('.');
                WavNames[i] = WavNames[i].Substring(slashlocation, (extlocation - slashlocation));
            }
        
        }
    }

}
