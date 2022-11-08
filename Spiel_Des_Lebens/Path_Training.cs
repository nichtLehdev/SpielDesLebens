namespace Spiel_Des_Lebens
{
    internal class Path_Training : EducationPath
    {
        public override void main(Profession profession)
        {
            phaseLength = 2;
            base.main(profession);
        }

        public override string getProfession()
        {
            switch (profession)
            {
                case Profession.Social:
                    return "Krankenpflege";
                case Profession.Business:
                    return "Industriekaufmann";
                case Profession.Science:
                    return "Pharmazeutisch Technische Assistenz";
                case Profession.Stem:
                    return "Fachinformatiker";
                case Profession.Civil:
                    return "Rechtanwaltsfachangestellter";
            }
            throw new Error("Path_Training.getProfession() failed !!!");
        }
    }
}
