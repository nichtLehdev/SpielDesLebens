using System.Collections.Generic;


namespace Spiel_Des_Lebens
{
    class Stats
    {
        private List<StatsParameter> stats = new List<StatsParameter>();

        public Stats(int mentalHealth, int money, int motivation, int success)
        {
            stats.Add(new StatsParameter(StatsParameter.StatType.mentalHealth, mentalHealth, true, true));
            stats.Add(new StatsParameter(StatsParameter.StatType.money, money, true, true));
            stats.Add(new StatsParameter(StatsParameter.StatType.motivation, motivation, true, false));
            stats.Add(new StatsParameter(StatsParameter.StatType.success, success, true, true));
        }

        public void change(Stats stat)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                stats[i].setValue(stats[i].getValue() + stat.getStats()[i].getValue());
            }
        }

        public List<StatsParameter> getStats()
        {
            return stats;
        }

    }
}
