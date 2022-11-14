using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {
        private EducationPath edupath;

        public List<loadEvent> events = new List<loadEvent>();
        private List<Event> filteredEvents = new List<Event>();

        public Eventgenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            this.events = loadEvents();
            //this.events = filterEvents(events, path, profession);
            // TODO cleanup constructur, change player reset
            // TODO JSON: add priority to events
            // TODO relative path to json file in package
        }

        #region json
        private List<loadEvent> loadEvents()
        {
            // saves all events from JSON to events in List (filter by path and profession), leaves phases
            string filename = "..//..//..//data//events.json";
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
                /*if (e.requirements.path.Contains((int)path) && e.requirements.profession.Contains((int)profession))
                {
                    filterEvents.Add(e);
                }*/
            }
            return filterEvents;
        }
        #endregion

        public Event nextEvent(Stat stats, Phase phase)
        {
            // returns next Event
            return null; // delete!!!!!
        }

        public void filterEvents ()
        {
            //Events in filteredEvents kopieren

            foreach(Event e in filteredEvents)
            {
                bool phaseExists = false;
                for(int i = 0; i < e.requirements.timings.Length; i++)
                {
                    if(e.requirements.timings[(int)edupath.GetPath(), (int)edupath.getProfession(), i] == edupath.getPhase().getCurrentPhase())
                    {
                        phaseExists = true;
                    }
                }
                if(phaseExists == false)
                {
                    filteredEvents.Remove(e);
                }
            }
        }
    }

}

