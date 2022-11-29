using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Converter
    {
        public static Option convertLoadOptionToOption(loadOption lOption)
        {
            return new Option(lOption.id, lOption.title, lOption.text, convertLoadStatToStat(lOption.stats));
        }

        public static Stat convertLoadStatToStat(loadStat lStat)
        {
            return new Stat(lStat.mentalHealth, lStat.money, lStat.motivation, lStat.success);
        }
    }
}
