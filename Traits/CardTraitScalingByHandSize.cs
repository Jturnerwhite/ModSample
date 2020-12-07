using System;
using System.Collections.Generic;
using System.Text;

namespace MTMod.Traits
{
    public sealed class CardTraitScalingByHandSize : CardTraitState
    {
        public override bool OnCardBeingUpgraded(CardState cardState, CardState upgradingCardSource, CardManager cardManager, CardUpgradeState cardUpgradeState)
        {
            int scaleAmount = GetScaleAmount(upgradingCardSource, cardManager);

            cardUpgradeState.SetAttackDamage(cardUpgradeState.GetAttackDamage() * scaleAmount);
            cardUpgradeState.SetAdditionalHP(cardUpgradeState.GetAdditionalHP() * scaleAmount);
            cardUpgradeState.SetCostReduction(cardUpgradeState.GetCostReduction() * scaleAmount);
            cardUpgradeState.SetAdditionalHeal(cardUpgradeState.GetAdditionalHeal() * scaleAmount);
            cardUpgradeState.SetAdditionalSize(cardUpgradeState.GetAdditionalSize() * scaleAmount);
            foreach (StatusEffectStackData statusEffectStackData in cardUpgradeState.GetStatusEffectUpgrades())
            {
                cardUpgradeState.AddStatusEffectUpgradeStacks(statusEffectStackData.statusId, statusEffectStackData.count * (scaleAmount - statusEffectStackData.count));
            }

            return true;
        }

        public int GetScaleAmount(CardState upgradingCardSource, CardManager cardManager)
        {
            int paramInt = base.GetParamInt();

            if(upgradingCardSource != null)
            {
                return paramInt * cardManager.GetHand().Count;
            }

            return 0;
        }
    }
}
