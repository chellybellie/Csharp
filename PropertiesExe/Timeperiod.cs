using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExe
{
    public struct TimePeriod
    {
        public double Seconds { get; set; }
        public double Hours
        {
            get { return Seconds / 3600; }
            set { Seconds = value * 3600; }
        }
    }
}