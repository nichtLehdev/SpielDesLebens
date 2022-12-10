// @author: Lars Lehmann

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Timing
    {
        private readonly List<int> _path;
        private readonly List<int> _profession;
        private readonly List<int> _phase;

        public List<int> GetPath()
        {
            return _path;
        }

        public List<int> GetProfession()
        {
            return _profession;
        }

        public List<int> GetPhase()
        {
            return _phase;
        }

        public Timing(List<int> path, List<int> profession, List<int> phase)
        {
            _path = path;
            _profession = profession;
            _phase = phase;
        }
    }
}
