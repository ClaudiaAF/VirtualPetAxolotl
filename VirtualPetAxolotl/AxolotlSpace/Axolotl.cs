using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetAxolotl.StateSpace;

namespace VirtualPetAxolotl.AxolotlSpace { 
    class Axolotl
    { 
        public static AxolotlState AxolotlState { get; set; }
        public static HungerState HungerState { get; set; }
        public static TankState TankState { get; set; }
        public static FilterState FilterState { get; set; }
        public static TimeKeeper TimeKeeper { get; set; }

        public static void Init()
        {
            AxolotlState = new AxolotlState();
            HungerState = new HungerState();
            TankState = new TankState();
            FilterState = new FilterState();
            TimeKeeper = new TimeKeeper();
        }

        const string axolotlXpKey = "axolotlXp";
        const string axoltolNameKey = "axolotlName";
       
        public static int Xp 
        {
            get
            {
                if (App.Current.Properties.ContainsKey(axolotlXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[axolotlXpKey]);
                    Xp = (int)App.Current.Properties[axolotlXpKey];
                }

                return Xp;
            }

            set
            {
                Xp = value;
                App.Current.Properties[axolotlXpKey] = value;
            }
        }
       
        public string AxoltolName
        {
            get
            {
                if (App.Current.Properties.ContainsKey(axoltolNameKey))
                {
                    return (string)App.Current.Properties[axoltolNameKey];
                }
                else
                {
                    return "No Name";
                }

            }
            set
            {
                App.Current.Properties[axoltolNameKey] = value;
            }
        }

        public void Feed()
        {
            /*Xp += 200;*/
            HungerState.RestoreDependents(AxolotlState);
        }

        public void GiveAttention()
        {
            /*Xp += 500;*/
            AxolotlState.Restore();
        }

        public void ReplaceFitler()
        {
            /*Xp += 400;*/
            FilterState.RestoreDependents(TankState, AxolotlState);
        }

        public void CleanTank()
        {
            /*Xp += 300;*/
            TankState.RestoreDependents(AxolotlState);
        }
    }
}
