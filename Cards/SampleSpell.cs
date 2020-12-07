using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;
using Trainworks.Utilities;

namespace MTMod
{
	public class SampleSpell
	{
		public static void Make()
		{
			CardDataBuilder sampleSpell = new CardDataBuilder
			{
				Cost = 0,
				CardID = "SampleSpell",
				Name = "SampleSpell",
				Description = "Blah for [attack] damage.",
				Rarity = CollectableRarity.Common,
				CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
				ClanID = VanillaClanIDs.Awoken,
				TargetsRoom = true,
				Targetless = false,
				EffectBuilders = new List<CardEffectDataBuilder>
				{
					new CardEffectDataBuilder
					{
						EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
						TargetMode = TargetMode.DropTargetCharacter,
						TargetTeamType = Team.Type.Heroes,
						ParamInt = 5,
					}
				},

				TraitBuilders = new List<CardTraitDataBuilder>
                {
					new CardTraitDataBuilder
                    {
						TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
				},
				//NameKey = "SampleSpell_Name",
				//OverrideDescriptionKey = "SampleSpell_Desc",
				//LinkedClass = DiscipleClan.getClan();
				AssetPath = "assets/spellCardArt/sampleSpell.png",
				//AssetPath = Utils.rootPath + Utils.sCardPath + "sampleSpell.png",
		};

			sampleSpell.BuildAndRegister();
		}
	}
}
