using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.Scenes
{
    class AbilityScoreScene : AbstractScene
    {
        public AbilityScoreScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
        Prompt= @"
░█████╗░██████╗░██╗██╗░░░░░██╗████████╗██╗░░░██╗  ░██████╗░█████╗░░█████╗░██████╗░███████╗
██╔══██╗██╔══██╗██║██║░░░░░██║╚══██╔══╝╚██╗░██╔╝  ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝
███████║██████╦╝██║██║░░░░░██║░░░██║░░░░╚████╔╝░  ╚█████╗░██║░░╚═╝██║░░██║██████╔╝█████╗░░
██╔══██║██╔══██╗██║██║░░░░░██║░░░██║░░░░░╚██╔╝░░  ░╚═══██╗██║░░██╗██║░░██║██╔══██╗██╔══╝░░
██║░░██║██████╦╝██║███████╗██║░░░██║░░░░░░██║░░░  ██████╔╝╚█████╔╝╚█████╔╝██║░░██║███████╗
╚═╝░░╚═╝╚═════╝░╚═╝╚══════╝╚═╝░░░╚═╝░░░░░░╚═╝░░░  ╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝";
            Options = new string[] {"Str +", "Str -", "Dex +", "Dex -", "Con +", "Con -", "Int +", "Int -", "Wis +", "Wis -", "Cha +", "Cha -", "Return" };
            //AbstractScene myChareditscene = new CharacterEditingScene(Options, Prompt);
            //AbstractScene myloadedChareditscene = new CharacterEditingScene(Options, Prompt);
            //mySceneOptions.Add(myChareditscene);
            //mySceneOptions.Add(myloadedChareditscene);
            

            //testman.IncreaseAbility(AbilityScores.Dex);
            //testman.DecreaseAbility(AbilityScores.Dex);

            //testman.IncreaseAbility(AbilityScores.Con);
            //testman.DecreaseAbility(AbilityScores.Con);

            //testman.IncreaseAbility(AbilityScores.Int);
            //testman.DecreaseAbility(AbilityScores.Int);

            //testman.IncreaseAbility(AbilityScores.Wis);
            //testman.DecreaseAbility(AbilityScores.Wis);

            //testman.IncreaseAbility(AbilityScores.Cha);
            //testman.DecreaseAbility(AbilityScores.Cha);

        }
    }
}
