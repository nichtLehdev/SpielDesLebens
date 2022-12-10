// @author: Kevin Kern, Maximilian Koch

using System.Collections.Generic;


namespace SpielDesLebens
{
    internal class Stat
    {
        private readonly List<StatParameter> _stats = new List<StatParameter>();

        public Stat(int mentalHealth, int money, int motivation, int success)
        {
            _stats.Add(new StatParameter(Data.StatType.mentalHealth, mentalHealth, true, true));
            _stats.Add(new StatParameter(Data.StatType.money, money, true, false));
            _stats.Add(new StatParameter(Data.StatType.motivation, motivation, true, true));
            _stats.Add(new StatParameter(Data.StatType.success, success, true, true));
        }

        public void Change(Stat stat)
        {
            for (int i = 0; i < _stats.Count; i++)
            {
                _stats[i].SetValue(_stats[i].GetValue() + stat.GetStats()[i].GetValue());
                _stats[i].ClampBottom();
                _stats[i].ClampTop();
            }
        }

        public List<StatParameter> GetStats()
        {
            return _stats;
        }

        public bool IsGreater(Stat statsToCompare)
        {
            for (int i = 0; i < _stats.Count; i++)
            {
                if (!_stats[i].IsGreater(statsToCompare._stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSmaller(Stat statsToCompare)
        {
            for (int i = 0; i < _stats.Count; i++)
            {
                if (!_stats[i].IsSmaller(statsToCompare._stats[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
