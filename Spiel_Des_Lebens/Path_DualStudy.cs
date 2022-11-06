using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Path_DualStudy : EducationPath
    {

        public override void main(Direction direction)
        {
            phaseLength = 3;
            base.main(direction);
        }

        public override string getProfession()
        {
            switch(direction)
            {
                case Direction.Social:
                    return "Angewandte Gesundheits- und Pflegewissenschaften";
                case Direction.Business:
                    return "BWL";
                case Direction.Science:
                    return "Angewandte Physik";
                case Direction.Stem:
                    return "Angewandtes Informatikstudium";
                case Direction.Civil:
                    return "Steuerwesen";
            }
            throw new Error("Path_DualStudy.getProfession() failed !!!");
        }
    }
}
