using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountdownClock
{

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
                    if (sec > 0 )
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


}
