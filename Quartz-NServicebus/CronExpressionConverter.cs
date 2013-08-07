using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Quartz_NServicebus
{
    public class CronExpressionConverter
    {
        //TODO: we could pass in string of already converted days or IEnumerable<DayOfWeek> and use the function below to get to the desired format
        public static string ConvertToCronExpression(string dayofWeek, int hour, int minutes)
        {
            const int seconds = 0;
            const string dayOfMonth = "?";
            const string month = "*";
            return string.Format("{0} {1} {2} {3} {4} {5}", seconds, minutes, hour, dayOfMonth, month, dayofWeek.ToUpper());
        }

        public static string AbbreviatedNames(IEnumerable<DayOfWeek> days)
        {
            var english = new CultureInfo("en-US");
            return string.Join(",", days.Select(day => english.DateTimeFormat.AbbreviatedDayNames[(int)day])); 
        }
    }
}