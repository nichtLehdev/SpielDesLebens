using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class Timing
    {
        public List<int> path { get; set; }
        public List<int> profession { get; set; }
        public List<int> phase { get; set; }

        public Timing(List<int> path, List<int> profession, List<int> phase)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
        }
    }
}
