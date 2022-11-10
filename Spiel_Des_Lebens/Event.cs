using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class Event
    {
        private string id; 
        private string title;
        private string text;
        private string info;
        private int priority;
        private Requirement requirements;
        private List<Option> options;

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
