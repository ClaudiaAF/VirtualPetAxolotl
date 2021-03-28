using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetAxolotl.AxolotlSpace;

namespace VirtualPetAxolotl.StateSpace
{
    public enum HungerStateType
    {
        Full = 0,
        Content = 1,
        Hungry = 2
    }
    class HungerState : State
    {
        public HungerStateType CurrentStateType { get; set; } = HungerStateType.Full;

        public override void UpdateState()
        {
            HungerStateType NewStateType;
            int currentTypeDestroyRate = 0;

            if (HP >= 50)
            {
                NewStateType = HungerStateType.Full;
                int currentVal = (int)CurrentStateType;

                foreach (HungerStateType type in Enum.GetValues(typeof(HungerStateType)))
                {
                    int val = (int)type;

                    if (val <= currentVal)
                    {
                        currentTypeDestroyRate += val;
                    }
                }

                currentTypeDestroyRate *= -1;
            }
            else if (HP < 50 && HP >= 25)
            {
                NewStateType = HungerStateType.Content;
            }
            else if (HP < 25)
            {
                NewStateType = HungerStateType.Hungry;
            } else
            {
                NewStateType = HungerStateType.Hungry;
            }

            if (NewStateType != CurrentStateType)
            {
                CurrentStateType = NewStateType;
                Axolotl.AxolotlState.DestroyRate 
                    += currentTypeDestroyRate 
                    += (int)CurrentStateType;
            }

            Dashboard.UpdateHungerHpBar();
        }
    }
}
