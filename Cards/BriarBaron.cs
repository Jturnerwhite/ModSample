using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaCardPoolIDs;

namespace MTMod
{
    public class BriarBaron
    {
        /// <summary>
        /// Makes the card
        /// </summary>
        public static void Make()
        {
            CharacterDataBuilder briarBaronCharacter = new CharacterDataBuilder
            {
                CharacterID = "HybridCard_BriarBaronCard",
                Name = "Briar Baron",
                Size = 3,
                Health = 40,
                AttackDamage = 5,
                AssetPath = "assets/unitCartArt/BriarBaronCharArt.png",
                SubtypeKeys = new List<string> { SubtypeHybrid.Key },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                        Description = "Gain <nobr><b>Spikes</b> <b>1</b></nobr>",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Monsters,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        count = 1,
                                        statusId = VanillaStatusEffectIDs.Spikes
                                    }
                                }
                            }
                        }
                    }
                }
            };

            //VanillaCardPoolIDs has pools for where to find the card.
            CardDataBuilder card = new CardDataBuilder
            {
                CardID = "HybridCard_BriarBaronCard",
                Name = "Briar Baron",
                Cost = 2,
                Description = "",
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                AssetPath = "assets/unitCartArt/BriarBaronCardArt.png",

                CardPoolIDs = new List<string> { AwokenBanner, RemnantBanner },
                TargetsRoom = true,
                Targetless = false,
                ClanID = VanillaClanIDs.Awoken,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                        TargetMode = TargetMode.DropTargetCharacter,
                        ParamCharacterDataBuilder = briarBaronCharacter
                    }
                }
            };

            card.BuildAndRegister();
        }
    }
}