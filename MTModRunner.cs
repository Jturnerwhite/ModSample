using System;
using BepInEx;
using HarmonyLib;
using Trainworks.Interfaces;

namespace MTMod
{
    [BepInPlugin("prc.hybridcards", "Hybrid Cards", "1.0.0.0")]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("tools.modding.trainworks")]
    public class MTModRunner : BaseUnityPlugin, IInitializable
    {
        public void Initialize()
        {
            SubtypeHybrid.BuildAndRegister();
            SampleSpell.Make();
            HeadHedonist.Make();
            BriarBaron.Make();
            Stockpile.Make();
        }

        private void Awake()
        {
            Harmony harmony = new Harmony("prc.hybridcards");
            harmony.PatchAll();
        }
    }
}