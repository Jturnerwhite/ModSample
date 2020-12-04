using System.Collections.Generic;
using Trainworks.Builders;
using Trainworks.Constants;

namespace MTMod
{
    public class NotHornBreak
    {
        public static readonly string ID = "MT_NotHornBreak";

        public static void Make()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Not Horn Break",
                Description = "Deal [effect0.power] damage",
                Cost = 1,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = VanillaClanIDs.Awoken,
                AssetPath = "assets/spellCardArt/sampleSpell.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                        ParamInt = 5,
                        TargetMode = TargetMode.DropTargetCharacter
                    }
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
                }
            }.BuildAndRegister();
        }
    }
}