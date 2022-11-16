using Newtonsoft.Json;
using System;
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
        private List<Event> filteredEvents2 = new List<Event>();  // ist nicht schön, aber provisorisch und kommt wieder 


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

        public Event nextEvent(Stat stats)
        {
            filterEventsByPhase();
            filterEventsByStats(stats);

            return null;
            
        }

        private void filterEventsByPhase()
        {
            //filters out all Events, which are valid for the current Phase and puts these in filteredList
            foreach (Event e in filteredEvents)
            {
                foreach (Timing t in e.requirements.timings)
                {
                    foreach (int phasenumber in t.phase)
                    {
                        if(phasenumber == edupath.getPhase().getCurrentPhase())
                        {
                                filteredEvents.Add(e); //change to remove
                        }
                    }
                }
            }
        }

        private void filterEventsByStats(Stat playerStats)  //filters by Stats, change later, so that it removes false elements
        {
            foreach (Event e in filteredEvents)
            {
                    if (e.requirements.reqStatMin.isSmaller(playerStats) 
                        && e.requirements.reqStatMax.isGreater(playerStats))
                    {
                        filteredEvents2.Add(e); //change to remove 
                    }
            }
        }

 
    }
}

