using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class StatsParameter
    {
        private string name;
        private int value; // string enum

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
        
        public string getName() {
                return name;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

    }
}
