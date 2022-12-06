using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadRequirement
    {
        public List<LoadTiming> timings { get; set; }
        public LoadStat statsMin { get; set; }
        public LoadStat statsMax { get; set; }
    }

}
