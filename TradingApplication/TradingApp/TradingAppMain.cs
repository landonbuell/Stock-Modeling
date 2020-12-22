using System;
using System.IO;

using TradingApp.ProgramModes;

namespace TradingApp
{
    class TradingAppMain
    {
        static void Main(string[] args)
        {
            // Run Program Startup
            string homePath = Directory.GetCurrentDirectory();
            StartupMode Startup = new StartupMode(homePath);
            Startup.Call();

            // Run Main Program
            ExecutionMode Run = new ExecutionMode(homePath);
            Run.Call();
            string termPath = Run.CurrentDirectory;

            // Run Program Shutdown
            ShutdownMode Finish = new ShutdownMode(termPath);
            Finish.Call();
        }
    }
}
