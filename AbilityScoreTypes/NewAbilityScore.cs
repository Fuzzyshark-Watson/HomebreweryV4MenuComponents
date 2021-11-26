using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.AbilityScoreTypes
{
    public class NewAbilityScore : AbilityScore
    {
        private readonly List<AbilityScore> ListOfAttributeBonuses;
        private int finalValue;
        private int finalModifiedValue;

        //Here we see the public constructor for creating a new ability score (which will be done 6 times per new character.)
        //Each new ability score also contains a list to which we add all of our bonuses, as necessary. 
        //Long term, I wish I could split this up in such a way I can run an indepth troubleshoot to see what each "Final" Ability Score is made of, and where each bonus comes from
        public NewAbilityScore(int aBaseValue, AbilityScores aAbilityScore) : base(aBaseValue, aAbilityScore)
        {
            ListOfAttributeBonuses = new List<AbilityScore>();
        }

        //Adds a bonus of a given name to our List named Ability Score
        public void AddBonus(AbilityScore bonus)
        {
            if (bonus is AbilityScore)
            {
                ListOfAttributeBonuses.Add(bonus as AbilityScore);
            }
        }

        //Removes a bonus of a given name from our List named Ability Score
        public void RemoveBonus(AbilityScore bonus)
        {
            if (bonus is AbilityScore)
            {
                ListOfAttributeBonuses.Remove(bonus as AbilityScore);
            }
        }

        //A bunch of bonuses can be added to our list, and needs to be added up to become our final value -
        //an issue presents itself if I want perfect knowledge of which bonuses gets added together for the final product, but this is
        //more along the lines a QoL fix than a necessary part of my core program.
        private int AbilityScoreValue()
        {
            finalValue = BaseValue;

            //Adding value from raw
            int rawBonusValue = 0;

            if (ListOfAttributeBonuses.Count > 0)
            {
                foreach (AbilityScore bonus in ListOfAttributeBonuses)
                {
                    rawBonusValue += bonus.BaseValue;
                }
            }
            finalValue += rawBonusValue;
            return finalValue;
        }

        //Your Ability Score(AS) Modifiers are Calculated from the formulae that a given character has a baseline of 10 in all AS,
        //Representing no particular gift nor weakness, aka 0 Modifier. For every two points above this point, the modifier increases by +1.
        //Adversely, this also means that lowering below 10 follows the same rules, 9 = -1, 8 = -1, 7 =-2, and so on.
        //We calculate this using the following calculations.
        private int AbilityModValue()
        {   
            if (finalValue < 10)
            {
                finalModifiedValue = ((11 - finalValue) / 2) * -1;
            }
            else
            {
                finalModifiedValue = (finalValue - 10) / 2;
            }
            return finalModifiedValue;
        }

        //Get for Ability Score (Final Total)
        public int FinalAbilityScoreValue()
        {
            return AbilityScoreValue();
        }

        //Get for Ability Modifier (Final Total)
        public int FinalModValue()
        {
            return AbilityModValue();
        }
    }
}
