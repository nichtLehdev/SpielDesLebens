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
        public EducationPath eduPath;

        public enum Path {Training, StudyDual, Study};

        public Player(bool avatar, int age, string name, Path path)
        {
            this.age = age;
            this.avatar = avatar;
            this.name = name;
            playerStat = new Stats(70, 70, 70, 70);
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
                    throw new Error("no Path selected");
            }
        }

        public void setDirection( EducationPath.Direction direction)
        {
            eduPath.main(direction);
        }
    }
}
