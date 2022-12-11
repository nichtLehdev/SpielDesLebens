// @author: Lars Lehmann
// Data class for an action. An action is a choice the player can make. It has an id, a title, an info text and a result.

namespace SpielDesLebens
{
    internal class Action
    {
        private readonly string _id;
        private readonly string _title;
        private readonly string _info;
        private readonly Option _result;

        #region Getter
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
