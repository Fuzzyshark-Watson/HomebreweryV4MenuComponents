using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomebreweryV4MenuComponents.Scenes;

namespace HomebreweryV4MenuComponents
{
    class ConsoleUI
    {
        readonly string[] Options;
        readonly string Prompt;

        public AbstractScene myActiveMenu;

        // We're starting out by creating our Titlescene and running our menu based on the Options and Prompt in our RunMenu() Method
        public void Start()
        {
            AbstractScene myTitlescene = new TitleScene(Options, Prompt);
            myActiveMenu = myTitlescene;
            RunMenu();
        }
        /*To do list:
         * Ability Scores <
         * Class
         * Feats and Traits 
         * Point Buy <
         * Race
         * Skills <
         */

        //RunMenu starts a stack whose purpose it is to hold and maintain my stack for moving back and forth in the program without creating new versions
        //As I go deeper, this stack is used to return back to a previous level consistently.
        //his also makes use of my ChoosingOption() method to navigate each layers different options and where to go. 
        //While Rundisplay() refreshes the UI with new info belonging to my active menu.
        //Each scene uses inheritance from an abstract class. But their info rests in each scene class.
         
        public void RunMenu()
        {
            Stack<AbstractScene> myReturnStack = new Stack<AbstractScene>();
            myReturnStack.Push(myActiveMenu);

            while (true)
            {   //Our Control structure is that my active menu gets replaced by what we get from our ChoosingOption() method
                //For more info on ChoosingOption() and RunDisplay() go to the AbstractScene Class
                myActiveMenu = myActiveMenu.ChoosingOption(myActiveMenu.RunDisplay());

                //We then compare the menu returned from the method with our current top of the stack
                //If the two menu's are the same, and theres something on the stack, we remove the top of the stack,
                //elsewise we put the new menu on top of the stack
                //We then use the new top of the stack as our current menu
                //If there is nothing left on the stack we instead quit the application.
                if (myActiveMenu == myReturnStack.Peek())
                {
                    if (myReturnStack.Count > 0)
                    {
                        myReturnStack.Pop();
                        if (myReturnStack.Count > 0)
                        {
                            myActiveMenu = myReturnStack.Peek();
                        }
                        if (myReturnStack.Count == 0)
                        {
                            Toolbox.QuitConsole();
                        }
                    }
                }
                else
                {
                    myReturnStack.Push(myActiveMenu);
                }
            }
        }
    }
}
