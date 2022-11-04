using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Player
    {
        private bool avatar;
        private int age;
        private string name;
        private Stats playerStat;

        public Player(bool avatar, int age, string name)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stats(70, 70, 70, 70);
        }
    }
}
