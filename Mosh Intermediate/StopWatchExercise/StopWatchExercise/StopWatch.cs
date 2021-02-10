using System;

namespace StopWatchExercise
{
  
        public class StopWatch
        {
            private DateTime _start;
            private DateTime _stop;
            private bool _running;
            private TimeSpan _finalTime;
            public void Start()
            {
                if (!_running)
                {
                    _running = true;
                    _start = DateTime.Now;
                }
            }

            public TimeSpan Stop()
            {
                if (_running)
                {
                    _stop = DateTime.Now;
                    _running = false;
                    _finalTime = _stop - _start;
                }
                return (_finalTime);

            }

        }
    }
