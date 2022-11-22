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
            //TODO
            Stat stat = new Stat(50, 50, 50, 50);
            //player.eventgenerator.nextEvent(stat);
            return player.eventgenerator.nextEvent(stat);
        }

        public void receiveEventOption(Option option)
        {
            //return getNextEvent()
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
            return player.getEducationPath().getPhase().getCurrentPhase();
        }

        public int getCurrentPhase()
        {
            return player.getEducationPath().getPhase().getCurrentPhase();
        }

        public int getPlayerMoney()
        {

            foreach(StatParameter statsp in player.getPlayerStat().getStats())
            {
                if (statsp.getName().Equals("money"))
                {
                    return statsp.getValue();
                }
            }
            return 0;
        }

        public int getPlayerMentalHealth()
        {
            foreach (StatParameter statsp in player.getPlayerStat().getStats())
            {
                if (statsp.getName().Equals("mentalHealth"))
                {
                    return statsp.getValue();
                }
            }
            return 0;
        }

        public int getPlayerMotivation()
        {
            foreach (StatParameter statsp in player.getPlayerStat().getStats())
            {
                if (statsp.getName().Equals("motivation"))
                {
                    return statsp.getValue();
                }
            }
            return 0;
        }

        public int getPlayerSuccess()
        {
            foreach (StatParameter statsp in player.getPlayerStat().getStats())
            {
                if (statsp.getName().Equals("success"))
                {
                    return statsp.getValue();
                }
            }
            return 0;
        }





    }
}
