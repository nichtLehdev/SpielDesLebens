using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class StatsParameter
    {
        private string name { public get; };
        private int value { public get; public set; };

        public StatsParameter(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
        
        public void clampBottomTop() {
            if (value < 0) { value = 0; }
            if (value > 100) { value = 100; }
        }

        public void clampBottom() {
            if (value < 0) { value = 0; }
        }
    }
}
