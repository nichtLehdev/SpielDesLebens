using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Path_Study : EducationPath
    {
        public override void main(Direction direction)
        {
            phaseLength = 3;
            base.main(direction);
        }

        public override string getProfession()
        {
            switch (direction)
            {
                case Direction.Social:
                    return "Medizinstudium";
                case Direction.Business:
                    return "BWL";
                case Direction.Science:
                    return "Physikstudium";
                case Direction.Stem:
                    return "Informatikstudium";
                case Direction.Civil:
                    return "Jurastudium";
            }
            return "ERROR, getProfession failed!";
        }
    }
}
