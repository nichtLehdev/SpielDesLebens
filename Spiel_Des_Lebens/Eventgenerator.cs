using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Spiel_Des_Lebens
{
    class Eventgenerator
    {
        private List<Event> events = new List<Event>();

        public Eventgenerator(Player.Path path, EducationPath.Profession profession)
        {
            loadEvents(path, profession);
        }

        private void loadEvents(Player.Path path, EducationPath.Profession profession)
        {
            // saves all events from JSON to events in List (filter by path and profession), leaves phases
        }

        public Event nextEvent(Stats stats, Phase phase)
        {
            // returns next Event
            return null; // delete!!!!!
        }
    }
}
