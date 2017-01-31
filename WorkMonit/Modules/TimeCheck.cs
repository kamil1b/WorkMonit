using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMonit.Modules
{
    class TimeCheck
    {
        static public int CheckOfficeTime()
        {
            TimeSpan timeBegin = Properties.Settings.Default.TimeWorkBegin - Properties.Settings.Default.TimeWorkBegin.Date;
            TimeSpan timeEnd = Properties.Settings.Default.TimeWorkEnd - Properties.Settings.Default.TimeWorkEnd.Date;

            TimeSpan actualTime = DateTime.Now - DateTime.Today;

            if (actualTime < timeBegin)
                return 1;
            if (actualTime > timeEnd)
                return 2;

            return 0;
        }

        static public int CheckHomeOfficeTime()
        {
            TimeSpan timeBegin = Properties.Settings.Default.HOWorkBegin - Properties.Settings.Default.HOWorkBegin.Date;
            TimeSpan timeEnd = Properties.Settings.Default.HOWorkEnd - Properties.Settings.Default.HOWorkEnd.Date;

            TimeSpan actualTime = DateTime.Now - DateTime.Today;

            if (actualTime < timeBegin)
                return 1;
            if (actualTime > timeEnd)
                return 2;

            return 0;
        }
    }
}
