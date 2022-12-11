// @author: Joel Dag, Kevin Kern, Maximilian Koch

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SpielDesLebens
{
    internal class EventGenerator
    {
        private readonly EducationPath _eduPath;

        private readonly List<Event> _filteredEventsPathProfession = new List<Event>();
        private readonly List<Event> _filteredEventsPhase = new List<Event>();
        private int _seed;


        #region GetterSetter
        public List<Event> GetFilteredEventsPathProf()
        {
            return _filteredEventsPathProfession;
        }
        #endregion


        public EventGenerator(EducationPath eduPath, List<Event> filteredEvents)
        {
            _eduPath = eduPath;
            _filteredEventsPathProfession = filteredEvents;
        }

        public EventGenerator(EducationPath edupath)
        {
            _eduPath = edupath;
            FilterEventsByPathProfession(LoadEvents());
        }

        // Priority handling:
        // priority = 0: the first event of the events list, whith priority = 0 is returned directly and deleted using the id from filteredEventsPathProfession.
        // priotity != 0: for loop queries randomized number, if(randNum > 50...) priority 1, then halve 50 and again...
        public Event NextEvent(Stat stats)
        {
            FilterEventsByPhase();
            List<Event> events = FilterEventsByStats(stats).OrderBy(x => x.GetPriority()).ToList();

            // There to prvent a crash if there are no events left.
            // Ugly fix for the game end, because there again an event is requested for a phase for which there are no events.
            if (events.Count == 0)
            {
                return _filteredEventsPathProfession[0];
            }

            if (events[0].GetPriority() == 0)
            {
                DeleteEventByID(events[0].GetId());
                return events[0];
            }

            _seed = DateTime.Now.Millisecond;
            Random random = new Random(_seed);
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
            _filteredEventsPathProfession[idx].SetPriority((_filteredEventsPathProfession[idx].GetPriority() * Data.SPrioFactor));
            return prioEvents[rand];
        }


        private int FindEventIndexByID(string id)
        {
            for (int i = 0; i < _filteredEventsPathProfession.Count; i++)
            {
                if (_filteredEventsPathProfession[i].GetId() == id)
                {
                    return i;
                }
            }

            throw new Error("Event ID could not be found: " + id);
        }

        private void DeleteEventByID(string id)
        {
            _filteredEventsPathProfession.RemoveAt(FindEventIndexByID(id));
        }

        #region LoadCareerEvents
        // Saves all events from JSON to LoadEvents in a list, saves all LoadEvents as Events.
        private List<Event> LoadEvents()
        {
            if (File.Exists(Data.filenameEvents))
            {
                List<LoadEvent> loadEvents = JsonConvert.DeserializeObject<List<LoadEvent>>(File.ReadAllText(Data.filenameEvents));

                EventListConverter eConverter = new EventListConverter();
                return eConverter.ConvertLoadEventToEvent(loadEvents);
            }
            else
            {
                throw new Error("EventGenerator: File not found");
            }

        }


        // Filters by Path and Profession, leaves Phases.
        private void FilterEventsByPathProfession(List<Event> events)
        {
            foreach (Event e in events)
            {
                foreach (Timing t in e.GetRequirements().GetTimings())
                {
                    if (t.GetPath().Contains((int)_eduPath.GetPath()) && t.GetProfession().Contains((int)_eduPath.GetProfession()))
                    {
                        _filteredEventsPathProfession.Add(e);
                        break;
                    }
                }
            }
        }
        #endregion

        #region Filter
        private void FilterEventsByPhase()
        {
            _filteredEventsPhase.Clear();
            // Filters out all Events, which are valid for the current Phase and puts these in filteredEventsPhase List.
            foreach (Event e in _filteredEventsPathProfession)
            {
                foreach (Timing t in e.GetRequirements().GetTimings())
                {
                    if (t.GetPhase().Contains(_eduPath.GetPhase().GetCurrentPhase()) && t.GetPath().Contains((int)_eduPath.GetPath()) && t.GetProfession().Contains((int)_eduPath.GetProfession()))
                    {
                        _filteredEventsPhase.Add(e);
                        break;
                    }
                }
            }
        }

        // Filters by Stats.
        private List<Event> FilterEventsByStats(Stat playerStats)
        {
            List<Event> fEvents = new List<Event>();
            foreach (Event e in _filteredEventsPhase)
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

#if DEBUG
        // For Debugging only !!!
        public List<Event> LoadEventsDebug()
        {
            return LoadEvents();
        }
#endif
#if DEBUG        
        // For Debugging only !!!
        public void FilterEventsByPhaseDebug()
        {
            FilterEventsByPhase();
        }
#endif
#if DEBUG
        // For Debugging only !!!
        public List<Event> GetFilteredEventsPhase()
        {
            return _filteredEventsPhase;
        }
#endif

    }
}

