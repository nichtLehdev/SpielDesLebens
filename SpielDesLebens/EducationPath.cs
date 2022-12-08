// @author: Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal class EducationPath
    {
        private readonly int phaseLength;
        private Data.Path path;
        private Data.Profession profession;
        private readonly Phase phase;

        public EducationPath(Data.Path path, Data.Profession profession)
        {
            SetPath(path);
            SetProfession(profession);
            phaseLength = Data.SPhaseL[(int)path];
            phase = new Phase(phaseLength);
        }

        public EducationPath(Data.Path path, Data.Profession profession, int currentPhase)
        {
            SetPath(path);
            SetProfession(profession);
            phaseLength = Data.SPhaseL[(int)path];
            phase = new Phase(phaseLength, currentPhase);
        }

        private void SetPath(Data.Path path)
        {
            this.path = path;
        }

        private void SetProfession(Data.Profession profession)
        {
            this.profession = profession;
        }

        public string GetProfessionName()
        {
            return Data.SCareer[(int)path, (int)profession];
        }

        public Data.Profession GetProfession()
        {
            return profession;
        }

        public Data.Path GetPath()
        {
            return this.path;
        }

        public int GetPhaseLength()
        {
            return phaseLength;
        }

        public Phase GetPhase()
        {
            return phase;
        }
    }
}
