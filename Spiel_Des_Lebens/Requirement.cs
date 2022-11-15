using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class Requirement
    {
        //public int[,,] timings;
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
