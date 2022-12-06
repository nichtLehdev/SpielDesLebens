using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Event
    {
        private readonly string id;
        private readonly string title;
        private readonly string text;
        private readonly string info;
        private int priority;
        private readonly Requirement requirements;
        private List<Option> options;

        public Event(string id, string title, string text, string info, int priority, Requirement req, List<Option> options)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.info = info;
            this.priority = priority;
            this.requirements = req;
            this.options = options;
        }


        public string GetId() { return id; }
        public string GetTitle() { return title; }
        public string GetText() { return text; }
        public string GetInfo() { return info; }
        public int GetPriority() { return priority; }
        public Requirement GetRequirements() { return requirements; }
        public List<Option> GetOptions() { return this.options; }

        public void SetPriority(int priority)
        {
            this.priority = priority;
        }

        public void SetOption()
        {
            this.options = new List<Option>();
        }



    }
}
