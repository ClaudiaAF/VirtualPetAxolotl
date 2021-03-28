using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.StateSpace
{
    enum AxolotlStateType
    {
        Healthy,
        Content,
        Sick,
        Dead
    }

    class AxolotlState : State
    {
        public AxolotlStateType CurrentStateType { get; set; } = AxolotlStateType.Healthy;

        public override void UpdateState()
        {
            AxolotlStateType NewStateType;

            if (HP >= 50)
            {
                NewStateType = AxolotlStateType.Healthy;
            } else if (HP < 50 && HP >=25) 
            {
                NewStateType = AxolotlStateType.Content;
            } else if (HP < 25 && HP > 0)
            {
                NewStateType = AxolotlStateType.Sick;
            } else
            {
                NewStateType = AxolotlStateType.Dead;
            }

            if (NewStateType != CurrentStateType)
            {
                CurrentStateType = NewStateType;

                Console.WriteLine("Current Destroy Rate: " + DestroyRate);
                Dashboard.UpdateAxolotlImage();
            }

            Dashboard.UpdateAxolotlHpBar();
        }
    }
}
