using System;
using System.Collections.Generic;
using System.Text;
using VirtualPetAxolotl.AxolotlSpace;

namespace VirtualPetAxolotl.StateSpace
{
    public enum FilterStateType
    {
        Clean = 0,
        Dirty = 3
    }
    class FilterState : State
    {
        public FilterStateType CurrentStateType { get; set; } = FilterStateType.Clean;

        public override void UpdateState()
        {
            FilterStateType NewStateType;
            int currentTypeDestroyRate = 0;

            if (HP >= 50)
            {
                NewStateType = FilterStateType.Clean;
                int currentVal = (int)CurrentStateType;

                foreach (FilterStateType type in Enum.GetValues(typeof(FilterStateType)))
                {
                    int val = (int)type;

                    if (val <= currentVal)
                    {
                        currentTypeDestroyRate += val;
                    }
                }

                currentTypeDestroyRate *= -1;
            }
            else
            {
                NewStateType = FilterStateType.Dirty;
            }

            if (NewStateType != CurrentStateType)
            {
                CurrentStateType = NewStateType;
                Axolotl.AxolotlState.DestroyRate
                    += currentTypeDestroyRate
                    += (int)CurrentStateType;

                Axolotl.TankState.DestroyRate
                    += currentTypeDestroyRate
                    += (int)CurrentStateType;
            }

            Dashboard.UpdateFitlerHpBar();
        }
    }
}
