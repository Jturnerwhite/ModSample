using System.Collections.Generic;
using Trainworks.Builders;
using Trainworks.Constants;

namespace MTMod
{
    public class GiveEveryoneArmor
    {
        public static readonly string ID = "MT_GiveEveryoneArmor";

        public static void Make()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Give Everyone Armor",
                Description = "Give everyone <nobr><b>Armor</b> <b>{[effect0.status0.power]}</b></nobr>.",
                Cost = 0,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = true,
                ClanID = VanillaClanIDs.Awoken,
                AssetPath = "assets/spellCardArt/sampleSpell.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Armor,
                                count = 2
                            }
                        }
                    }
                }
            }.BuildAndRegister();
        }
    }
}