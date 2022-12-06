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
            return new Player(lPlayer.avatar, lPlayer.age, lPlayer.name, ConvertLoadStatToStat(lPlayer.stats), new Eventgenerator(eduPath, filteredEvents), eduPath);
        }

        private static EducationPath ConvertloadEduPathToEduPath(LoadEducationPath lEduPath)
        {
            return new EducationPath((Data.Path)lEduPath.path, (Data.Profession)lEduPath.profession, lEduPath.phase);
        }

        public static Option ConvertLoadOptionToOption(LoadOption lOption)
        {
            return new Option(lOption.id, lOption.title, lOption.text, ConvertLoadStatToStat(lOption.stats));
        }

        public static Stat ConvertLoadStatToStat(LoadStat lStat)
        {
            return new Stat(lStat.mentalHealth, lStat.money, lStat.motivation, lStat.success);
        }
    }
}
