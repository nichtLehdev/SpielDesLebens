namespace SpielDesLebens
{
    internal class Action
    {
        private readonly string Id;
        private readonly string Title;
        private readonly string Info;
        private readonly Option Result;

        #region getters
        public string GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetInfo() { return Info; }
        public Option GetResult() { return Result; }
        #endregion

        public Action(string id, string title, string info, Option result)
        {
            this.Id = id;
            this.Title = title;
            this.Info = info;
            this.Result = result;
        }
    }
}
