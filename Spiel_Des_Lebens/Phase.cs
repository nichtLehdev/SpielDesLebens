using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Phase
    {
        private int actionPoints;
        public Phase(int length)
        {
            actionPoints = length * 7;
        }

        public int getActionPoints()
        {
            return actionPoints;
        }

        public void subtractPoints(int points)
        {
            actionPoints -= points;
        }
    }
}
