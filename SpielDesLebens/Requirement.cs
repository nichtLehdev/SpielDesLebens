using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Requirement
    {
        public List<Timing> timings;
        public Stat reqStatMin;
        public Stat reqStatMax;

        public Requirement(List<Timing> timings, Stat minStats, Stat maxStats)
        {
            this.timings = timings;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }
    }
}
