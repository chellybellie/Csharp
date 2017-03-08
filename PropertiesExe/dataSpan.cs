using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExe
{
    public struct DatePeriod
    {
        public void AddDays(int addedDays)
        {
            Days += addedDays;
        }
        public void AddWeeks(int addedWeeks)
        {
            Days += addedWeeks * 7;
        }
        public void AddYears(int addedYears)
        {
            Days += addedYears * 365;
        }

        public int Days { private set; get; }
        public int Weeks
        {
            get
            {
                return Days / 7;
            }
        }
        public int Years
        {
            get
            {
                return Days / 365;
            }
        }
    }
}