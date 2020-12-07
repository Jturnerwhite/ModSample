using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTMod
{
    [HarmonyPatch(typeof(CharacterData))]
    [HarmonyPatch("GetName")]
    public static class NameChangerFrank
    {
        private static void Postfix(ref string __result)
        {
            bool flag = __result == "Hornbreaker Prince";
            if (flag)
            {
                __result = "Frank";
            }
        }
    }

    [HarmonyPatch(typeof(CardState))]
    [HarmonyPatch("GetTitle")]
    public static class NameChangerFrankCard
    {
        private static void Postfix(ref string __result)
        {
            bool flag = __result == "Hornbreaker Prince";
            if (flag)
            {
                __result = "Frank";
            }
        }
    }
}
