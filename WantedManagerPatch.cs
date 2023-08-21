using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx.Logging;
using HarmonyLib;

namespace ZenModeAlpha
{
    [HarmonyPatch(typeof(Reptile.WantedManager))]
    [HarmonyPatch(nameof(Reptile.WantedManager.CrimePerpetrated))]
    class WantedManagerPatch
    {
        public static bool Prefix() 
        {
            var log = Logger.CreateLogSource(nameof(WantedManagerPatch));
            log.LogInfo("PrefixPatch called");


            return false; 
        }
    }
}
