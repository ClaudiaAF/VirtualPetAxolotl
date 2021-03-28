using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace VirtualPetAxolotl.AxolotlSpace
{
    public class TimeKeeper
    {
        private Timer Timer { get; set; }
        public TimeKeeper()
        {
            StartTimer();
        }

        private void StartTimer()
        {
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Enabled = true;
            Timer.Elapsed += DoomsDayTimer;
            Timer.Start();
        }

        private void DoomsDayTimer(object sender, ElapsedEventArgs e)
        {
            Axolotl.AxolotlState.Destroy();
            Axolotl.TankState.Destroy();
            Axolotl.FilterState.Destroy();
            Axolotl.HungerState.Destroy();
            
        }

        public void destroyTimer() {
            if (Timer != null)
            {
                Timer.Stop();
            }
        }
    }

}
