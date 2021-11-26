using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.Scenes
{
    class RaceScene : AbstractScene
    {
        public RaceScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
            Prompt = @"
██████╗░░█████╗░░█████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔════╝
██████╔╝███████║██║░░╚═╝█████╗░░
██╔══██╗██╔══██║██║░░██╗██╔══╝░░
██║░░██║██║░░██║╚█████╔╝███████╗
╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚══════╝";
            Options = new string[] { "Return" };
        }
    }
}
