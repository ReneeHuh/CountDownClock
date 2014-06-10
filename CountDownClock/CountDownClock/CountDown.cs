using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CountDownClock
{
    public static class DelegateExpansion
    {
        // Prevent CrossThreadException by invoking delegate through target control's thread.
        public static object CrossInvoke(this Delegate delgt, object sender, EventArgs e)
        {
            if (delgt.Target is Control && ((Control)delgt.Target).InvokeRequired)
            {
                return ((Control)delgt.Target).Invoke(delgt, new object[] { sender, e });
            }
            return delgt.Method.Invoke(delgt.Target, new object[] { sender, e });
        }
    }

    class MinSec
    {

        private int sec;

        public int Minites
        {
            get
            {
                return (sec / 60);
            }

        }
        public int Seconds
        {
            get
            {
                return sec % 60;
            }
        }
        public void AddMinites(int j)
        {
            sec += j * 60;
        }
        public void AddSeconds(int j)
        {
            sec += j;
        }
        public void SubtractSeconds(int j)
        {
            sec--;
        }
        public void Clear()
        {
            sec = 0;
        }
        public override string ToString()
        {
            return string.Format("{0:000}:{1:00}", Minites, Seconds);
        }
        public bool HasTimeLeft
        {
            get
            {
                if (sec > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public class TimeChangedEventArgs : EventArgs
    {
        private string myTime;
        public TimeChangedEventArgs(string iTime)
        {
            myTime = iTime;
        }
        public string Time
        {
            get { return myTime; }
        }
    
    }

    public class CountDown
    {
        public enum CDState { NotStarted, Started };
        public CDState State { get; set; }

        public enum CDModes { CountDown, StopWatch };
        public CDModes Mode { get; set; }

        public event EventHandler<TimeChangedEventArgs> CountDownChanged;
        public event EventHandler<EventArgs> TimeTick;
        
        private System.Timers.Timer Timer = new System.Timers.Timer();

        private CountDownClock.MinSec Time = new CountDownClock.MinSec();

        public CountDown()
        {
            Mode = CDModes.CountDown;
            State = CDState.NotStarted;
            Timer.Enabled = false;
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerTick);
        
        }

        public void TimerTick(object sender, EventArgs e)
        {
            //MODE CountDown
            if (Mode == CDModes.CountDown)
            {

                if (Enabled == true)
                {
                    SubtractSeconds(1);

                    if (Time.HasTimeLeft == false)
                    {
                        Fisished();
                    }
                }
            }
            //MODE Stop Watch
            else
            {
                if (Enabled == true)
                {
                    AddSeconds(1);

                }
            
            }

           TimeTick(this, e);
        }

        public bool HasTimeLeft { get { return Time.HasTimeLeft; } }
        public bool Enabled { get { return Timer.Enabled; } set { Timer.Enabled = value; } }

        public void AddSeconds(int i)
        {
            Time.AddSeconds(i);

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }

        public void AddMinites(int i)
        {
            Time.AddMinites(i);

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }
        public void SubtractSeconds(int i)
        {
            Time.SubtractSeconds(i);
            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }

        public void Start()
        {
            State = CDState.Started;
            Timer.AutoReset = true;
            Timer.Enabled = true;

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }

        public void Stopped()
        {
            State = CDState.Started;
            Timer.Enabled = false;

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }

        public void Pause()
        {
            State = CDState.Started;
            Timer.Enabled = false;
            
            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }
        public void Reset()
        {
            State = CDState.NotStarted;
            Enabled = false;
            Time.Clear();

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;
        }

        public void Fisished()
        {

            Timer.Enabled = false;
            Time.Clear();

            TimeChangedEventArgs e = new TimeChangedEventArgs(Time.ToString());
            DelegateExpansion.CrossInvoke(CountDownChanged, this, e);
            //CountDownChanged(this,e) ;

            int sel = Properties.Settings.Default.WavFileSelected;
            string location = CDCControls.WavLocation[sel];
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(location);

            for (int i = 0; i < Properties.Settings.Default.WavPlayTimes; i++)
            {
                player.PlaySync();
            }
        }
    }
}
