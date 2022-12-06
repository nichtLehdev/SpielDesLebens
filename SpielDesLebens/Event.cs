using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Event
    {
        public string Id;
        public string Title;
        public string Text;
        public string Info;
        public int Priority;
        public Requirement Requirements;
        public List<Option> Options;

        public Event(string id, string title, string text, string info, int priority, Requirement req, List<Option> options)
        {
            this.Id = id;
            this.Title = title;
            this.Text = text;
            this.Info = info;
            this.Priority = priority;
            this.Requirements = req;
            this.Options = options;
        }

        public List<Option> GetOption()
        {
            return this.Options;
        }

        public void SetOption()
        {
            this.Options = new List<Option>();
        }
    }
}
