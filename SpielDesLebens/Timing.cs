// @author: Lars Lehmann

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Timing
    {
        private readonly List<int> path;
        private readonly List<int> profession;
        private readonly List<int> phase;

        public List<int> GetPath()
        {
            return path;
        }

        public List<int> GetProfession()
        {
            return profession;
        }

        public List<int> GetPhase()
        {
            return phase;
        }

        public Timing(List<int> path, List<int> profession, List<int> phase)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
        }
    }
}
