using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomebreweryV4MenuComponents.AbilityScoreTypes;

namespace HomebreweryV4MenuComponents
{
    class Race
    {
        //Taken from Ability scores, we made a list to contain all of our Ability score changes to be used elsewhere.
        public List<AbilityScore> RaceStatModifier;
        //This enum helps us define what race types are considered valid inputs
        public enum RaceType
        {
            Dwarf,
            Elf,
            Gnome,
            Half_elfStatless,
            Half_elfStr,
            Half_elfDex,
            Half_elfCon,
            Half_elfInt,
            Half_elfWis,
            Half_elfCha,
            Halfling,
            HumanStatless,
            HumanStr,
            HumanDex,
            HumanCon,
            HumanInt,
            HumanWis,
            HumanCha,
            Half_OrcStatless,
            Half_OrcStr,
            Half_OrcDex,
            Half_OrcCon,
            Half_OrcInt,
            Half_OrcWis,
            Half_OrcCha
        }
        //Given a workable race from our enum, we will run through the RaceStat() Method which contains a switch which currently decides which stats are given.

        //This is not a workable sollution for me long term, each race has more than just ability scores associated with it,
        //including weapon proficiencies, and other bonuses which are either skills or others with varrying degrees of circumstantiality.
        public Race(RaceType r)
        {
            RaceStatModifier = new List<AbilityScore>();
            RaceStat(r);
        }
        private void RaceStat(RaceType race)
        {
            switch (race)
            {
                case RaceType.Dwarf:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Con));
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Wis));
                    RaceStatModifier.Add(new RacialAbilityScore(-2, AbilityScores.Cha));
                    break;
                case RaceType.Elf:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Dex));
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Int));
                    RaceStatModifier.Add(new RacialAbilityScore(-2, AbilityScores.Con));
                    break;
                case RaceType.Gnome:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Con));
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Cha));
                    RaceStatModifier.Add(new RacialAbilityScore(-2, AbilityScores.Str));
                    break;
                case RaceType.Half_elfStatless:
                    break;
                case RaceType.Half_elfStr:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Str));
                    break;
                case RaceType.Half_elfDex:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Dex));
                    break;
                case RaceType.Half_elfCon:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Con));
                    break;
                case RaceType.Half_elfInt:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Int));
                    break;
                case RaceType.Half_elfWis:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Wis));
                    break;
                case RaceType.Half_elfCha:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Cha));
                    break;
                case RaceType.Halfling:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Dex));
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Cha));
                    RaceStatModifier.Add(new RacialAbilityScore(-2, AbilityScores.Str));
                    break;
                case RaceType.HumanStatless:
                    break;
                case RaceType.HumanStr:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Str));
                    break;
                case RaceType.HumanDex:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Dex));
                    break;
                case RaceType.HumanCon:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Con));
                    break;
                case RaceType.HumanInt:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Int));
                    break;
                case RaceType.HumanWis:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Wis));
                    break;
                case RaceType.HumanCha:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Cha));
                    break;
                case RaceType.Half_OrcStatless:
                    break;
                case RaceType.Half_OrcStr:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Str));
                    break;
                case RaceType.Half_OrcDex:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Dex));
                    break;
                case RaceType.Half_OrcCon:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Con));
                    break;
                case RaceType.Half_OrcInt:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Int));
                    break;
                case RaceType.Half_OrcWis:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Wis));
                    break;
                case RaceType.Half_OrcCha:
                    RaceStatModifier.Add(new RacialAbilityScore(2, AbilityScores.Cha));
                    break;
                default:
                    break;
            }
        }
    }
}
