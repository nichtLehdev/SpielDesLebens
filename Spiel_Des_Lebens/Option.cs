namespace Spiel_Des_Lebens
{
    internal class Option
    {
        private string title;
        private string text;
        private Stats optionStat;

        public Option(string title, string text, Stats optionStat)
        {
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }
    }
}
