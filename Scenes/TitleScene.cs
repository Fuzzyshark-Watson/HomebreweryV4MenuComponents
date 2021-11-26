using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomebreweryV4MenuComponents;

namespace HomebreweryV4MenuComponents.Scenes
{
    class TitleScene : AbstractScene
    {
        public TitleScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
            Options = new string[] { "Character", "Credits", "Quit" };
            Prompt = @"
██╗░░██╗░█████╗░███╗░░░███╗███████╗██████╗░██████╗░███████╗░██╗░░░░░░░██╗███████╗██████╗░██╗░░░██╗
██║░░██║██╔══██╗████╗░████║██╔════╝██╔══██╗██╔══██╗██╔════╝░██║░░██╗░░██║██╔════╝██╔══██╗╚██╗░██╔╝
███████║██║░░██║██╔████╔██║█████╗░░██████╦╝██████╔╝█████╗░░░╚██╗████╗██╔╝█████╗░░██████╔╝░╚████╔╝░
██╔══██║██║░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██╔══██╗██╔══╝░░░░████╔═████║░██╔══╝░░██╔══██╗░░╚██╔╝░░
██║░░██║╚█████╔╝██║░╚═╝░██║███████╗██████╦╝██║░░██║███████╗░░╚██╔╝░╚██╔╝░███████╗██║░░██║░░░██║░░░
╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░
Welcome to the Homebrewery. What would you like to do?
(Use your arrow and enter keys to navigate the menu)";
            AbstractScene myMakeCharacterScene = new MakeCharacterScene(Options, Prompt);
            AbstractScene myCreditscene = new CreditsScene(Options, Prompt);
            mySceneOptions.Add(myMakeCharacterScene);
            mySceneOptions.Add(myCreditscene);
        }
    }
}
