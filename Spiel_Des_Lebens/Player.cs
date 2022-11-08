namespace Spiel_Des_Lebens
{
    internal class Player
    {
        private bool avatar;
        private int age;
        private string name;
        private Stats playerStat;
        private Eventgenerator eventgenerator;
        public EducationPath eduPath;

        public Player(bool avatar, int age, string name, EducationPath.Path path, EducationPath.Profession profession)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stats(70, 70, 70, 70);
            resetCarreer(path, profession);
        }

        #region create_or_reset

        public void resetCarreer(EducationPath.Path path, EducationPath.Profession profession)
        {
            createEducationPath(path, profession);
            createEventgenerator(path, profession);
        }

        private void createEducationPath(EducationPath.Path path, EducationPath.Profession profession)
        {
            eduPath = new EducationPath(path, profession);
        }

        private void createEventgenerator(EducationPath.Path path, EducationPath.Profession profession)
        {
            eventgenerator = new Eventgenerator(path, profession);
        }

        #endregion
    }
}
