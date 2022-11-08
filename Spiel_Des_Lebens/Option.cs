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
        private string text;
        private Stats optionStat;

        public Option(string title, string text, Stats optionStat)
        {
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }
    }
}
