using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class EducationPath
    {
        public int phaseLength;
        protected Direction direction;
        protected Phase phase;

        public enum Direction { Social = 1 , Business = 2, Science = 3, Stem = 4, Civil = 5 };

        public virtual void main(Direction direction)
        {
            setDirection(direction);
            phase = new Phase(phaseLength);
        }

        public void setDirection( Direction direction )
        {
            this.direction = direction;
        }

        public virtual String getProfession()
        {
            return "";
        }

        public Phase getPhase()
        {
            return phase;
        }
    }
}
