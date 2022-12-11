// @author: Kevin Kern, Maximilian Koch
// Data class for an event. An event is an object that is displayed to the player. It has an id, a title, a text, an info text, a priority, a requirement and a list of options.

using System.Collections.Generic;
namespace SpielDesLebens
{
    internal class Event
    {
        private readonly string _id;
        private readonly string _title;
        private readonly string _text;
        private readonly string _info;
        private int _priority;
        private readonly Requirement _requirements;
        private List<Option> _options;

        public Event(string id, string title, string text, string info, int priority, Requirement req, List<Option> options)
        {
            _id = id;
            _title = title;
            _text = text;
            _info = info;
            _priority = priority;
            _requirements = req;
            _options = options;
        }


        public string GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetText() { return _text; }
        public string GetInfo() { return _info; }
        public int GetPriority() { return _priority; }
        public Requirement GetRequirements() { return _requirements; }
        public List<Option> GetOptions() { return _options; }

        public void SetPriority(int priority)
        {
            _priority = priority;
        }

        public void SetOption()
        {
            _options = new List<Option>();
        }



    }
}
