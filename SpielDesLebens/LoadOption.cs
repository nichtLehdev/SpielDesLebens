// @author: Maximilian Koch, Lars Lehmann
// Data class for a LoadOption.

namespace SpielDesLebens
{
    internal class LoadOption
    {
        public string id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public LoadStat stats { get; set; }

        public LoadOption(string id, string title, string text, LoadStat stats)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.stats = stats;
        }
    }

}
