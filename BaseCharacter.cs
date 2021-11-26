using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomebreweryV4MenuComponents.AbilityScoreTypes;

namespace HomebreweryV4MenuComponents
{
    class BaseCharacter
    {
        readonly string _Name;
        //Race _Race;
        public List<NewAbilityScore> myAbilityScore;

        public BaseCharacter(string aCharName)
        {
            _Name = aCharName;
            //myRace = aRace;
            myAbilityScore = SetupAbilityScores();
        }

        private List<NewAbilityScore> SetupAbilityScores()
        {   //Runs 6 times
            List<NewAbilityScore> myAbilityScore = new List<NewAbilityScore>();
            for (int i = 0; i < 6; i++)
            {   //Adds a new attribute for the character.
                NewAbilityScore newA = new NewAbilityScore(10, (AbilityScores)i);
                myAbilityScore.Add(newA);

                //foreach (RacialAbilityScore b in myRace.RaceStatModifier)
                //{
                //    if (b.BaseType() == (AbilityScores)i)
                //    {
                //        newA.AddBonus(b);
                //    }
                //}
            }
            return myAbilityScore;
        }

        public void IncreaseAbility(AbilityScores choice)
        {
            foreach (NewAbilityScore item in myAbilityScore)
            {
                //Finder den rigtige abilityScore
                if (choice == item.BaseType())
                {
                    //Increase Base Value
                    item.BaseValue++;
                    //ReCalculate Final Value;
                    break;
                }
            }
        }

        public void DecreaseAbility(AbilityScores choice)
        {
            foreach (NewAbilityScore item in myAbilityScore)
            {
                //Finder den rigtige abilityScore
                if (choice == item.BaseType())
                {
                    //Increase Base Value
                    item.BaseValue--;
                    //ReCalculate Final Value;
                    break;
                }
            }
        }

//Mostly a debugging tool, used so I can see if the values work.
        public void PrintProof()
        {
            foreach (NewAbilityScore a in myAbilityScore)
            {
                Console.WriteLine($"{_Name} has basetype: {a.BaseType()} Ability score value: {a.FinalAbilityScoreValue()} Modifier: [{a.FinalModValue()}]");
            }
            Console.ReadKey(true);
        }
    }
}
