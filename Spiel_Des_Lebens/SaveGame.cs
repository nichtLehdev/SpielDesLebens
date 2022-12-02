using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{

    internal class SaveGame
    {
        public static void saveGame(Player player, int slot)
        {
            switch (slot)
            {
                case 1: case 2: case 3:
                    File.WriteAllText("..//..//..//data//savegames//sg" + slot + ".json", serializePlayer(player));
                break;
                
                default:
                    throw new Error("SaveGame: Wrong save-slot");
            }
        }

        private static string serializePlayer(Player player)
        {
            string data = "{";
            data += "\"name\":\"" + player.getName() + "\",";
            data += "\"age\":" + player.getAge() + ",";
            data += "\"avatar\": \"" + player.getAvatar().ToString() + "\",";
            data += "\"stats\": {";
            data += "\"mentalHealth\":" + player.getPlayerStat().getStats()[0].getValue() + ",";
            data += "\"money\":" + player.getPlayerStat().getStats()[1].getValue() + ",";
            data += "\"motivation\":" + player.getPlayerStat().getStats()[2].getValue() + ",";
            data += "\"success\":" + player.getPlayerStat().getStats()[3].getValue();
            data += "},";
            data += "\"eventGenList\": [";
            foreach (Event e in player.eventgenerator.getFilteredEventsPathProf())
            {
                data += "{";
                data += "\"id\":\"" + e.id +"\",";
                data += "\"title\":\"" + e.title + "\",";
                data += "\"text\":\"" + e.text + "\",";
                data += "\"info\":\"" + e.info + "\",";
                data += "\"priority\":" + e.priority + ",";
                data += "\"requirements\":{";
                data += "\"timings\":[";
                foreach (Timing t in e.requirements.timings)
                {
                    data += "{\"path\":[";
                    foreach (int p in t.path)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length-1);
                    data += "],";

                    data += "\"profession\":[";
                    foreach (int p in t.profession)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length - 1);
                    data += "],";

                    data += "\"phase\":[";
                    foreach (int p in t.phase)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length - 1);
                    data += "]},";
                }
                data += "],";
                data += "\"stats_min\": {";
                data += "\"mentalHealth\":" + e.requirements.reqStatMin.getStats()[0].getValue() + ",";
                data += "\"money\":" + e.requirements.reqStatMin.getStats()[1].getValue() + ",";
                data += "\"motivation\":" + e.requirements.reqStatMin.getStats()[2].getValue() + ",";
                data += "\"success\":" + e.requirements.reqStatMin.getStats()[3].getValue();
                data += "},";
                data += "\"stats_max\": {";
                data += "\"mentalHealth\":" + e.requirements.reqStatMin.getStats()[0].getValue() + ",";
                data += "\"money\":" + e.requirements.reqStatMin.getStats()[1].getValue() + ",";
                data += "\"motivation\":" + e.requirements.reqStatMin.getStats()[2].getValue() + ",";
                data += "\"success\":" + e.requirements.reqStatMin.getStats()[3].getValue();
                data += "}},";
                data += "\"options\":[";
                foreach (Option o in e.options)
                {
                    data += "{\"id\":\"" + o.id + "\",";
                    data += "\"title\":\"" + o.title + "\",";
                    data += "\"text\":\"" + o.text + "\",";
                    data += "\"stats\":{";
                    data += "\"mentalHealth\":" + o.getStats().getStats()[0].getValue() + ",";
                    data += "\"money\":" + o.getStats().getStats()[1].getValue() + ",";
                    data += "\"motivation\":" + o.getStats().getStats()[2].getValue() + ",";
                    data += "\"success\":" + o.getStats().getStats()[3].getValue();
                    data += "}},";
                }
                data = data.Remove(data.Length - 1);
                data += "],},";
            }
            data = data.Remove(data.Length - 1);
            data += "],";
            data += "\"edu_path\":{";
            data += "\"path\":\"" + player.getEducationPath().getPath().ToString() + "\",";
            data += "\"profession\":\"" + player.getEducationPath().getProfession().ToString() + "\",";
            data += "\"phase\":" + player.getEducationPath().getPhase().getCurrentPhase() +"}}";


            return data;
        }
    }
}
