namespace Spiel_Des_Lebens
{
    internal class EducationPath
    {
        private int phaseLength;
        private Data.Path path;
        private Data.Profession profession;
        private Phase phase;

        public EducationPath(Data.Path path, Data.Profession profession)
        {
            setPath(path);
            setProfession(profession);
            phaseLength = Data.phaseL[(int)path];
            phase = new Phase(phaseLength);
        }

        public EducationPath(Data.Path path, Data.Profession profession, int currentPhase)
        {
            setPath(path);
            setProfession(profession);
            phaseLength = Data.phaseL[(int)path];
            phase = new Phase(phaseLength, currentPhase);
        }

        private void setPath(Data.Path path)
        {
            this.path = path;
        }

        private void setProfession(Data.Profession profession)
        {
            this.profession = profession;
        }

        public string getProfessionName()
        {
            return Data.career[(int)path, (int)profession];
        }

        public Data.Profession getProfession()
        {
            return profession;
        }

        public Data.Path getPath()
        {
            return this.path;
        }

        public int getPhaseLength()
        {
            return phaseLength;
        }

        public Phase getPhase()
        {
            return phase;
        }
    }
}
