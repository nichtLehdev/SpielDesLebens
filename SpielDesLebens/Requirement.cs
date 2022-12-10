// @author: Kevin Kern, Maximilian Koch

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Requirement
    {
        private readonly List<Timing> _timings;
        private readonly Stat _reqStatMin;
        private readonly Stat _reqStatMax;

        public Requirement(List<Timing> timings, Stat minStats, Stat maxStats)
        {
            _timings = timings;
            _reqStatMin = minStats;
            _reqStatMax = maxStats;
        }

        public List<Timing> GetTimings()
        {
            return _timings;
        }

        public Stat GetReqStatMin()
        {
            return _reqStatMin;
        }

        public Stat GetReqStatMax()
        {
            return _reqStatMax;
        }
    }
}
