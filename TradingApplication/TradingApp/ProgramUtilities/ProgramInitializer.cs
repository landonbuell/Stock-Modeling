using System;
using System.Collections.Generic;
using System.Text;

namespace TradingApp.ProgramUtilities
{
    public class ProgramInitializer
    {
        // Initialize Parameters for the Program to run

        private DateTime _timeStart;
        private string _homePath;

        public ProgramInitializer(string cwd)
        {
            // Constructor for ProgramInitializer Instance
            _timeStart = DateTime.Now;
            _homePath = cwd;
        }

        public DateTime StartDateTime { get { return _timeStart; } }

        public string StartTimeFormatted 
        { 
            get { return DateTimeUtilities.FormatDateTime(_timeStart); } 
        }

        public string LocalHomePath { get { return _homePath; } }

        public void Call()
        {
            // Run ProgramIntializer
            Console.WriteLine("\nProgram Startup Time: {0}",_timeStart.ToString());

            Console.WriteLine("Program Setup Complete");
        }
    }
}
