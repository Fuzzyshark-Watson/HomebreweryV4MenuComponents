using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomebreweryV4MenuComponents
{
    abstract public class AbstractScene
    {
        public string Prompt, prefix, currentOption;
        public string[] Options;
       
        protected int SelectedIndex;
        
        private ConsoleKeyInfo keyInfo;

        //This list is used to capture an idea of what the different options are for this class, each class adds their options to the Class, its list
        //then we use the list to navigate to the next page and the next.
        //This does mean that this has to be defined clearly for each new scene.
        public List<AbstractScene> mySceneOptions = new List<AbstractScene>();


        //Our Abstract constructer for what a scene will look like.
        //Prompt will be painted at the top of the screen (for now) and the Options are our menu elements in string format.
        public AbstractScene(string[] aOptions, string aPrompt)
        {
            Prompt = aPrompt;
            Options = aOptions;
        }
        //public int GetSelectedIndex()
        //{
        //    return SelectedIndex;
        //}
        //public string GetPrompt()
        //{
        //    return Prompt;
        //}
        //public string[] GetOptions()
        //{
        //    return Options;
        //}
        //public void PrintInfo()
        //{   
        //    ChoosingOption(RunDisplay());
        //}
        //Several Methods are called from ConsoleUI, looking like so:
        //myActiveMenu = myActiveMenu.ChoosingOption(myActiveMenu.RunDisplay());
        //Which means Choosingoptions() takes an integer from Rundisplay()
        //Rundisplay() however, takes from DisplayOptionsAndIndex()

        //DisplayOptionsAndIndex() Takes the prompt and writes out the Graphic UI, highlighting the option currently hovered over.
        private void DisplayOptionsAndIndex() 
        {
            Clear();
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                currentOption = Options[i];
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix} << {currentOption} >>");
            }
            ResetColor();
        }

        //RunDisplay() Waits for a key input and checks if its up, down, enter or escape, to navigate by, and then runs DisplayOptionsAndIndex() to refresh the UI.
        //When Enter is pressed, it returns an integer to ChoosingOptions()
        public int RunDisplay()
        {
            //Clear();
            //WriteLine(Prompt);
            //for (int i = 0; i < Options.Length; i++)
            //{
            //    currentOption = Options[i];
            //    if (i == SelectedIndex)
            //    {
            //        prefix = "*";
            //        ForegroundColor = ConsoleColor.Black;
            //        BackgroundColor = ConsoleColor.White;
            //    }
            //    else
            //    {
            //        prefix = " ";
            //        ForegroundColor = ConsoleColor.White;
            //        BackgroundColor = ConsoleColor.Black;
            //    }
            //    WriteLine($"{prefix} << {currentOption} >>");
            //}
            //ResetColor();
            ConsoleKey keyPressed;
            do
                            {                
                Clear();
                DisplayOptionsAndIndex();
                keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                if (keyPressed == ConsoleKey.Escape)
                {
                    SelectedIndex = Options.Length;
                    break;
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }

        //Taking an integer from earlier, Choosingoptions() uses this to find out if they should go back to the previous step
        //Either by being out of bounds or by being the last option (universally the Exit/Return button)
        //or slots the choice into our Initial stack controller
        public AbstractScene ChoosingOption(int SelectedIndexFromRunDisplay)
        {
            if (SelectedIndexFromRunDisplay <= -1)
            {
                return this;
            }
            if (SelectedIndexFromRunDisplay >= mySceneOptions.Count)
            {
                return this;
            }
            else
            {
                for (int i = 0; i < mySceneOptions.Count; i++)
                {
                    if (i == SelectedIndexFromRunDisplay)
                    {
                        return mySceneOptions[i];
                    }
                }
            }
            return mySceneOptions[0];
        }
    }
}