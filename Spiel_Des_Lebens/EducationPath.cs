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
        protected Profession profession;
        protected Phase phase;

        public enum Profession { Social = 1 , Business = 2, Science = 3, Stem = 4, Civil = 5 };

        public virtual void main(Profession profession)
        {
            setProfession(profession);
            phase = new Phase(phaseLength);
        }

        public void setProfession( Profession profession )
        {
            this.profession = profession;
        }

        public virtual String getProfession()
        {
            throw new Error("EducationPath.getProfession() failed !!!");
        }

        public Phase getPhase()
        {
            return phase;
        }
    }
}
