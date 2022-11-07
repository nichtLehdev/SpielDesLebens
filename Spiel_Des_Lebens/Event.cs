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

        }

        public Event(string title, string text, int[] path, int[] profession, int minStatMentalHealth, int minStatMotivation, int minStatMoney, int minStatSuccess, int maxStatMentalHealth, int maxStatMotivation, int maxStatMoney, int maxStatSuccess, List<Option> options)
        {

        }
        
        public Event(Requirements req, string option1Title, int? option1StatMentalHealth, int? option1StatMotivation, int? option1StatMoney, int? option1StatSuccess, string option2Title, int? option2StatMentalHealth, int? option2StatMotivation, int? option2StatMoney, int? option2StatSuccess, string? option3Title, int? option3StatMentalHealth, int? option3StatMotivation, int? option3StatMoney, int? option3StatSuccess, string? option4Title, int? option4StatMentalHealth, int? option4StatMotivation, int? option4StatMoney, int? option4StatSuccess)
        {

        }

        public Event(string title, string text, int[] path, int[] profession, int minStatMentalHealth, int minStatMotivation, int minStatMoney, int minStatSuccess, int maxStatMentalHealth, int maxStatMotivation, int maxStatMoney, int maxStatSuccess, string option1Title, int? option1StatMentalHealth, int? option1StatMotivation, int? option1StatMoney, int? option1StatSuccess, string option2Title, int? option2StatMentalHealth, int? option2StatMotivation, int? option2StatMoney, int? option2StatSuccess, string? option3Title, int? option3StatMentalHealth, int? option3StatMotivation, int? option3StatMoney, int? option3StatSuccess, string? option4Title, int? option4StatMentalHealth, int? option4StatMotivation, int? option4StatMoney, int? option4StatSuccess)
        {

        }
    }
}
