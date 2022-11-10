using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using System;
using static Spiel_Des_Lebens.EducationPath;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {

        public List<loadEvent> events = new List<loadEvent>();

        public Eventgenerator(Data.Path path, Data.Profession profession)
        {
            List<loadEvent> events = loadEvents();
            this.events = filterEvents(events, path, profession);
            // TODO cleanup constructur, change player reset
            // TODO JSON: add priority to events
            // TODO relative path to json file in package
        }

        #region json
        private List<loadEvent> loadEvents()
        {
            // saves all events from JSON to events in List (filter by path and profession), leaves phases
            string filename = "C:\\DATEN\\Git\\spiel-des-versagens\\data\\events.json";
            if (File.Exists(filename))
            {
                return JsonConvert.DeserializeObject<List<loadEvent>>(File.ReadAllText(filename));
            }
            else
            {
                throw new Error("Eventgenerator: File not found");
            }

        }

        public List<loadEvent> filterEvents(List<loadEvent> events, Data.Path path, Data.Profession profession)
        {
            List<loadEvent> filterEvents = new List<loadEvent>();
            foreach (loadEvent e in events)
            {
                //if (Array.IndexOf(e.requirements.path, (int)path) != -1 && Array.IndexOf(e.requirements.profession, (int)profession) != -1)
                if (e.requirements.path.Contains((int)path) && e.requirements.profession.Contains((int)profession))
                {
                    filterEvents.Add(e);
                }
            }
            return filterEvents;
        }
        #endregion

        public Event nextEvent(Stat stats, Phase phase)
        {
            // returns next Event
            return null; // delete!!!!!
        }
    }

}

