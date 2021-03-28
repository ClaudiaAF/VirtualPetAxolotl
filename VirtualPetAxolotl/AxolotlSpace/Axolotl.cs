using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetAxolotl.StateSpace;

namespace VirtualPetAxolotl.AxolotlSpace { 
    class Axolotl
    {

        private const string AxolotlStateKey = "AxolotlStateKey";

        public static AxolotlState AxolotlState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(AxolotlStateKey))
                {
                    return (AxolotlState)App.Current.Properties[AxolotlStateKey];
                }
                else
                {
                    return new AxolotlState();
                }
            }

            set
            {
                App.Current.Properties[AxolotlStateKey] = value;
            }
        }
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
            Xp = 0;
        }

        const string axolotlXpKey = "axolotlXp";
        const string axoltolNameKey = "axolotlName";
       
        public static int Xp 
        {
            get
            {
                if (App.Current.Properties.ContainsKey(axolotlXpKey))
                {
                    return (int)App.Current.Properties[axolotlXpKey];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
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

        public static void Feed()
        {
            Xp += 200;            
            HungerState.RestoreDependents(AxolotlState);
            Dashboard.UpdateXpLevel();
        }

        public static void GiveAttention()
        {
            Xp += 500;
            AxolotlState.Restore();
            Dashboard.UpdateXpLevel();
        }

        public static void ReplaceFitler()
        {
            Xp += 400;
            FilterState.RestoreDependents(TankState, AxolotlState);
            Dashboard.UpdateXpLevel();
        }

        public static void CleanTank()
        {
            Xp += 300;
            TankState.RestoreDependents(AxolotlState);
            Dashboard.UpdateXpLevel();
        }
    }
}
