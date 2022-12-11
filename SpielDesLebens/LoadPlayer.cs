// @author: Lars Lehmann
// Data class for a LoadPlayer.

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadPlayer
    {
        public string name { get; set; }
        public int age { get; set; }
        public int avatar { get; set; }
        public int graduation { get; set; }
        public LoadStat stats { get; set; }
        public List<LoadEvent> eventGenList { get; set; }
        public LoadEducationPath eduPath { get; set; }

        public LoadPlayer(string name, int age, int avatar, int graduation, LoadStat stats, List<LoadEvent> eventGenList, LoadEducationPath eduPath)
        {
            this.name = name;
            this.age = age;
            this.avatar = avatar;
            this.graduation = graduation;
            this.stats = stats;
            this.eventGenList = eventGenList;
            this.eduPath = eduPath;
        }
    }
}
