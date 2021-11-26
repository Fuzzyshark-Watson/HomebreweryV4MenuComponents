using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.AbilityScoreTypes
{
    class RacialAbilityScore : AbilityScore
    {
        //All this does is denote a TYPE of ability Score bonuses, other sources include: Enhancement, Inherent, Mythic, Advancement, Profane and Sacred
        public RacialAbilityScore(int aBaseValue, AbilityScores aAbilityScore) : base(aBaseValue, aAbilityScore)
        {
        }
    }
}
