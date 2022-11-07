using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class Option
    {
        private string title;
        private Stats optionStat;

        public Option(string title, Stats optionStat)
        {
            this.title = title;
            this.optionStat = optionStat;
        }
    }
}
