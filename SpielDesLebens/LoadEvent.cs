// @author: Maximilian Koch, Lars Lehmann
// Data class for a LoadEvent.

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

        public LoadEvent(string id, string title, string text, string info, int priority, LoadRequirement requirements, List<LoadOption> options)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.info = info;
            this.priority = priority;
            this.requirements = requirements;
            this.options = options;
        }
    }

}
