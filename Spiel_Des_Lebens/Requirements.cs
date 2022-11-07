using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class Requirements
    {
        private int[] path;
        private int[] profession;
        private int[] phase;
        private Stats reqStatMin;
        private Stats reqStatMax;

        public Requirements(int[] path, int[] profession, int[] phase, Stats minStats, Stats maxStats)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }
    }
}
