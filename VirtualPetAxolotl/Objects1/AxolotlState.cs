using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAxolotl.NewFolder1
{
    public enum AxolotlState
    {
        healthy,
        nothealthy,
        sick
    }
    class AxolotlStates
    {
        public static string GetAxolotlString(AxolotlState axolotlState)
        {
            switch (axolotlState)
            {
                case AxolotlState.healthy:
                    return "healthy";
                case AxolotlState.nothealthy:
                    return "not healthy";
                case AxolotlState.sick:
                    return "sick";
                default:
                    return "swimming";
            }
        }

        public static AxolotlState GetAxolotlState(string axolotlString)
        {
            switch (axolotlString) 
            {
                case "healthy":
                    return AxolotlState.healthy;
                case "not healthy":
                    return AxolotlState.nothealthy;
                case "sick":
                    return AxolotlState.sick;
                default:
                    return AxolotlState.healthy;


            }

        }
    }
}
