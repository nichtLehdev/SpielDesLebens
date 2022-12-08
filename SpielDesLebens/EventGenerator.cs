// @author: Joel Dag, Kevin Kern, Maximilian Koch

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpielDesLebens
{
    internal class Eventgenerator
    {
        private readonly EducationPath edupath;

        private readonly List<Event> filteredEventsPathProfession = new List<Event>();
        private readonly List<Event> filteredEventsPhase = new List<Event>();
        private int seed;


        #region Getter and Setter
        public List<Event> GetFilteredEventsPathProf()
        {
            return filteredEventsPathProfession;
        }
        #endregion


        public Eventgenerator(EducationPath eduPath, List<Event> filteredEvents)
        {
            this.edupath = eduPath;
            this.filteredEventsPathProfession = filteredEvents;
        }

        public Eventgenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            FilterEventsByPathProfession(LoadEvents());
        }

        // priority handling:
        // priority = 0: the first event of the events list, whith priority = 0 is returned directly and deleted using the id from filteredEventsPathProfession.
        // priotity != 0: for loop queries randomized number, if(randNum > 50...) priority 1, then halve 50 and again...
        public Event NextEvent(Stat stats)
        {
            FilterEventsByPhase();
            List<Event> events = FilterEventsByStats(stats);
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].GetPriority() == 0)
                {
                    DeleteEventByID(events[i].GetId());
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
                    if (events[i].GetPriority() == prio)
                    {
                        prioEvents.Add(events[i]);
                    }
                }
                if (prioEvents.Count != 0)
                {
                    int eventIndex = random.Next(prioEvents.Count);
                    int index = FindEventIndexByID(prioEvents[eventIndex].GetId());
                    filteredEventsPathProfession[index].SetPriority((filteredEventsPathProfession[index].GetPriority() + 1));
                    return prioEvents[eventIndex];
                }
            }
        }

        private int FindEventIndexByID(string id)
        {
            for (int i = 0; i < filteredEventsPathProfession.Count; i++)
            {
                if (filteredEventsPathProfession[i].GetId() == id)
                {
                    return i;
                }
            }
            throw new Error("Event ID could not be found: " + id);
        }

        private void DeleteEventByID(string id)
        {
            filteredEventsPathProfession.RemoveAt(FindEventIndexByID(id));
        }

        #region load career events
        private List<Event> LoadEvents()
        {
            // saves all events from JSON to LoadEvents in a list, saves all LoadEvents as Events
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


        // filters by Path and Profession, leaves Phases
        private void FilterEventsByPathProfession(List<Event> events)
        {
            foreach (Event e in events)
            {
                foreach (Timing t in e.GetRequirements().GetTimings())
                {
                    if (t.GetPath().Contains((int)edupath.GetPath()) && t.GetProfession().Contains((int)edupath.GetProfession()))
                    {
                        filteredEventsPathProfession.Add(e);
                        break;
                    }
                }
            }
        }
        #endregion

        #region filter
        private void FilterEventsByPhase()
        {
            filteredEventsPhase.Clear();
            //filters out all Events, which are valid for the current Phase and puts these in filteredEventsPhase List
            foreach (Event e in filteredEventsPathProfession)
            {
                foreach (Timing t in e.GetRequirements().GetTimings())
                {
                    if (t.GetPhase().Contains(edupath.GetPhase().GetCurrentPhase()) && t.GetPath().Contains((int)edupath.GetPath()) && t.GetProfession().Contains((int)edupath.GetProfession()))
                    {
                        filteredEventsPhase.Add(e);
                        break;
                    }
                }
            }
        }

        // filters by Stats
        private List<Event> FilterEventsByStats(Stat playerStats)
        {
            List<Event> fEvents = new List<Event>();
            foreach (Event e in filteredEventsPhase)
            {
                if (e.GetRequirements().GetReqStatMin().IsSmaller(playerStats)
                    && e.GetRequirements().GetReqStatMax().IsGreater(playerStats))
                {
                    fEvents.Add(e);
                }
            }
            return fEvents;
        }
        #endregion


        // for Debugging only !!!
        public List<Event> LoadEventsDebug()
        {
            return LoadEvents();
        }

        // for Debugging only !!!
        public void FilterEventsByPhaseDebug()
        {
            FilterEventsByPhase();
        }

        // for Debugging only !!!
        public List<Event> GetFilteredEventsPhase()
        {
            return filteredEventsPhase;
        }

    }
}

