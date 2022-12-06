using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpielDesLebens
{
    internal class Eventgenerator
    {
        private readonly EducationPath edupath;

        private readonly List<Event> FilteredEventsPathProfession = new List<Event>();
        private readonly List<Event> FilteredEventsPhase = new List<Event>();
        private int seed;


        #region Getter and Setter
        public List<Event> GetFilteredEventsPathProf()
        {
            return FilteredEventsPathProfession;
        }
        #endregion


        public Eventgenerator(EducationPath eduPath, List<Event> filteredEvents)
        {
            this.edupath = eduPath;
            this.FilteredEventsPathProfession = filteredEvents;
        }
        public Eventgenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            FilterEventsByPathProfession(LoadEvents());
            // TODO cleanup constructur, change player reset
            // TODO relative path to json file in package
        }

        //Prio: for loop frägt Randomized Num ab, if(Randomized>50...) ist prio 1, dann 50 halbieren und nochmal
        //Bei Priority = 0 Event wird direkt das erste Event der events Liste ausgeführt und gelöscht mittels Id aus filteredEventsPathProfession
        public Event NextEvent(Stat stats)
        {
            FilterEventsByPhase();
            List<Event> events = FilterEventsByStats(stats);
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Priority == 0)
                {
                    DeleteEventByID(events[i].Id);
                    return events[i];
                }
            }
            while (true)
            {
                seed = DateTime.Now.Millisecond;
                Random random = new Random(seed);
                double chance = random.NextDouble() * (100 - 0);
                double percentage = 50;
                int prio = 1;
                while (percentage >= chance)
                {
                    prio++;
                    percentage /= 2;
                }
                List<Event> prioEvents = new List<Event>();
                for (int i = 0; i < events.Count; i++)
                {
                    if (events[i].Priority == prio)
                    {
                        prioEvents.Add(events[i]);
                    }
                }
                if (prioEvents.Count != 0)
                {
                    int eventIndex = random.Next(prioEvents.Count);
                    FilteredEventsPathProfession[FindEventIndexByID(prioEvents[eventIndex].Id)].Priority += 1;
                    return prioEvents[eventIndex];
                }
            }
        }

        private int FindEventIndexByID(string id)
        {
            for (int i = 0; i < FilteredEventsPathProfession.Count; i++)
            {
                if (FilteredEventsPathProfession[i].Id == id)
                {
                    return i;
                }
            }
            throw new Error("Event ID could not be found: " + id);
        }

        private void DeleteEventByID(string id)
        {
            FilteredEventsPathProfession.RemoveAt(FindEventIndexByID(id));
        }

        #region load career events
        // public temp. for testing
        public List<Event> LoadEvents()
        {
            // saves all events from JSON to events in list saves all loadEvents as events
            string filename = "..//..//..//data//events.json";
            if (File.Exists(filename))
            {
                List<LoadEvent> loadEvents = JsonConvert.DeserializeObject<List<LoadEvent>>(File.ReadAllText(filename));

                EventListConverter eConverter = new EventListConverter();
                return eConverter.ConvertLoadEventToEvent(loadEvents);
            }
            else
            {
                throw new Error("Eventgenerator: File not found");
            }

        }


        // (filter by path and profession), leaves phases
        private void FilterEventsByPathProfession(List<Event> events)
        {
            foreach (Event e in events)
            {
                foreach (Timing t in e.Requirements.timings)
                {
                    if (t.Path.Contains((int)edupath.GetPath()) && t.Profession.Contains((int)edupath.GetProfession()))
                    {
                        FilteredEventsPathProfession.Add(e);
                        break;
                    }
                }
            }
        }
        #endregion

        #region filter
        private void FilterEventsByPhase()
        {
            FilteredEventsPhase.Clear();
            //filters out all Events, which are valid for the current Phase and puts these in filteredList
            foreach (Event e in FilteredEventsPathProfession)
            {
                foreach (Timing t in e.Requirements.timings)
                {
                    if (t.Phase.Contains(edupath.GetPhase().GetCurrentPhase()) && t.Path.Contains((int)edupath.GetPath()) && t.Profession.Contains((int)edupath.GetProfession()))
                    {
                        FilteredEventsPhase.Add(e);
                        break;
                    }
                }
            }
        }

        private List<Event> FilterEventsByStats(Stat playerStats)  //filters by Stats, change later, so that it removes false elements
        {
            List<Event> fEvents = new List<Event>();
            foreach (Event e in FilteredEventsPhase)
            {
                if (e.Requirements.reqStatMin.IsSmaller(playerStats)
                    && e.Requirements.reqStatMax.IsGreater(playerStats))
                {
                    fEvents.Add(e);
                }
            }
            return fEvents;
        }
        #endregion

    }
}

