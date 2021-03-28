using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetAxolotl.AxolotlSpace;

namespace VirtualPetAxolotl.StateSpace
{
    public enum TankStateType
    {
        Sparkling = 0,
        Clean = 1,
        Unclean = 2,
        Disgusting = 4
    }
    class TankState : State
    {
        public TankStateType CurrentStateType { get; set; } = TankStateType.Sparkling;

        public override void UpdateState()
        {
            TankStateType NewStateType;
            int currentTypeDestroyRate = 0;

            if (HP >= 50)
            {
                NewStateType = TankStateType.Sparkling;
                int currentVal = (int)CurrentStateType;

                foreach (TankStateType type in Enum.GetValues(typeof(TankStateType)))
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
                NewStateType = TankStateType.Clean;
            }
            else if (HP < 25 && HP > 0)
            {
                NewStateType = TankStateType.Unclean;
            }
            else
            {
                NewStateType = TankStateType.Disgusting;
            }


            if (NewStateType != CurrentStateType)
            {
                CurrentStateType = NewStateType;
                Axolotl.AxolotlState.DestroyRate
                    += currentTypeDestroyRate
                    += (int)CurrentStateType;
            }

            Dashboard.UpdateTankHpBar();
        }
    }
}
