// @author: Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal class Option
    {
        private readonly string _id;
        private readonly string _title;
        private readonly string _text;
        private readonly Stat _optionStat;

        public Option(string id, string title, string text, Stat optionStat)
        {
            _id = id;
            _title = title;
            _text = text;
            _optionStat = optionStat;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetText()
        {
            return _text;
        }

        public Stat GetOptionStat()
        {
            return _optionStat;
        }


    }
}
