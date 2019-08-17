using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }

        public TimeSpan Duration { get; set; }
        public bool IsStarted { get; set; }

        public void Start()
        {
            if (!IsStarted)
            {
                Starting = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("The stopwatch is already started, you need to to stop it first to start it again!");
            }
            IsStarted = true;
        }

        public TimeSpan Stop()
        {
            if(IsStarted)
            {
                Ending = DateTime.Now;
            }
            IsStarted = false;
            return CalculateDuration();
        }

        public TimeSpan CalculateDuration()
        {
            Duration = Ending - Starting;

            //Reset starting and ending time
            Starting = default(DateTime);
            Ending = default(DateTime);

            return Duration;
        }
    }
}
