using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Spiel_Des_Lebens
{
    public class Player
    {
        private Image avatar;
        private int age;
        private string name;
        private Stats playerStat;

        public Player(Image avatar, int age, string name)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stats(70, 70, 70, 70);
        }
    }
}
