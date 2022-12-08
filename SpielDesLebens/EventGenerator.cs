﻿// @author: Joel Dag, Kevin Kern, Maximilian Koch

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SpielDesLebens
{
    internal class EventGenerator
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


        public EventGenerator(EducationPath eduPath, List<Event> filteredEvents)
        {
            this.edupath = eduPath;
            this.filteredEventsPathProfession = filteredEvents;
        }

        public EventGenerator(EducationPath edupath)
        {
            this.edupath = edupath;
            FilterEventsByPathProfession(LoadEvents());
        }

        // Priority handling:
        // priority = 0: the first event of the events list, whith priority = 0 is returned directly and deleted using the id from filteredEventsPathProfession.
        // priotity != 0: for loop queries randomized number, if(randNum > 50...) priority 1, then halve 50 and again...
        public Event NextEvent(Stat stats)
        {
            FilterEventsByPhase();
            List<Event> events = FilterEventsByStats(stats).OrderBy(x => x.GetPriority()).ToList();

            if (events[0].GetPriority() == 0)
            {
                DeleteEventByID(events[0].GetId());
                return events[0];
            }

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

            for (int i = 0; i < events.Count(); i++)
            {
                if (events[i].GetPriority() > prio)
                {
                    if (i != 0)
                    {
                        prio = events[i - 1].GetPriority();
                    }
                    else
                    {
                        prio = events[i].GetPriority();
                    }
                    break;
                }
                else if (i + 1 == events.Count())
                {
                    prio = events[i].GetPriority();
                }
            }

            List<Event> prioEvents = new List<Event>();
            foreach (Event e in events)
            {
                if (e.GetPriority() == prio)
                {
                    prioEvents.Add(e);
                }
            }

            int rand = random.Next(0, prioEvents.Count());
            int idx = FindEventIndexByID(prioEvents[rand].GetId());
            filteredEventsPathProfession[idx].SetPriority((filteredEventsPathProfession[idx].GetPriority() * Data.SPrioFactor));
            return prioEvents[rand];
        }


        private int FindEventIndexByID(string id)
        {
            foreach (Event e in filteredEventsPathProfession)
            {
                if (e.GetId() == id)
                {
                    return filteredEventsPathProfession.IndexOf(e);
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
            // Saves all events from JSON to LoadEvents in a list, saves all LoadEvents as Events.
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


        // Filters by Path and Profession, leaves Phases.
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
            // Filters out all Events, which are valid for the current Phase and puts these in filteredEventsPhase List.
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

        // Filters by Stats.
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


        // For Debugging only !!!
        public List<Event> LoadEventsDebug()
        {
            return LoadEvents();
        }

        // For Debugging only !!!
        public void FilterEventsByPhaseDebug()
        {
            FilterEventsByPhase();
        }

        // For Debugging only !!!
        public List<Event> GetFilteredEventsPhase()
        {
            return filteredEventsPhase;
        }

    }
}

