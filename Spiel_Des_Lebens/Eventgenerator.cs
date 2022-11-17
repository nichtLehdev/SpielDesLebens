using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Spiel_Des_Lebens
{
    internal class Eventgenerator
    {
        private EducationPath edupath;

        private List<Event> filteredEventsPathProfession = new List<Event>();
        private List<Event> filteredEventsPhase = new List<Event>();
        private int seed = DateTime.Now.Millisecond;


        public Eventgenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            filterEventsByPathProfession(loadEvents());
            //this.events = filterEvents(events, path, profession);
            // TODO cleanup constructur, change player reset
            // TODO JSON: add priority to events
            // TODO relative path to json file in package
        }
        //Prio: for loop frägt Randomized Num ab, if(Randomized>50...) ist prio 1, dann 50 halbieren und nochmal
        //Bei Priority = 0 Event wird direkt das erste Event der events Liste ausgeführt und gelöscht mittels Id aus filteredEventsPathProfession

        public Event nextEvent(Stat stats)
        {
            filterEventsByPhase();
            List<Event> events = filterEventsByStats(stats);
            for (int i = 0; i < events.Count;)
            {
                if (events[i].priority == 0)
                {
                    deleteEventByID(events[i].id);
                    return events[i];
                }
            }
            while (true)
            {
                Random random = new Random(seed);
                double chance = random.NextDouble() * (100 - 0);
                double percentage = 50;
                int prio = 0;
                while (percentage < chance)
                {
                    prio++;
                    percentage /= 2;
                }
                List<Event> prioEvents = new List<Event>();
                for (int i = 0; i < events.Count; i++)
                {
                    if (events[i].priority == prio)
                    {
                        prioEvents.Add(events[i]);
                    }
                }
                if (prioEvents.Count != 0)
                {
                    int eventIndex = random.Next(prioEvents.Count);
                    filteredEventsPathProfession[findEventIndexByID(prioEvents[eventIndex].id)].priority *= 2;
                    return prioEvents[eventIndex];
                }
            }
        }

        private int findEventIndexByID(string id)
        {
            for (int i = 0; i < filteredEventsPathProfession.Count;)
            {
                if (filteredEventsPathProfession[i].id == id)
                {
                    return i;
                }
            }
            throw new Error("Event ID could not be found: " + id);
        }

        private void deleteEventByID(string id)
        {
            filteredEventsPathProfession.RemoveAt(findEventIndexByID(id));
        }

        #region load career events
        // public temp. for testing
        public List<Event> loadEvents()
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

