using System;
using System.Collections.Generic;
using System.Text;

namespace TradingApp.ProgramUtilities
{
    public static class DateTimeUtilities
    {
        // Utitlies for Dealing w/ DateTime Objects

        public static string FormatDateTime(DateTime dateTime)
        {
            // Convert dateTime to "YYYY.MM.DD.HH.MM.SS.UUU" format
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(dateTime.Year.ToString()+".");
            stringBuilder.Append(dateTime.Month.ToString()+".");
            stringBuilder.Append(dateTime.Day.ToString()+".");
            stringBuilder.Append(dateTime.Hour.ToString()+".");
            stringBuilder.Append(dateTime.Second.ToString()+".");
            stringBuilder.Append(dateTime.Millisecond.ToString());
            return stringBuilder.ToString();
        }
    }
}
