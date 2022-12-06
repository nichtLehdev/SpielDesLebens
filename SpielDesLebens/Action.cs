namespace SpielDesLebens
{
    internal class Action
    {
        private readonly string id;
        private readonly string title;
        private readonly string info;
        private readonly Option result;

        #region getters
        public string GetId() { return id; }
        public string GetTitle() { return title; }
        public string GetInfo() { return info; }
        public Option GetResult() { return result; }
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
