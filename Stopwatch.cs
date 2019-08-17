using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        //Make the fields private so that they cannot be set from outside
        private DateTime startTime;
        private DateTime endTime;
        private bool isStarted;

        public void Start()
        {
            if (isStarted)           
                throw new InvalidOperationException("The stopwatch is already started, you need to to stop it first and then start it again!");
          
            startTime = DateTime.Now;
            isStarted = true;           
        }

        public void Stop()
        {
            if(!isStarted)            
                throw new InvalidOperationException("The stopwatch has not yet started!");
             
            endTime = DateTime.Now;
            isStarted = false;          
        }

        public TimeSpan GetDuration()
        {
            return endTime - startTime;            
        }
    }
}
