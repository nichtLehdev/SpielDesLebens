using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class loadRequirement
    {
        public int[] path { get; set; }
        public int[] profession { get; set; }
        public int[] phase { get; set; }
        public loadStat stats_min { get; set; }
        public loadStat stats_max { get; set; }
    }
    
}
