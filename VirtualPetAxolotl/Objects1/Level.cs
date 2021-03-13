using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.NewFolder1
{
    class Levels
    {
        public static int GetLevelFromXp(int xp)
        {
            if (xp == 0)
            {
                return 0;
            }
            else if (xp < 2000)
            {
                return 1;
            }
            else if (xp >= 2000)
            {
                return 2;
            } else
            {
                return 0;
            }

        }
    }
}
