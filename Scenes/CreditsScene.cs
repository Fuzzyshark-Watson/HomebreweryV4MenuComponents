using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.Scenes
{
    class CreditsScene : AbstractScene
    {

        public CreditsScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
        Options = new string[]  { "Return" };
        Prompt = @"
░█████╗░██████╗░███████╗██████╗░██╗████████╗░██████╗
██╔══██╗██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔════╝
██║░░╚═╝██████╔╝█████╗░░██║░░██║██║░░░██║░░░╚█████╗░
██║░░██╗██╔══██╗██╔══╝░░██║░░██║██║░░░██║░░░░╚═══██╗
╚█████╔╝██║░░██║███████╗██████╔╝██║░░░██║░░░██████╔╝
░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝░░░╚═╝░░░╚═════╝░";

        }
    }
}
