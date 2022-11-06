using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Path_DualStudy : EducationPath
    {

        public override void main(Profession profession)
        {
            phaseLength = 3;
            base.main(profession);
        }

        public override string getProfession()
        {
            switch(profession)
            {
                case Profession.Social:
                    return "Angewandte Gesundheits- und Pflegewissenschaften";
                case Profession.Business:
                    return "BWL";
                case Profession.Science:
                    return "Angewandte Physik";
                case Profession.Stem:
                    return "Angewandtes Informatikstudium";
                case Profession.Civil:
                    return "Steuerwesen";
            }
            throw new Error("Path_DualStudy.getProfession() failed !!!");
        }
    }
}
