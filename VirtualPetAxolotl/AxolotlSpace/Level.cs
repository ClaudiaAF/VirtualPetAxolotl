using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.AxolotlSpace
{
    class Levels
    {
        public static int GetLevelFromXp(int Xp)
        {
            return Xp / 1000;
        }
    }
}
