using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMonit.Modules
{
    class DetectEnviroment
    {
        public static bool isHomeWork()
        {
            if (Properties.Settings.Default.DetectHomeOffice == "Define home office days")
                return isHomeWorkDay();
            return false;
        }
        private static bool isHomeWorkDay()
        {
            string day = "";
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    day = "Sunday";
                    break;
                case DayOfWeek.Monday:
                    day = "Monday";
                    break;
                case DayOfWeek.Tuesday:
                    day = "Tuesday";
                    break;
                case DayOfWeek.Wednesday:
                    day = "Wednesday";
                    break;
                case DayOfWeek.Thursday:
                    day = "Thursday";
                    break;
                case DayOfWeek.Friday:
                    day = "Friday";
                    break;
                case DayOfWeek.Saturday:
                    day = "Saturday";
                    break;
            }
            if(Properties.Settings.Default.HomeOfficeDays.Contains(day))
                return true;
            return false;
        }
    }
}
