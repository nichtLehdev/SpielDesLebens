// @author: Maximilian Koch, Lars Lehmann

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class Converter
    {
        public static Player ConvertLoadPlayerToPlayer(LoadPlayer lPlayer)
        {
            EventListConverter eventListConverter = new EventListConverter();
            List<Event> filteredEvents = eventListConverter.ConvertLoadEventToEvent(lPlayer.eventGenList);
            EducationPath eduPath = ConvertloadEduPathToEduPath(lPlayer.eduPath);
            return new Player(lPlayer.avatar, lPlayer.age, lPlayer.graduation, lPlayer.name, ConvertLoadStatToStat(lPlayer.stats), new EventGenerator(eduPath, filteredEvents), eduPath);
        }

        private static EducationPath ConvertloadEduPathToEduPath(LoadEducationPath lEduPath)
        {
            return new EducationPath((Data.Path)lEduPath.path, (Data.Profession)lEduPath.profession, lEduPath.phase, lEduPath.actionPoints);
        }

        public static Option ConvertLoadOptionToOption(LoadOption lOption)
        {
            return new Option(lOption.id, lOption.title, lOption.text, ConvertLoadStatToStat(lOption.stats));
        }

        public static Stat ConvertLoadStatToStat(LoadStat lStat)
        {
            return new Stat(lStat.mentalHealth, lStat.money, lStat.motivation, lStat.success);
        }

        private static LoadStat ConvertStatToLoadStat(Stat stat)
        {
            return new LoadStat(stat.GetStats()[0].GetValue(), stat.GetStats()[1].GetValue(), stat.GetStats()[2].GetValue(), stat.GetStats()[3].GetValue());
        }

        private static LoadEvent ConvertEventToLoadEvent(Event e)
        {
            List<LoadOption> loadOptions = new List<LoadOption>();
            foreach (Option o in e.GetOptions())
            {
                loadOptions.Add(ConvertOptionToLoadOption(o));
            }
            return new LoadEvent(e.GetId(), e.GetTitle(), e.GetText(), e.GetInfo(), e.GetPriority(), ConvertRequirementToLoadRequirement(e.GetRequirements()), loadOptions);
        }

        public static LoadPlayer ConvertPlayerToLoadPlayer(Player p)
        {
            List<LoadEvent> loadEvents = new List<LoadEvent>();
            foreach (Event e in p.GetEventgenerator().GetFilteredEventsPathProf())
            {
                loadEvents.Add(ConvertEventToLoadEvent(e));
            }
            return new LoadPlayer(p.GetName(), p.GetAge(), p.GetAvatar(), (int)p.GetGraduation(), ConvertStatToLoadStat(p.GetPlayerStat()), loadEvents, ConvertEducationPathToLoadEducationPath(p.GetEducationPath()));
        }

        private static LoadOption ConvertOptionToLoadOption(Option o)
        {
            return new LoadOption(o.GetId(), o.GetTitle(), o.GetText(), ConvertStatToLoadStat(o.GetOptionStat()));
        }

        private static LoadEducationPath ConvertEducationPathToLoadEducationPath(EducationPath educationPath)
        {
            return new LoadEducationPath((int)educationPath.GetPath(), (int)educationPath.GetProfession(), (int)educationPath.GetPhase().GetCurrentPhase(), (int) educationPath.GetPhase().GetActionPoints());
        }

        private static LoadRequirement ConvertRequirementToLoadRequirement(Requirement req)
        {
            List<LoadTiming> loadTimings = new List<LoadTiming>();
            foreach (Timing t in req.GetTimings())
            {
                loadTimings.Add(ConvertTimingToLoadTiming(t));
            }
            return new LoadRequirement(loadTimings, ConvertStatToLoadStat(req.GetReqStatMin()), ConvertStatToLoadStat(req.GetReqStatMax()));
        }

        private static LoadTiming ConvertTimingToLoadTiming(Timing timing)
        {
            return new LoadTiming(ConvertIntListToStringList(timing.GetPath()), ConvertIntListToStringList(timing.GetProfession()), ConvertIntListToStringList(timing.GetPhase()));
        }

        private static List<string> ConvertIntListToStringList(List<int> list)
        {
            List<string> result = new List<string>();
            foreach (int item in list)
            {
                result.Add(item.ToString());
            }
            return result;
        }
    }
}
