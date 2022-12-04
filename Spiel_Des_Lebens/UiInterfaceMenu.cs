namespace Spiel_Des_Lebens
{
    internal class UiInterfaceMenu
    {
        private Player player;

        public bool hasValidData(int slot)
        {
            return SaveLoadGame.hasValidData(slot);
        }

        public void deleteSaveGame(int slot)
        {
            SaveLoadGame.deleteSaveGame(slot);
        }


        public void loadGame(int slot)
        {
            if (SaveLoadGame.hasValidData(slot))
            {
                player = SaveLoadGame.loadGame(slot);
            }
        }

        public void createPlayer(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
        {
            player = new Player(avatar, age, name, path, profession, graduation);
        }

        public UiInterface createUiInterface()
        {
            return new UiInterface(this.player);
        }



    }
}
