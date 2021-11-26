using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.Scenes
{
    class CharacterEditingScene : AbstractScene
    {
        public CharacterEditingScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
            Options = new string[] { "Ability Scores", "Point Buy Method", "Feats and Traits", "Class", "Race", "Skills", "Save and Exit", "Exit Character Editor" };
        Prompt = @"
░█████╗░██╗░░██╗░█████╗░██████╗░░█████╗░░█████╗░████████╗███████╗██████╗░
██╔══██╗██║░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
██║░░╚═╝███████║███████║██████╔╝███████║██║░░╚═╝░░░██║░░░█████╗░░██████╔╝
██║░░██╗██╔══██║██╔══██║██╔══██╗██╔══██║██║░░██╗░░░██║░░░██╔══╝░░██╔══██╗
╚█████╔╝██║░░██║██║░░██║██║░░██║██║░░██║╚█████╔╝░░░██║░░░███████╗██║░░██║
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝";

            AbstractScene myAbilityScoreScene = new AbilityScoreScene(Options, Prompt);
            AbstractScene myPointBuyMethodScene = new PointBuyMethodScene(Options, Prompt);
            AbstractScene myFeatsTraitsScene = new FeatsTraitsScene(Options, Prompt);
            AbstractScene myClassScene = new ClassScene(Options, Prompt);
            AbstractScene myRaceScene = new RaceScene(Options, Prompt);
            AbstractScene mySkillsScene = new SkillsScene(Options, Prompt);

            mySceneOptions.Add(myAbilityScoreScene);
            mySceneOptions.Add(myPointBuyMethodScene);
            mySceneOptions.Add(myFeatsTraitsScene);
            mySceneOptions.Add(myClassScene);
            mySceneOptions.Add(myRaceScene);
            mySceneOptions.Add(mySkillsScene);
        }
    }
}
