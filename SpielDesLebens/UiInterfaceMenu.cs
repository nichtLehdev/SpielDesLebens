// @author: Maximilian Koch, Liz Wellhausen

namespace SpielDesLebens
{
    internal class UiInterfaceMenu
    {
        private Player player;

        public bool HasValidData(int slot)
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
                player = SaveLoadDeleteGame.LoadGame(slot);
            }
        }

        public void CreatePlayer(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            player = new Player(avatar, age, name, path, profession, graduation);
        }

        public UiInterface CreateUiInterface(int slot)
        {
            return new UiInterface(this.player, slot);
        }
    }
}
