// @author: Maximilian Koch, Lars Lehmann

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadTiming
    {
        public List<string> path { get; set; }
        public List<string> profession { get; set; }
        public List<string> phase { get; set; }

        public LoadTiming(List<string> path, List<string> profession, List<string> phase)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
        }
    }
}
