using System;
using BepInEx;
using HarmonyLib;

namespace MTMod
{
    [BepInPlugin("prc.hybridcards", "Hybrid Cards", "1.0.0.0")]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("tools.modding.trainworks")]
    public class MTMod : BaseUnityPlugin
    {
        public void Initialize()
        {
            SampleSpell.Make();
            NotHornBreak.Make();
            GiveEveryoneArmor.Make();
        }

        private void Awake()
        {
            Harmony harmony = new Harmony("prc.hybridcards");
            harmony.PatchAll();
        }
    }
}