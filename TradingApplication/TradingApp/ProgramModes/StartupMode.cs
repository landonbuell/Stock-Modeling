using System;
using System.Collections.Generic;
using System.Text;

namespace TradingApp.ProgramModes
{
    class StartupMode : ProgramMode
    {
        // Initialize Parameters for the Program to run

        

        internal StartupMode(string cwd) : base(cwd)
        {
            // Constructor for StartupMode Instance
            CurrentMode = "StartupMode";
            Console.WriteLine("{0} constructed at {1}", CurrentMode, _timeStart.ToString());
        }
        
        internal void Call()
        {
            // Run ProgramIntializer

        }
    }
}
