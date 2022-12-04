namespace Spiel_Des_Lebens
{
    internal class Player
    {
        private bool avatar;
        private int age;
        private string name;
        private Data.Graduation graduation;
        private Stat playerStat;
        public Eventgenerator eventgenerator;
        public ActionGenerator actiongenerator;
        private EducationPath eduPath;

        public Player(bool avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            this.graduation = graduation;
            playerStat = new Stat(70, 70, 70, 70);
            resetCareer(path, profession);
        }

        #region create_or_reset

        public void resetCareer(Data.Path path, Data.Profession profession)
        {
            createEducationPath(path, profession);
            createEventgenerator(eduPath);
            createActionGenerator();
        }

        private void createEducationPath(Data.Path path, Data.Profession profession)
        {
            eduPath = new EducationPath(path, profession);
        }

        private void createEventgenerator(EducationPath eduPath)
        {
            eventgenerator = new Eventgenerator(eduPath);
        }

        private void createActionGenerator()
        {
            actiongenerator = new ActionGenerator();
        }

        #endregion

        public void nextPhase() //muss bei jeder neuen Phase aufgerufen
        {
            eduPath.getPhase().nextPhase();
            increaseAge();
            //edit stats depending on Path
            changePlayerStat(Data.statarray[(int)eduPath.getPath()]);

        }

        public void setPlayerStat(Stat stats)
        {
            this.playerStat = stats;
        }

        public Stat getPlayerStat()
        {
            return this.playerStat;
        }

        public void changePlayerStat(Stat stats)
        {
            this.playerStat.change(stats);
        }

        public void setEducationPath(EducationPath eduPath)
        {
            this.eduPath = eduPath;
        }

        public EducationPath getEducationPath()
        {
            return this.eduPath;
        }

        public Data.Graduation getGraduation()
        {
            return this.graduation;
        }

        private void increaseAge()
        {
            if (eduPath.getPhase().getCurrentPhase() != 0)
            {
                if ((eduPath.getPhase().getCurrentPhase() * Data.phaseL[(int)eduPath.getPath()]) % 12 == 0)
                {
                    age++;
                }
            }
        }

        public Data.StatType? checkStatSmaller(int statValue)
        {
            foreach (StatParameter statParameter in this.playerStat.getStats())
            {
                if (statParameter.getValue() < statValue)
                {
                    return statParameter.getName();
                }
            }
            return null;
        }
    }
}
