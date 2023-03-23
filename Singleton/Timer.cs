using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8DesignPatterns.Singleton
{
    internal class Timer
    {
        private static Timer? instance;

        public static Timer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Timer();
                }

                return instance;
            }
        }

        public delegate void TimeRemainingDelegate();
        public event TimeRemainingDelegate TimeExpired;

        private Stopwatch Stopwatch;

        public Timer()
        {
            Stopwatch = new Stopwatch();
            Stopwatch.Start();
        }

        private int TimeAllotment = 5;

        public int GetRemainingTime()
        {
            if (Stopwatch.Elapsed.Minutes >= TimeAllotment)
            {
                TimeExpired?.Invoke();
            }

            return TimeAllotment - Stopwatch.Elapsed.Minutes;
        }

        public void IncrementTimeRemaining(int amount)
        {
            TimeAllotment += amount;
        }

    }





}
