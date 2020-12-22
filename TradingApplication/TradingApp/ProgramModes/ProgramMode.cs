using System;
using System.Collections.Generic;
using System.Text;

namespace TradingApp.ProgramModes
{
    abstract class ProgramMode
    {

        protected DateTime _timeStart;
        protected string _homePath;

        public string CurrentMode = "ProgramMode";
        public string CurrentDirectory { get; protected set; }

        internal ProgramMode(string cwd)
        {
            // Constructor for ProgramMode
            _timeStart = DateTime.Now;
            _homePath = cwd;
            CurrentDirectory = cwd;
        }

        protected string StartTimeFormatted
        {
            get { return FormatDateTime(_timeStart); }
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            // Convert dateTime to "YYYY.MM.DD.HH.MM.SS.UUU" format
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(dateTime.Year.ToString() + ".");
            stringBuilder.Append(dateTime.Month.ToString() + ".");
            stringBuilder.Append(dateTime.Day.ToString() + ".");
            stringBuilder.Append(dateTime.Hour.ToString() + ".");
            stringBuilder.Append(dateTime.Second.ToString() + ".");
            stringBuilder.Append(dateTime.Millisecond.ToString());
            return stringBuilder.ToString();
        }
    }
}
