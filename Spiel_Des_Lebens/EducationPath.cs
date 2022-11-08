using System;

namespace Spiel_Des_Lebens
{
    internal class EducationPath
    {
        private int phaseLength;
        private Path path;
        private Profession profession;
        private Phase phase;

        private String[,] career = new string[3,5];
        private int[] phaseL = new int[3];

        public enum Path { Training = 0, DualStudy = 1, Study = 2 };
        public enum Profession { Social = 0 , Business = 1, Science = 2, Stem = 3, Civil = 4 };

        public EducationPath(Path path, Profession profession)
        {
            setProfession(profession);
            phase = new Phase(phaseLength);
            setPath(path);

            phaseL[0] = 2;
            phaseL[1] = 3;
            phaseL[2] = 3;

            phaseLength = phaseL[(int)path];

            career[0, 0] = "Krankenpflege";
            career[0, 1] = "Industriekaufmann";
            career[0, 2] = "Pharmazeutisch Technische Assistenz";
            career[0, 3] = "Fachinformatiker";
            career[0, 4] = "Rechtanwaltsfachangestellter";
            career[1, 0] = "Angewandte Gesundheits- und Pflegewissenschaften";
            career[1, 1] = "BWL";
            career[1, 2] = "Angewandte Physik";
            career[1, 3] = "Angewandtes Informatikstudium";
            career[1, 4] = "Steuerwesen";
            career[2, 0] = "Medizinstudium";
            career[2, 1] = "BWL";
            career[2, 2] = "Physikstudium";
            career[2, 3] = "Informatikstudium";
            career[2, 4] = "Jurastudium";
        }

        private void setPath(Path path)
        {
            this.path = path;
        }

        private void setProfession( Profession profession )
        {
            this.profession = profession;
        }

        public String getProfession()
        {
            return career[(int)path,(int)profession];
        }

        public Phase getPhase()
        {
            return phase;
        }
    }
}
