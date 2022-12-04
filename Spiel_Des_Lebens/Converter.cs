using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class Converter
    {
       public static Player convertLoadPlayerToPlayer(loadPlayer lPlayer)
        {
            EventListConverter eventListConverter = new EventListConverter();
            List<Event> filteredEvents = eventListConverter.convertLoadEventToEvent(lPlayer.eventGenList);
            bool avatar;
            
            EducationPath eduPath = convertloadEduPathToEduPath(lPlayer.edu_path);
            return new Player(lPlayer.avatar, lPlayer.age, lPlayer.name, convertLoadStatToStat(lPlayer.stats), new Eventgenerator(eduPath, filteredEvents), eduPath);
        }

        private static EducationPath convertloadEduPathToEduPath(loadEduPath lEduPath)
        {
            return new EducationPath((Data.Path) lEduPath.path, (Data.Profession) lEduPath.profession, lEduPath.phase);
        }

        public static Option convertLoadOptionToOption(loadOption lOption)
        {
            return new Option(lOption.id, lOption.title, lOption.text, convertLoadStatToStat(lOption.stats));
        }

        public static Stat convertLoadStatToStat(loadStat lStat)
        {
            return new Stat(lStat.mentalHealth, lStat.money, lStat.motivation, lStat.success);
        }
    }
}
