using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public enum Path {Training, StudyDual, Study};

        public Player(bool avatar, int age, string name, Path path, EducationPath.Profession profession)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stats(70, 70, 70, 70);
            createPath(path);
            setProfession(profession);
            createEventgenerator(path, profession);
        }

        #region create_or_reset

        // TODO void that calls all of the following 3
        public void createPath(Path path)
        {
            switch (path)
            {
                case Path.Training:
                    eduPath = new Path_Training();
                    break;
                case Path.StudyDual:
                    eduPath = new Path_DualStudy();
                    break;
                case Path.Study:
                    eduPath = new Path_Study();
                    break;
                default:
                    throw new Error("Player.createPath() failed !!!");
            }
        }

        public void setProfession(EducationPath.Profession profession)
        {
            eduPath.main(profession);
        }

        public void createEventgenerator(Path path, EducationPath.Profession profession)
        {
            eventgenerator = new Eventgenerator(path, profession);
        }

        #endregion
    }
}
