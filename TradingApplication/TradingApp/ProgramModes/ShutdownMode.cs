using System;

namespace TradingApp.ProgramModes
{
    class ShutdownMode : ProgramMode
    {
        // Close Parameters for the Program to run

        internal ShutdownMode(string cwd) : base(cwd)
        {
            // Constructor for StartupMode Instance
            CurrentMode = "ShutdownMode";
            Console.WriteLine("{0} constructed at {1}", CurrentMode, _timeStart.ToString());
        }

        internal void Call()
        {
            // Run ProgramFinisher
        }

    }
}
