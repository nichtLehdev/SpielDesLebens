// @author: Joel Dag, Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal class Player
    {
        private readonly int _avatar;
        private int _age;
        private readonly string _name;
        private readonly Data.Graduation _graduation;
        private Stat _playerStat;
        private EventGenerator _eventGenerator;
        private ActionGenerator _actionGenerator;
        private EducationPath _eduPath;

        public Player(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            _age = age;
            _avatar = avatar;
            _name = name;
            _graduation = graduation;
            _playerStat = new Stat(70, 70, 70, 70);
            ResetCareer(path, profession);
        }

        public Player(int avatar, int age, int graduation, string name, Stat playerStat, EventGenerator eventGen, EducationPath eduPath)
        {
            _avatar = avatar;
            _age = age;
            _name = name;
            _graduation = (Data.Graduation)graduation;
            _playerStat = playerStat;
            _eventGenerator = eventGen;
            CreateActionGenerator();
            _eduPath = eduPath;
        }

        #region createOrReset

        public void ResetCareer(Data.Path path, Data.Profession profession)
        {
            CreateEducationPath(path, profession);
            CreateEventgenerator(_eduPath);
            CreateActionGenerator();
        }

        private void CreateEducationPath(Data.Path path, Data.Profession profession)
        {
            _eduPath = new EducationPath(path, profession);
        }

        private void CreateEventgenerator(EducationPath eduPath)
        {
            _eventGenerator = new EventGenerator(eduPath);
        }

        private void CreateActionGenerator()
        {
            _actionGenerator = new ActionGenerator();
        }

        #endregion
        // Have to be called for every new phase.
        public void NextPhase()
        {
            _eduPath.GetPhase().NextPhase();
            IncreaseAge();
            // Edit stats depending on path.
            ChangePlayerStat(Data.SStatArray[(int)_eduPath.GetPath()]);

        }

        public void SetPlayerStat(Stat stats)
        {
            _playerStat = stats;
        }

        public Stat GetPlayerStat()
        {
            return _playerStat;
        }

        public void ChangePlayerStat(Stat stats)
        {
            _playerStat.Change(stats);
        }

        public void SetEducationPath(EducationPath eduPath)
        {
            _eduPath = eduPath;
        }

        public EducationPath GetEducationPath()
        {
            return _eduPath;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public int GetAvatar()
        {
            return _avatar;
        }
        public Data.Graduation GetGraduation()
        {
            return _graduation;
        }

        private void IncreaseAge()
        {
            if (_eduPath.GetPhase().GetCurrentPhase() != 0)
            {
                if ((_eduPath.GetPhase().GetCurrentPhase() * Data.SPhaseL[(int)_eduPath.GetPath()]) % 12 == 0)
                {
                    _age++;
                }
            }
        }

        public Data.StatType? CheckStatSmaller(int statValue)
        {
            foreach (StatParameter statParameter in _playerStat.GetStats())
            {
                if (statParameter.GetValue() < statValue)
                {
                    return statParameter.GetName();
                }
            }
            return null;
        }

        public EventGenerator GetEventgenerator()
        {
            return _eventGenerator;
        }

        public ActionGenerator GetActionGenerator()
        {
            return _actionGenerator;
        }
    }
}
