// @author: Lars Lehmann

namespace SpielDesLebens
{
    internal class LoadEducationPath
    {
        public int path { get; set; }
        public int profession { get; set; }
        public int phase { get; set; }

        public LoadEducationPath(int path, int profession, int phase)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
        }
    }
}
