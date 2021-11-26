using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomebreweryV4MenuComponents
{
    class Program
    {   //Our program starts with a screen size check and then runs our ConsoleUI with the Start() method.
        static void Main(string[] args)
        {
            Title = "Demo Menu";
            CursorVisible = false;
            try
            {
                WindowWidth = 130;
                WindowHeight = 35;
            }
            catch
            {
                WriteLine(@"Window won't fit, try changing stuff");
                Toolbox.WaitForKeyPress();
            }
            ConsoleUI CUI = new ConsoleUI();
            CUI.Start();
        }
    }
}
