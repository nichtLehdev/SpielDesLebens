namespace SpielDesLebens
{
    internal class Option
    {
        public string Id;
        public string Title;
        public string Text;
        public Stat OptionStat;

        public Option(string id, string title, string text, Stat optionStat)
        {
            this.Id = id;
            this.Title = title;
            this.Text = text;
            this.OptionStat = optionStat;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public string GetText()
        {
            return this.Text;
        }

        public Stat GetStats()
        {
            return this.OptionStat;
        }


    }
}
