// @author: Lars Lehmann

namespace SpielDesLebens
{
    internal class Action
    {
        private readonly string _id;
        private readonly string _title;
        private readonly string _info;
        private readonly Option _result;

        #region getters
        public string GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetInfo() { return _info; }
        public Option GetResult() { return _result; }
        #endregion

        public Action(string id, string title, string info, Option result)
        {
            _id = id;
            _title = title;
            _info = info;
            _result = result;
        }
    }
}
