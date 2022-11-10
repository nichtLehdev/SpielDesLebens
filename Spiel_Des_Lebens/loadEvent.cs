using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class loadEvent
    {
        public string id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string info { get; set; }
        public loadRequirement requirements { get; set; }
        public List<loadOption> options { get; set; }
    }

}
