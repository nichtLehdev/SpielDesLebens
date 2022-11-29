using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Spiel_Des_Lebens
{
    internal class UI_Interface
    {
        private Player player;
        private Event currentEvent;
        public UI_Interface(bool avatar, int age, string name, Data.Path path, Data.Profession profession)
        {
            player = new Player(avatar, age, name, path, profession);
        }
        public void nextEvent()
        {
            currentEvent = player.eventgenerator.nextEvent(player.getPlayerStat());
        }
        #region getEventString
        public String getEventOptionTitle(int option)
        {
            if (option >= currentEvent.getOption().Count)
            {
                return "";
            }
            else
            {
                return currentEvent.getOption()[option].getTitle();
            }
        }

        public String getEventOptionText(int option)
        {
            //Player stats verändern
            if (option >= currentEvent.getOption().Count)
            {
                return "";
            }
            else
            {
                changePlayerStats(option);
                return currentEvent.getOption()[option].getText();
            }
        }

        public String getEventText()
        {
            return currentEvent.text;
        }
        public String getEventTitle()
        {
            return currentEvent.title;
        }

        public String getEventInfo()
        {
            if (currentEvent.info == null)
            {
                return "";
            }
            else
            {
                return currentEvent.info;
            }
        }
        #endregion

        public int[] getNextActionList()
        {
            return null; //length 3 needs new Class Action
        }
        public void receiveAction(int action) //needs new Class Action
        {
        }
        public int getActionPoints()
        {
            return player.getEducationPath().getPhase().getActionPoints();
        }
        public int getCurrentPhase()
        {
            return player.getEducationPath().getPhase().getCurrentPhase();
        }

        public int getMaxPhase()
        {
            return player.getEducationPath().getPhaseLength();
        }


        #region getPlayerStats
        public int getPlayerMoney()
        {
            foreach (StatParameter statsp in player.getPlayerStat().getStats())
            {
                if (statsp.getName().ToString() == "money")
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
                if (statsp.getName().ToString() == "mentalHealth")
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
                if (statsp.getName().ToString() == "motivation")
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
                if (statsp.getName().ToString() == "success")
                {
                    return statsp.getValue();
                }
            }
            return 0;
        }
        #endregion
        public void changePlayerStats(int option)
        {
            Stat currentOptionStats = currentEvent.options[option].getStats();
            this.player.changePlayerStat(currentOptionStats);
        }

    }
}
