namespace Spiel_Des_Lebens
{
    internal class UiInterfaceMenu
    {

        public bool hasValidData(int slot)
        {
            return SaveLoadGame.hasValidData(slot);
        }

        public void deleteSaveGame(int slot)
        {
            SaveLoadGame.deleteSaveGame(slot);
        }


        public Player loadGame(int slot)
        {
            if (SaveLoadGame.hasValidData(slot))
            {
                return SaveLoadGame.loadGame(slot);
            }
            else
            {
                return null;
            }
        }

    }
}
