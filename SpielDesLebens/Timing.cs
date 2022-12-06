using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Timing
    {
        public List<int> Path { get; set; }
        public List<int> Profession { get; set; }
        public List<int> Phase { get; set; }

        public Timing(List<int> path, List<int> profession, List<int> phase)
        {
            this.Path = path;
            this.Profession = profession;
            this.Phase = phase;
        }
    }
}
