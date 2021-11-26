using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents
{
    public enum AbilityScores
    {
        Str,
        Dex,
        Con,
        Int,
        Wis,
        Cha
    }
    abstract public class AbilityScore
    {
        //private int _BaseValue;

        public int BaseValue
        {
            get { return baseAbilityValue; }
            set { baseAbilityValue = value; }
        }

        private int baseAbilityValue;

        private readonly int baseAbilityModifier;

        private readonly AbilityScores abilityScore;

        public AbilityScore(int aBaseValue, AbilityScores aAbilityScore)
        {
            baseAbilityValue = aBaseValue;
            abilityScore = aAbilityScore;
            baseAbilityModifier = CalcModifierValue(baseAbilityValue);
        }

        protected int CalcModifierValue(int attTotalValue)
        {   //Modifier, 0=-5, every 2 points up is a +1 to this value. Potentially limitless.
            if (attTotalValue < 10)
            {

                return ((11 - attTotalValue) / 2) * -1;
            }
            return (attTotalValue - 10) / 2;
        }

        public int BaseModifierValue()
        {
            return baseAbilityModifier;
        }

        public AbilityScores BaseType()
        {
            return abilityScore;
        }
    }
}
