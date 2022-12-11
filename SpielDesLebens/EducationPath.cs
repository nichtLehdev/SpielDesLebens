// @author: Kevin Kern, Maximilian Koch
// Data class for an education path. An education path consists of a path and a profession. It also holds a phase object and stores the corresponding length.

namespace SpielDesLebens
{
    internal class EducationPath
    {
        private readonly int _phaseLength;
        private Data.Path _path;
        private Data.Profession _profession;
        private readonly Phase _phase;

        public EducationPath(Data.Path path, Data.Profession profession)
        {
            SetPath(path);
            SetProfession(profession);
            _phaseLength = Data.SPhaseL[(int)path];
            _phase = new Phase(_phaseLength);
        }

        public EducationPath(Data.Path path, Data.Profession profession, int currentPhase, int actionPoints)
        {
            SetPath(path);
            SetProfession(profession);
            _phaseLength = Data.SPhaseL[(int)path];
            _phase = new Phase(currentPhase, actionPoints, _phaseLength);
        }

        private void SetPath(Data.Path path)
        {
            _path = path;
        }

        private void SetProfession(Data.Profession profession)
        {
            _profession = profession;
        }

        public string GetProfessionName()
        {
            return Data.SCareer[(int)_path, (int)_profession];
        }

        public Data.Profession GetProfession()
        {
            return _profession;
        }

        public Data.Path GetPath()
        {
            return _path;
        }

        public int GetPhaseLength()
        {
            return _phaseLength;
        }

        public Phase GetPhase()
        {
            return _phase;
        }
    }
}
