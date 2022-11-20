using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class UI_Interface
    {
        private Player player;
        public UI_Interface(bool avatar, int age, string name, Data.Path path, Data.Profession profession)
        {
            player = new Player(avatar, age, name, path, profession);
        }

        public Event getNextEvent()
        {
            return null;
        }

        public void receiveEventOption(Option option)
        {

        }

        public int[] getNextActionList()
        {
            return null; //length 3 needs new Class Action
        }

        public void receiveAction(int action) //needs new Class Action
        {

        }

        public int getActionPoints()
        {
            return 0;
        }

        public int getCurrentPhase()
        {
            return 0;
        }

        public Stat getPlayerStat()
        {
            return null;
        }



    }
}
