﻿namespace Spiel_Des_Lebens
{
    internal class Option
    {
        private string id;
        private string title;
        private string text;
        private Stat optionStat;

        public Option(string id, string title, string text, Stat optionStat)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.optionStat = optionStat;
        }
    }
}