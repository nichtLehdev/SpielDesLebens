﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: bool is to clamped

namespace Spiel_Des_Lebens
{
    class Stats
    {
        public List<StatsParameter> stats;
        private List<string> endlessParameters = new List<string> { "money" };

        public Stats(int mentalHealth, int motivation, int money, int success)
        {
            stats = new List<StatsParameter>();
            stats.Add(new StatsParameter("mentalHealth", mentalHealth));
            stats.Add(new StatsParameter("motivation", motivation));
            stats.Add(new StatsParameter("money", money));
            stats.Add(new StatsParameter("success", success));
        }

        public void change(Stats stat)
        {
            foreach (StatsParameter statParam in stat.stats)
            {
                foreach (StatsParameter statParam2 in stats)
                {
                    if (statParam2.getName() == statParam.getName() )
                    {
                        statParam2.setValue() += statParam.getValue();
                        if(!endlessParameters.contains(statParam2.getName))
                            statParam2.clampBottomTop();
                        else
                            statParam2.clampBottom();
                    }
                }
            }
        }

    }
}
