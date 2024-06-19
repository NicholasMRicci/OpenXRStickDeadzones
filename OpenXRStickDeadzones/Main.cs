using System;
using System.Reflection;
using Harmony;
using UnityEngine;

namespace OpenXRStickDeadzones
{
    public class Main : VTOLMOD
    {
        // This method is run once, when the Mod Loader is done initialising this game object
        public override void ModLoaded()
        {
            HarmonyInstance instance = HarmonyInstance.Create("deadzones.mymod");
            instance.PatchAll(Assembly.GetExecutingAssembly());
            base.ModLoaded();
        }
    }
}