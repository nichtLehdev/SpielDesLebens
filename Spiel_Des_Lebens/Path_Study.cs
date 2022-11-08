namespace Spiel_Des_Lebens
{
    internal class Path_Study : EducationPath
    {
        public override void main(Profession profession)
        {
            phaseLength = 3;
            base.main(profession);
        }

        public override string getProfession()
        {
            switch (profession)
            {
                case Profession.Social:
                    return "Medizinstudium";
                case Profession.Business:
                    return "BWL";
                case Profession.Science:
                    return "Physikstudium";
                case Profession.Stem:
                    return "Informatikstudium";
                case Profession.Civil:
                    return "Jurastudium";
            }
            throw new Error("Path_Study.getProfession() failed !!!");
        }
    }
}
