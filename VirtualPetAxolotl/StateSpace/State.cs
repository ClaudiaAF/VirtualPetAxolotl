using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.StateSpace
{
    abstract class State
    {
        public int HP { get; set; } = 100;

        public int DestroyRate { get; set; } = 1;

        public void Restore()
        {
            HP = 100;
            UpdateState();
        }

        public void RestoreDependents(params State[] states)
        {
            Restore();

            foreach (var dependent in states)
            {
                dependent.Restore();
            }
        }

        public void Destroy()
        {
            if (HP > 0)
            {
                HP -= DestroyRate;
                UpdateState();
                /*Console.WriteLine("DR - " + DestroyRate + " | HP - " + HP);*/
            }
        }

        public abstract void UpdateState();

    }
}
