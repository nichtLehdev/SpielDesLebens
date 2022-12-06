namespace SpielDesLebens
{
    internal class Option
    {
        private readonly string id;
        private readonly string title;
        private readonly string text;
        private readonly Stat optionStat;

        public Option(string id, string title, string text, Stat optionStat)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }

        public string GetId()
        {
            return id;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetText()
        {
            return this.text;
        }

        public Stat GetOptionStat()
        {
            return this.optionStat;
        }


    }
}
