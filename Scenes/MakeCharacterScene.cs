using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebreweryV4MenuComponents.Scenes
{
    class MakeCharacterScene : AbstractScene
    {
        //public AbstractScene myActiveMenu;
        //public BaseCharacter Testman;
        public List<BaseCharacter> myBaseCharacter = new List<BaseCharacter>();

        public MakeCharacterScene(string[] aOptions, string aPrompt) : base(aOptions, aPrompt)
        {
            Options = new string[] { "New Character", "Load Character", "Return to Title" };
            Prompt = @"
███╗░░░███╗░█████╗░██╗░░██╗███████╗  ░█████╗░██╗░░██╗░█████╗░██████╗░░█████╗░░█████╗░████████╗███████╗██████╗░
████╗░████║██╔══██╗██║░██╔╝██╔════╝  ██╔══██╗██║░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
██╔████╔██║███████║█████═╝░█████╗░░  ██║░░╚═╝███████║███████║██████╔╝███████║██║░░╚═╝░░░██║░░░█████╗░░██████╔╝
██║╚██╔╝██║██╔══██║██╔═██╗░██╔══╝░░  ██║░░██╗██╔══██║██╔══██║██╔══██╗██╔══██║██║░░██╗░░░██║░░░██╔══╝░░██╔══██╗
██║░╚═╝░██║██║░░██║██║░╚██╗███████╗  ╚█████╔╝██║░░██║██║░░██║██║░░██║██║░░██║╚█████╔╝░░░██║░░░███████╗██║░░██║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝  ░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝
Welcome to Make Character, this is a placeholder!";
            AbstractScene myChareditscene = new CharacterEditingScene(Options, Prompt);
            AbstractScene myloadedChareditscene = new CharacterEditingScene(Options, Prompt);
            mySceneOptions.Add(myChareditscene);
            mySceneOptions.Add(myloadedChareditscene);
            
        }//Make character from here
        //public void RunMenu()
        //{
        //    while (true) //Infinite Loop, skal bruge et break
        //    {   
        //        //myActiveMenu = ChoosingOption(RunDisplay());
        //        //for (int i = 0; i < mySceneOptions.Count; i++)
        //        //{
        //        //    //We're looking to create the menu structure of manipulating our other menu's here, look into making a way to interact with lists and shit
        //        //    //List af character values (Class, race, skills, feats, ability Scores,) i stedet for stack...
        //        //}
        //        //if (mySceneOptions.Count > 0)   
        //        //    //Fulde længde af alle muligheder, vil altid være længere end 0
        //        //    //Blev brugt til stacks, vi skal bruge det til at navigere frem og tilbage
        //        //    //I forhold til en liste?
        //        //{
        //        //    mySceneOptions.Pop();
        //        //    if (mySceneOptions.Count > 0)
        //        //    {
        //        //        myActiveMenu = mySceneOptions.Peek();
        //        //    }
        //        //    if (mySceneOptions.Count == 0)
        //        //    {
        //        //        break;
        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    mySceneOptions.Push(myActiveMenu);
        //        //}
        //    }

        //}
    }
}
