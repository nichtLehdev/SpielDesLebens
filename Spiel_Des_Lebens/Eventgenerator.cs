using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms.Design;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {
        private EducationPath edupath;

        private List<Event> filteredEventsPathProfession = new List<Event>();
        private List<Event> filteredEventsPhase = new List<Event>();


        public Eventgenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            filterEventsByPathProfession(loadEvents());
            //this.events = filterEvents(events, path, profession);
            // TODO cleanup constructur, change player reset
            // TODO JSON: add priority to events
            // TODO relative path to json file in package
        }

        public Event nextEvent(Stat stats)
        {
            filterEventsByPhase();
            List<Event> events = filterEventsByStats(stats);

            // returns next Event
            return null; // delete!!!!!
        }

        #region load career events
        private List<Event> loadEvents()
        {
            // saves all events from JSON to events in list saves all loadEvents as events
        string filename = "..//..//..//data//events.json";
            if (File.Exists(filename))
            {
                List<loadEvent> loadEvents = JsonConvert.DeserializeObject<List<loadEvent>>(File.ReadAllText(filename));
                
                EventListConverter eConverter = new EventListConverter();
                return eConverter.convertLoadEventToEvent(loadEvents);
            }
            else
            {
                throw new Error("Eventgenerator: File not found");
            }

        }


        // (filter by path and profession), leaves phases
        private void filterEventsByPathProfession(List<Event> events)
        {
            foreach (Event e in events)
            {
                foreach (Timing t in e.requirements.timings)
                {
                    if (t.path.Contains((int)edupath.getPath()) && t.profession.Contains((int)edupath.getProfession()))
                    {
                        filteredEventsPathProfession.Add(e);
                        break;
                    }
                }
            }
        }
        #endregion

        #region filter
        private void filterEventsByPhase()
        {
            //filters out all Events, which are valid for the current Phase and puts these in filteredList
            foreach (Event e in filteredEventsPathProfession)
            {
                foreach (Timing t in e.requirements.timings)
                {
                    if (t.phase.Contains(edupath.getPhase().getCurrentPhase()))
                    {
                        filteredEventsPhase.Add(e);
                        break;
                    }
                }
            }
        }

        private List<Event> filterEventsByStats(Stat playerStats)  //filters by Stats, change later, so that it removes false elements
        {
            List<Event> fEvents = new List<Event>();
            foreach (Event e in filteredEventsPhase)
            {
                if (e.requirements.reqStatMin.isSmaller(playerStats)
                    && e.requirements.reqStatMax.isGreater(playerStats))
                {
                    fEvents.Add(e);
                }
            }
            return fEvents;
        }
        #endregion

    }
 
    }
}

