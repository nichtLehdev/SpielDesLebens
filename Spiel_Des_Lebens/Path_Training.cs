using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Path_Training : EducationPath
    {
        public override void main(Direction direction)
        {
            phaseLength = 2;
            base.main(direction);
        }

        public override string getProfession()
        {
            switch (direction)
            {
                case Direction.Social:
                    return "Krankenpflege";
                case Direction.Business:
                    return "Industriekaufmann";
                case Direction.Science:
                    return "Pharmazeutisch Technische Assistenz";
                case Direction.Stem:
                    return "Fachinformatiker";
                case Direction.Civil:
                    return "Rechtanwaltsfachangestellter";
            }
            return "ERROR - Path_Training.getProfession() failed !!!";
        }
    }
}
