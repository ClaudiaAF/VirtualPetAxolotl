using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.NewFolder1
{
    public class Axolotl
    {
        const string axolotlStateKey = "axolotlState";
        const string axolotlXpKey = "axolotlXp";
        const string axoltolNameKey = "axolotlName";

        public AxolotlState CurrentAxolotlState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(axolotlStateKey))
                {
                    return AxolotlStates.GetAxolotlState((string)App.Current.Properties[axolotlStateKey]);
                }
                else
                {
                    return AxolotlState.healthy;
                }
            }
            set
            {
                App.Current.Properties[axolotlStateKey] = AxolotlStates.GetAxolotlString(value);
            }

           
        }

        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(axolotlXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[axolotlXpKey]);
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

        public Axolotl()
        {
           

        }

        public void giveFood()
        {
            Xp = Xp + 500;
        }
    }
}
