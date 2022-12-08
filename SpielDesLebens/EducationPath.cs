// @author: Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal class EducationPath
    {
        private readonly int phaseLength;
        private Data.SPath path;
        private Data.SProfession profession;
        private readonly Phase phase;

        public EducationPath(Data.SPath path, Data.SProfession profession)
        {
            SetPath(path);
            SetProfession(profession);
            phaseLength = Data.SPhaseL[(int)path];
            phase = new Phase(phaseLength);
        }

        public EducationPath(Data.SPath path, Data.SProfession profession, int currentPhase)
        {
            SetPath(path);
            SetProfession(profession);
            phaseLength = Data.SPhaseL[(int)path];
            phase = new Phase(phaseLength, currentPhase);
        }

        private void SetPath(Data.SPath path)
        {
            this.path = path;
        }

        private void SetProfession(Data.SProfession profession)
        {
            this.profession = profession;
        }

        public string GetProfessionName()
        {
            return Data.SCareer[(int)path, (int)profession];
        }

        public Data.SProfession GetProfession()
        {
            return profession;
        }

        public Data.SPath GetPath()
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
