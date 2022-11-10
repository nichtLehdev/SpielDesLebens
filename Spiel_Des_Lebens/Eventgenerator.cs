using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using System;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {
        
        private List<Event> events = new List<Event>();

        public Eventgenerator(EducationPath.Path path, EducationPath.Profession profession)
        {
            loadEvents(path, profession);
        }

        private void loadEvents(EducationPath.Path path, EducationPath.Profession profession)
        {
           // saves all events from JSON to events in List (filter by path and profession), leaves phases
           string filename = "C:\\DATEN\\Git\\spiel-des-versagens\\data\\events.json";
            if (File.Exists(filename))
            {
                var test = JsonConvert.DeserializeObject<List <loadEvent>>(File.ReadAllText(filename));
            }
            else
            {
                throw new Error("Eventgenerator: File not found");
            }

        }

        public Event nextEvent(Stat stats, Phase phase)
        {
            // returns next Event
            return null; // delete!!!!!
        }
    }





}

