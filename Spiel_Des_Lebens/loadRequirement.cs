﻿using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class loadRequirement
    {
        public List<Timing> timings { get; set; }
        public loadStat stats_min { get; set; }
        public loadStat stats_max { get; set; }
    }

}
