using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Spiel_Des_Lebens
{
 

    class Event
    {
        private string title;
        private string text;
        private Requirements requirement;
        private List<Option> options;
        // TODO Alles aus JSON als Attribut hier speichern.
        // TODO Objekt Strukt aus Klasse Stats wiederwenden.

        public Event(string title, string text, Requirements req, List<Option> options )
        {
            this.title = title;
            this.text = text;
            this.requirement = req;
            this.options = options;
        }
    }
}
