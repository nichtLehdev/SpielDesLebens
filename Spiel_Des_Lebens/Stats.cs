using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    class Stats
    {
        public int mentalHealth, motivation, money, success;

        public Stats(int mentalHealth, int motivation, int money, int success)
        {
            this.mentalHealth = mentalHealth;
            this.motivation = motivation;
            this.money = money;
            this.success = success;
        }

        public void change(Stats stat)
        {
            this.mentalHealth += stat.mentalHealth;
            this.motivation += stat.motivation;
            this.money += stat.money;
            this.success += stat.success;
            clamp();
        }

        // ensures value is between 0 and 100
        private void clamp()
        {
            if(mentalHealth < 0) {mentalHealth = 0;}
            if(motivation < 0) { motivation = 0; }
            if(money < 0) { money = 0; }
            if(success < 0) { success = 0; }

            if (mentalHealth > 100) { mentalHealth = 100; }
            if (motivation > 100) { motivation = 100; }
            if (money > 100) { money = 100; }
            if (success > 100) { success = 100; }
        }
    }
}
