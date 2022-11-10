using System.Collections.Generic;


namespace Spiel_Des_Lebens
{
    internal class Stat
    {
        private List<StatParameter> stats = new List<StatParameter>();

        public Stat(int mentalHealth, int money, int motivation, int success)
        {
            stats.Add(new StatParameter(StatParameter.StatType.mentalHealth, mentalHealth, true, true));
            stats.Add(new StatParameter(StatParameter.StatType.money, money, true, true));
            stats.Add(new StatParameter(StatParameter.StatType.motivation, motivation, true, false));
            stats.Add(new StatParameter(StatParameter.StatType.success, success, true, true));
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

    }
}
