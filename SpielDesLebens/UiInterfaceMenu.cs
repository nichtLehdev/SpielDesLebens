// @author: Maximilian Koch, Liz Wellhausen
// This class is the interface between the UI and the save game logic. It is used to load and start new games.

namespace SpielDesLebens
{
    internal class UiInterfaceMenu
    {
        private Player _player;

        public static bool HasValidData(int slot)
        {
            return SaveLoadDeleteGame.HasValidData(slot);
        }

        public void DeleteSaveGame(int slot)
        {
            SaveLoadDeleteGame.DeleteSaveGame(slot);
        }


        public void LoadGame(int slot)
        {
            if (SaveLoadDeleteGame.HasValidData(slot))
            {
                _player = SaveLoadDeleteGame.LoadGame(slot);
            }
        }

        public void CreatePlayer(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            _player = new Player(avatar, age, name, path, profession, graduation);
        }

        public UiInterface CreateUiInterface(int slot)
        {
            return new UiInterface(_player, slot);
        }
    }
}
