using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class Event
    {
        private string title;
        private string text;
        private string info;
        private Requirement requirements;
        private List<Option> options;

        public Event(string title, string text, Requirement req, List<Option> options)
        {
            this.title = title;
            this.text = text;
            this.requirements = req;
            this.options = options;
        }
    }
}
