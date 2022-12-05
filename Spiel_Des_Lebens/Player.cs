namespace Spiel_Des_Lebens
{
    internal class Player
    {
        private readonly int avatar;
        private int age;
        private readonly string name;
        private readonly Data.Graduation graduation;
        private Stat playerStat;
        public Eventgenerator eventgenerator;
        public ActionGenerator actiongenerator;
        private EducationPath eduPath;

        public Player(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            this.graduation = graduation;
            playerStat = new Stat(70, 70, 70, 70);
            ResetCareer(path, profession);
        }

        public Player(int avatar, int age, string name, Stat playerStat, Eventgenerator eventGen, EducationPath eduPath)
        {
            this.avatar = avatar;
            this.age = age;
            this.name = name;
            this.playerStat = playerStat;
            this.eventgenerator = eventGen;
            CreateActionGenerator();
            this.eduPath = eduPath;
        }

        #region create_or_reset

        public void ResetCareer(Data.Path path, Data.Profession profession)
        {
            CreateEducationPath(path, profession);
            CreateEventgenerator(eduPath);
            CreateActionGenerator();
        }

        private void CreateEducationPath(Data.Path path, Data.Profession profession)
        {
            eduPath = new EducationPath(path, profession);
        }

        private void CreateEventgenerator(EducationPath eduPath)
        {
            eventgenerator = new Eventgenerator(eduPath);
        }

        private void CreateActionGenerator()
        {
            actiongenerator = new ActionGenerator();
        }

        #endregion
        public void NextPhase() //muss bei jeder neuen Phase aufgerufen
        {
            eduPath.GetPhase().NextPhase();
            IncreaseAge();
            //edit stats depending on Path
            ChangePlayerStat(Data.statarray[(int)eduPath.GetPath()]);

        }

        public void SetPlayerStat(Stat stats)
        {
            this.playerStat = stats;
        }

        public Stat GetPlayerStat()
        {
            return this.playerStat;
        }

        public void ChangePlayerStat(Stat stats)
        {
            this.playerStat.Change(stats);
        }

        public void SetEducationPath(EducationPath eduPath)
        {
            this.eduPath = eduPath;
        }

        public EducationPath GetEducationPath()
        {
            return this.eduPath;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public int GetAvatar()
        {
            return this.avatar;
        }
        public Data.Graduation GetGraduation()
        {
            return this.graduation;
        }

        private void IncreaseAge()
        {
            if (eduPath.GetPhase().GetCurrentPhase() != 0)
            {
                if ((eduPath.GetPhase().GetCurrentPhase() * Data.phaseL[(int)eduPath.GetPath()]) % 12 == 0)
                {
                    age++;
                }
            }
        }

        public Data.StatType? CheckStatSmaller(int statValue)
        {
            foreach (StatParameter statParameter in this.playerStat.GetStats())
            {
                if (statParameter.GetValue() < statValue)
                {
                    return statParameter.GetName();
                }
            }
            return null;
        }
    }
}
