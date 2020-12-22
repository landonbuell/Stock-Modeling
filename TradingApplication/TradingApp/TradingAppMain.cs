using System;
using System.IO;

using TradingApp.ProgramUtilities;

namespace TradingApp
{
    class TradingAppMain
    {
        static void Main(string[] args)
        {
            string homePath = Directory.GetCurrentDirectory();
            ProgramInitializer Startup = new ProgramInitializer(homePath);
            Startup.Call();

        }
    }
}
