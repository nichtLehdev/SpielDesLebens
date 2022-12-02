using System;
using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
    internal class UI_Interface
    {
        private Player player;
        private Event currentEvent;
        private List<Action> currentActions;
        public UI_Interface(bool avatar, int age, string name, Data.Path path, Data.Profession profession)
        {
            player = new Player(avatar, age, name, path, profession);
            nextAction();
        }
        public void nextEvent()
        {
            currentEvent = player.eventgenerator.nextEvent(player.getPlayerStat());
        }

        private void nextAction()
        {
            currentActions = player.actiongenerator.getActions();
        }

        #region getActionString

        public String getActionTitle(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                return currentActions[action].getTitle();
            }
        }

        public String getActionInfo(int action)
        {
            if (action >= currentActions.Count || currentActions[action].getInfo() == null)
            {
                return "";
            }
            else
            {
                return currentActions[action].getInfo();
            }
        }

        public String getActionOptionTitle(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                return currentActions[action].getResult().getTitle();
            }
        }

        public String getActionOptionText(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                this.player.changePlayerStat(currentActions[action].getResult().getStats());
                return currentActions[action].getResult().getText();
            }
        }

        public int getActionOptionMainStat(int action)
        {
            int highStat = 0;
            if (action >= currentActions.Count)
            {
                return highStat;
            }
            else
            {
                Stat optionStat = currentActions[action].getResult().getStats();

                for (int i = 0; i < optionStat.getStats().Count; i++)
                {
                    if (optionStat.getStats()[highStat].getValue() < optionStat.getStats()[i].getValue())
                    {
                        highStat = i;
                    }
                }
            }
            return highStat;
        }


        #endregion


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

        public void saveGame(int slot)
        {
            SaveGame.saveGame(player, slot);
        }

    }
}
