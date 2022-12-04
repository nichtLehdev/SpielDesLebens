namespace Spiel_Des_Lebens
{
    internal class Player
    {
        private bool avatar;
        private int age;
        private string name;
        private Stat playerStat;
        public Eventgenerator eventgenerator;
        public ActionGenerator actiongenerator;
        private EducationPath eduPath;

        public Player(bool avatar, int age, string name, Data.Path path, Data.Profession profession)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stat(70, 70, 70, 70);
            resetCareer(path, profession);
        }

        public Player(bool avatar, int age, string name, Stat playerStat, Eventgenerator eventGen, EducationPath eduPath)
        {
            this.avatar = avatar;
            this.age = age;
            this.name = name;
            this.playerStat = playerStat;
            this.eventgenerator = eventGen;
            createActionGenerator();
            this.eduPath = eduPath;
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

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public bool getAvatar()
        {
            return this.avatar;
        }
    }
}
