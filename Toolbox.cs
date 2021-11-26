using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomebreweryV4MenuComponents
{
   static class Toolbox
    {
        public static void WaitForKeyPress()
        {
            WriteLine("Press any key to continue.");
            ReadKey(true);
        }
        public static void QuitConsole()
        {
            WriteLine("Press any key to exit.");
            Environment.Exit(0);
        }

        public static void WritePos(int XPos, string value)
        {
            CursorLeft = XPos;
            Write(value);
        }
    }
}
