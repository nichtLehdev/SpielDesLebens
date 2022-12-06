﻿using Newtonsoft.Json;
using System.IO;

namespace SpielDesLebens
{

    internal class SaveLoadDeleteGame
    {
        public static void DeleteSaveGame(int slot)
        {
            string filename = "..//..//..//data//savegames//sg" + slot + ".json";
            switch (slot)
            {
                case 1:
                case 2:
                case 3:
                    if (File.Exists(filename))
                    {
                        File.WriteAllText(filename, "");
                    }
                    break;
                default:
                    throw new Error("Not a playable slot");
            }
        }

        public static bool HasValidData(int slot)
        {
            string filename = "..//..//..//data//savegames//sg" + slot + ".json";
            switch (slot)
            {
                case 1:
                case 2:
                case 3:
                    if (File.Exists(filename))
                    {
                        try
                        {
                            LoadPlayer lPlayer = JsonConvert.DeserializeObject<LoadPlayer>(File.ReadAllText(filename));
                            return lPlayer != null;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        public static Player LoadGame(int slot)
        {
            string filename = "..//..//..//data//savegames//sg" + slot + ".json";
            switch (slot)
            {
                case 1:
                case 2:
                case 3:
                    if (File.Exists(filename))
                    {
                        try
                        {
                            LoadPlayer lPlayer = JsonConvert.DeserializeObject<LoadPlayer>(File.ReadAllText(filename));
                            return Converter.ConvertLoadPlayerToPlayer(lPlayer);
                        }
                        catch
                        {
                            throw new Error("No player instance in this savegame");
                        }
                    }
                    else
                    {
                        throw new Error("SaveGame not found");
                    }
                default:
                    throw new Error("Not a playable slot");
            }
        }

        #region saveGame
        public static void SaveGame(Player player, int slot)
        {
            switch (slot)
            {
                case 1:
                case 2:
                case 3:
                    File.WriteAllText("..//..//..//data//savegames//sg" + slot + ".json", SerializePlayer(player));
                    break;

                default:
                    throw new Error("SaveGame: Wrong save-slot");
            }
        }

        private static string SerializePlayer(Player player)
        {
            string data = "{";
            data += "\"name\":\"" + player.GetName() + "\",";
            data += "\"age\":" + player.GetAge() + ",";
            data += "\"avatar\": " + player.GetAvatar() + ",";
            data += "\"stats\": {";
            data += "\"mentalHealth\":" + player.GetPlayerStat().GetStats()[0].GetValue() + ",";
            data += "\"money\":" + player.GetPlayerStat().GetStats()[1].GetValue() + ",";
            data += "\"motivation\":" + player.GetPlayerStat().GetStats()[2].GetValue() + ",";
            data += "\"success\":" + player.GetPlayerStat().GetStats()[3].GetValue();
            data += "},";
            data += "\"eventGenList\": [";
            foreach (Event e in player.Eventgenerator.GetFilteredEventsPathProf())
            {
                data += "{";
                data += "\"id\":\"" + e.Id + "\",";
                data += "\"title\":\"" + e.Title + "\",";
                data += "\"text\":\"" + e.Text + "\",";
                data += "\"info\":\"" + e.Info + "\",";
                data += "\"priority\":" + e.Priority + ",";
                data += "\"requirements\":{";
                data += "\"timings\":[";
                foreach (Timing t in e.Requirements.Timings)
                {
                    data += "{\"path\":[";
                    foreach (int p in t.Path)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length - 1);
                    data += "],";

                    data += "\"profession\":[";
                    foreach (int p in t.Profession)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length - 1);
                    data += "],";

                    data += "\"phase\":[";
                    foreach (int p in t.Phase)
                    {
                        data += "\"" + p + "\",";
                    }
                    data = data.Remove(data.Length - 1);
                    data += "]},";
                }
                data = data.Remove(data.Length - 1);
                data += "],";
                data += "\"statsMin\": {";
                data += "\"mentalHealth\":" + e.Requirements.ReqStatMin.GetStats()[0].GetValue() + ",";
                data += "\"money\":" + e.Requirements.ReqStatMin.GetStats()[1].GetValue() + ",";
                data += "\"motivation\":" + e.Requirements.ReqStatMin.GetStats()[2].GetValue() + ",";
                data += "\"success\":" + e.Requirements.ReqStatMin.GetStats()[3].GetValue();
                data += "},";
                data += "\"statsMax\": {";
                data += "\"mentalHealth\":" + e.Requirements.ReqStatMax.GetStats()[0].GetValue() + ",";
                data += "\"money\":" + e.Requirements.ReqStatMax.GetStats()[1].GetValue() + ",";
                data += "\"motivation\":" + e.Requirements.ReqStatMax.GetStats()[2].GetValue() + ",";
                data += "\"success\":" + e.Requirements.ReqStatMax.GetStats()[3].GetValue();
                data += "}},";
                data += "\"options\":[";
                foreach (Option o in e.Options)
                {
                    data += "{\"id\":\"" + o.Id + "\",";
                    data += "\"title\":\"" + o.Title + "\",";
                    data += "\"text\":\"" + o.Text + "\",";
                    data += "\"stats\":{";
                    data += "\"mentalHealth\":" + o.GetStats().GetStats()[0].GetValue() + ",";
                    data += "\"money\":" + o.GetStats().GetStats()[1].GetValue() + ",";
                    data += "\"motivation\":" + o.GetStats().GetStats()[2].GetValue() + ",";
                    data += "\"success\":" + o.GetStats().GetStats()[3].GetValue();
                    data += "}},";
                }
                data = data.Remove(data.Length - 1);
                data += "]},";
            }
            data = data.Remove(data.Length - 1);
            data += "],";
            data += "\"eduPath\":{";
            data += "\"path\":" + (int)player.GetEducationPath().GetPath() + ",";
            data += "\"profession\":" + (int)player.GetEducationPath().GetProfession() + ",";
            data += "\"phase\":" + player.GetEducationPath().GetPhase().GetCurrentPhase() + "}}";


            return data;
        }
        #endregion
    }
}