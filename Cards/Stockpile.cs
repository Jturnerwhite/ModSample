using MTMod.Traits;
using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;
using Trainworks.Utilities;

namespace MTMod
{
	public class Stockpile
	{
		public static void Make()
		{
			CardDataBuilder stockpile = new CardDataBuilder
			{
				Cost = 3,
				CardID = "HybridCard_Stockpile",
				Name = "Stockpile",
				Description = "Apply Regen equal to the amount of cards in hand.",
				Rarity = CollectableRarity.Rare,
				CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
				ClanID = VanillaClanIDs.Awoken,
				TargetsRoom = true,
				Targetless = false,
				EffectBuilders = new List<CardEffectDataBuilder>
				{
					new CardEffectDataBuilder
					{
						EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
						TargetMode = TargetMode.DropTargetCharacter,
						TargetTeamType = Team.Type.Monsters,
						ParamInt = 1,
						UseStatusEffectStackMultiplier = true,
						ParamStatusEffects = new StatusEffectStackData[]
						{
							new StatusEffectStackData
							{
								statusId = VanillaStatusEffectIDs.Regen,
								count = 1
							}
						}
					}
				},

				TraitBuilders = new List<CardTraitDataBuilder>
                {
					new CardTraitDataBuilder
                    {
						TraitStateType = typeof(CardTraitScalingByHandSize),
						ParamInt = 1
                    },
				},
				AssetPath = "assets/spellCardArt/sampleSpell.png",
			};

			stockpile.BuildAndRegister();
		}
	}
}
