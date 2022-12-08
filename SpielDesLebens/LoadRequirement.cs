// @author: Maximilian Koch, Lars Lehmann

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadRequirement
    {
        public List<LoadTiming> timings { get; set; }
        public LoadStat statsMin { get; set; }
        public LoadStat statsMax { get; set; }
    
        public LoadRequirement(List<LoadTiming> timings, LoadStat statsMin, LoadStat statsMax)
        {
            this.timings = timings;
            this.statsMin = statsMin;
            this.statsMax = statsMax;
        }
    }

}
