using System;
using Harmony;
using UnityEngine;
using VTOLVR;


[HarmonyPatch(typeof(VTOpenXRController), nameof(VTOpenXRController.GetStickAxis))]
public class Patch_VTOpenXRController
{
    public static void Postfix(ref Vector2 __result)
    {
        if (__result.magnitude <= 0.16f) {
            __result = Vector2.zero;
        }
    }
}