// @author: Lars Lehmann
// Class for handling savegames. It can save, load and delete savegames.

using Newtonsoft.Json;
using System.IO;

namespace SpielDesLebens
{

    internal class SaveLoadDeleteGame
    {
        public static void DeleteSaveGame(int slot)
        {
            string filename = Data.filenameSavegames + slot + ".json";
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
            string filename = Data.filenameSavegames + slot + ".json";
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
            string filename = Data.filenameSavegames + slot + ".json";
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

        #region SaveGame
        public static void SaveGame(Player player, int slot)
        {
            switch (slot)
            {
                case 1:
                case 2:
                case 3:
                    File.WriteAllText(Data.filenameSavegames + slot + ".json", SerializePlayer(player));
                    break;

                default:
                    throw new Error("SaveGame: Wrong save-slot");
            }
        }

        private static string SerializePlayer(Player player)
        {
            LoadPlayer lPlayer = Converter.ConvertPlayerToLoadPlayer(player);
            string s = JsonConvert.SerializeObject(lPlayer);

            return s;
        }
        #endregion
    }
}