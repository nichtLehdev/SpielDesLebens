namespace Spiel_Des_Lebens
{
    internal class Option
    {
        public string id;
        public string title;
        public string text;
        public Stat optionStat;

        public Option(string id, string title, string text, Stat optionStat)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }
    }
}
