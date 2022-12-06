using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadPlayer
    {
        public string name { get; set; }
        public int age { get; set; }
        public int avatar { get; set; }
        public LoadStat stats { get; set; }
        public List<LoadEvent> eventGenList { get; set; }
        public LoadEducationPath eduPath { get; set; }
    }
}
