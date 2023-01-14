using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifire
{
    public static class DateModifire
    {
        public static int DateDifrenceBetwinDates(string dateOne, string dateTwo)
        {
            DateTime first = DateTime.Parse(dateOne);
            DateTime second = DateTime.Parse(dateTwo);
            TimeSpan difference = first - second;
            return Math.Abs(difference.Days);
        }
    }
}
