using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Utility
{
    public class TickProfiler
    {
        private long _startTicks = -1;

        public TickProfiler()
        {
        }

        public void Start()
        {
            _startTicks = DateTime.Now.Ticks;
        }

        public long TicksElapsed
        {
            get
            {
                if (_startTicks > 0)
                {
                    return (DateTime.Now.Ticks - _startTicks);
                }
                else
                {
                    return -1;
                }
            }
        }

        public int Elapsed
        {
            get
            {
                if (_startTicks > 0)
                {
                    return (int)(TicksElapsed / TimeSpan.TicksPerMillisecond);
                }
                else
                {
                    return -1;
                }
            }
        }

        public void LogElapsed(string message)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("#-- {0}: [{1}ms] --#", message, Elapsed));
        }
    }
}
