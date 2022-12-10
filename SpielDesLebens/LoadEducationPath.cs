// @author: Lars Lehmann

namespace SpielDesLebens
{
    internal class LoadEducationPath
    {
        public int path { get; set; }
        public int profession { get; set; }
        public int phase { get; set; }

        public int actionPoints { get; set; }

        public LoadEducationPath(int path, int profession, int phase, int actionPoints)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
            this.actionPoints = actionPoints;
        }
    }
}
