using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prep1.Types
{
    public class Interval
    {
        public int Distance;
        public int AvgHeartRate;
        public TimeSpan TotalTime;

        public string GetAvergeSplit()
        {
            return "Average Split";
        }
    }    
}
