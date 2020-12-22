using System;
using System.Collections.Generic;
using System.Text;

using TradingApp.ProgramCommands;

namespace TradingApp.ProgramModes
{

    class ExecutionMode : ProgramMode
    {

        private int _loopCounter = 0;
        private string _currentCommand;

        private Dictionary<string, Command> CommandDictionary;

        internal ExecutionMode(string cwd) : base(cwd)
        {
            // Constructor for ExecutionMode Instance
            CurrentMode = "ExecutionMode";
            Console.WriteLine("{0} constructed at {1}", CurrentMode, _timeStart.ToString());
        }

        ~ExecutionMode()
        {
            // Destructor for ExecutionMode Instance
            Console.WriteLine("{0} constructed at {1}", CurrentMode, DateTime.Now.ToString());
        }
            
        internal void Call()
        {
            // Call the main ProgramRun Mode
            while (true)
            {
                // Idefinite Loop
                try
                {
                    // Accept User Inpit
                    Console.Write("[{0}] >>> ",_loopCounter);
                    string userInput = Console.ReadLine();
                }
                catch
                {

                }
                _loopCounter += 1;
            }
        }

        #region CommandTools

        private void ReadUserInput(string userInput)
        {
            // Process user input from Command Line
            string[] tokens = userInput.Split(" ");
            try
            {
                // Match String to a command
                _currentCommand = tokens[0];
            }
            catch
            {
                Console.WriteLine("\tNo Command Detected!");
            }
        }

        private void ReadCommand()
        {
            // Read User Supplied Command From Command Line
        }

        private void BuildCommandDictionary()
        {
            // Construct Dictionary of string -> Command

        }

        #endregion



    }
}
