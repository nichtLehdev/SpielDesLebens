using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Requirement
    {
        public List<Timing> Timings;
        public Stat ReqStatMin;
        public Stat ReqStatMax;

        public Requirement(List<Timing> timings, Stat minStats, Stat maxStats)
        {
            this.Timings = timings;
            ReqStatMin = minStats;
            ReqStatMax = maxStats;
        }
    }
}
