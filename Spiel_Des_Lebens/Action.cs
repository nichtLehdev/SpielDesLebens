﻿namespace Spiel_Des_Lebens
{
    internal class Action
    {
        public string id;
        public string title;
        public string info;
        public Option result;

        #region getters
        public string getId() { return id; }
        public string getTitle() { return title; }
        public string getInfo() { return info; }
        public Option getResult() { return result; }
        #endregion

        public Action(string id, string title, string info, Option result)
        {
            this.id = id;
            this.title = title;
            this.info = info;
            this.result = result;
        }
    }
}
