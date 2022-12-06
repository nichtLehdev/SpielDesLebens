using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Requirement
    {
        private readonly List<Timing> timings;
        private readonly Stat reqStatMin;
        private readonly Stat reqStatMax;

        public Requirement(List<Timing> timings, Stat minStats, Stat maxStats)
        {
            this.timings = timings;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }

        public List<Timing> GetTimings()
        {
            return this.timings;
        }

        public Stat GetReqStatMin()
        {
            return this.reqStatMin;
        }

        public Stat GetReqStatMax()
        {
            return this.reqStatMax;
        }
    }
}
