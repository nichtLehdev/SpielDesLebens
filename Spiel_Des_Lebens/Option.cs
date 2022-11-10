namespace Spiel_Des_Lebens
{
    internal class Option
    {
        private string title;
        private string text;
        private Stat optionStat;

        public Option(string title, string text, Stat optionStat)
        {
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }
    }
}
