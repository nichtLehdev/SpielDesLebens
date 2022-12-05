using System.Collections.Generic;


namespace Spiel_Des_Lebens
{
    internal class Stat
    {
        private readonly List<StatParameter> stats = new List<StatParameter>();

        public Stat(int mentalHealth, int money, int motivation, int success)
        {
            stats.Add(new StatParameter(Data.StatType.mentalHealth, mentalHealth, true, true));
            stats.Add(new StatParameter(Data.StatType.money, money, true, false));
            stats.Add(new StatParameter(Data.StatType.motivation, motivation, true, true));
            stats.Add(new StatParameter(Data.StatType.success, success, true, true));
        }

        public void Change(Stat stat)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                stats[i].SetValue(stats[i].GetValue() + stat.GetStats()[i].GetValue());
                stats[i].ClampBottom();
                stats[i].ClampTop();
            }
        }

        public List<StatParameter> GetStats()
        {
            return stats;
        }

        public bool IsGreater(Stat stats1)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                if (!stats[i].IsGreater(stats1.stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSmaller(Stat stats1)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                if (!stats[i].IsSmaller(stats1.stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
