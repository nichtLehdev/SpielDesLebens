using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class Event
    {
        public string id; 
        public string title;
        public string text;
        public string info;
        public int priority;
        public Requirement requirements;
        public List<Option> options;

        public Event(string id, string title, string text, int priority, Requirement req, List<Option> options)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.priority = priority;
            this.requirements = req;
            this.options = options;
        }
    }
}
