using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class LoadEvent
    {
        public string id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string info { get; set; }
        public int priority { get; set; }
        public LoadRequirement requirements { get; set; }
        public List<LoadOption> options { get; set; }
    }

}
