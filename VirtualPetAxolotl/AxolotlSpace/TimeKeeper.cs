using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace VirtualPetAxolotl.AxolotlSpace
{
    public class TimeKeeper
    {
        private static Timer timer;

        public TimeKeeper()
        {
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += DoomsDayTimer;
            timer.Start();
        }

        private void DoomsDayTimer(object sender, ElapsedEventArgs e)
        {
            Axolotl.AxolotlState.Destroy();
            Axolotl.FilterState.Destroy();
            Axolotl.HungerState.Destroy();
            Axolotl.TankState.Destroy();
        }
    }

}
