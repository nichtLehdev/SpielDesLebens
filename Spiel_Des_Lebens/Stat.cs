using System.Collections.Generic;


namespace Spiel_Des_Lebens
{
    internal class Stat
    {
        private List<StatParameter> stats = new List<StatParameter>();

        public Stat(int mentalHealth, int money, int motivation, int success)
        {
            stats.Add(new StatParameter(Data.StatType.mentalHealth, mentalHealth, true, true));
            stats.Add(new StatParameter(Data.StatType.money, money, true, false));
            stats.Add(new StatParameter(Data.StatType.motivation, motivation, true, true));
            stats.Add(new StatParameter(Data.StatType.success, success, true, true));
        }

        public void change(Stat stat)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                stats[i].setValue(stats[i].getValue() + stat.getStats()[i].getValue());
                stats[i].clampBottom();
                stats[i].clampTop();
            }
        }

        public List<StatParameter> getStats()
        {
            return stats;
        }

        public bool isGreater(Stat stats1)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                if (!stats[i].isGreater(stats1.stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isSmaller(Stat stats1)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                if (!stats[i].isSmaller(stats1.stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
