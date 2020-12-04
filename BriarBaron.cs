using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;
using static Trainworks.Constants.VanillaCardPoolIDs;

namespace MTMod
{
    public class BriarBaron
    {
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = "Hybrid_CardSample",
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = typeof(CardEffectSpawnMonster),
                        ParamCharacterDataBuilder = GetCharacterDataBuilder()
                    }
                }
            };
            return cardDataBuilder.BuildAndRegister();
        }
        public static CharacterDataBuilder GetCharacterDataBuilder()
        {
            CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
            {
                CharacterID = "Hybrid_CardSample",
                Name = "Briar Baron",
                Size = 3,
                Health = 40,
                AttackDamage = 5,
            };
            return characterDataBuilder;
        }
    }
}

//namespace MT_Hybrids
//{
//    public class BriarBaron
//    {
//        /// <summary>
//        /// Makes the card
//        /// </summary>
//        public static void Make()
//        {
//            CharacterDataBuilder briarBaronCharacter = new CharacterDataBuilder
//            {
//                CharacterID = "HybridCard_BriarBaronCard",
//                Name = "Briar Baron",
//                Size = 3,
//                Health = 40,
//                AttackDamage = 5,
//                AssetPath = "assets/BriarBaronCharArt.png",
//                SubtypeKeys = new List<string> { "SubtypesData_Wickless_517faf2f-8836-42d3-b84d-75a99b7dc735" },
//                TriggerBuilders = new List<CharacterTriggerDataBuilder>
//                {
//                    new CharacterTriggerDataBuilder
//                    {
//                        Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
//                        Description = "Gain <nobr><b>Spikes</b> <b>{[effect.0.status0.power]}</b></nobr>",
//                        EffectBuilders = new List<CardEffectDataBuilder>
//                        {
//                            new CardEffectDataBuilder
//                            {
//                                EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
//                                TargetMode = TargetMode.Self,
//                                TargetTeamType = Team.Type.Monsters,
//                                ParamStatusEffects = new StatusEffectStackData[]
//                                {
//                                    new StatusEffectStackData
//                                    {
//                                        count = 1,
//                                        statusId = VanillaStatusEffectIDs.Spikes
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            };

//            //VanillaCardPoolIDs has pools for where to find the card.
//            CardDataBuilder card = new CardDataBuilder
//            {
//                CardID = "HybridCard_BriarBaronCard",
//                Name = "Briar Baron",
//                Cost = 2,
//                Description = "",
//                CardType = CardType.Monster,
//                Rarity = CollectableRarity.Common,
//                AssetPath = "assets/BriarBaronCardArt.png",

//                CardPoolIDs = new List<string> { AwokenBanner, StygianBanner },
//                TargetsRoom = false,
//                Targetless = false,
//                EffectBuilders = new List<CardEffectDataBuilder>
//                {
//                    new CardEffectDataBuilder
//                    {
//                        EffectStateName = "CardEffectSpawnMonster",
//                        TargetMode = TargetMode.DropTargetCharacter,
//                        ParamCharacterDataBuilder = briarBaronCharacter
//                    }
//                }
//            };

//            card.BuildAndRegister();
//        }
//    }
//}
