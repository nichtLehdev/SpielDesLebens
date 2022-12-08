// @author: Joel Dag, Kevin Kern, Liz Wellhausen

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class UiInterface
    {
        private readonly Player player;
        private readonly int slot;
        private Event currentEvent;
        private List<Action> currentActions;
        public UiInterface(Player player, int slot)
        {
            this.player = player;
            this.slot = slot;
            NextAction();
        }

        public void SaveGame()
        {
            SaveLoadDeleteGame.SaveGame(this.player, this.slot);
        }

        public int GetMaxActionPoints()
        {
            return player.GetEducationPath().GetPhase().GetMaxActionPoints();
        }
        public void NextEvent()
        {
            currentEvent = player.GetEventgenerator().NextEvent(player.GetPlayerStat());
        }

        private void NextAction()
        {
            currentActions = player.GetActionGenerator().GetActions();
        }

        #region getActionString        
        public string GetActionTitle(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                return currentActions[action].GetTitle();
            }
        }

        public string GetActionInfo(int action)
        {
            if (action >= currentActions.Count || currentActions[action].GetInfo() == null)
            {
                return "";
            }
            else
            {
                return currentActions[action].GetInfo();
            }
        }

        public string GetActionOptionTitle(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                return currentActions[action].GetResult().GetTitle();
            }
        }

        public string GetActionOptionText(int action)
        {
            if (action >= currentActions.Count)
            {
                return "";
            }
            else
            {
                SubtractActionPoints(1);
                this.player.ChangePlayerStat(currentActions[action].GetResult().GetOptionStat());
                return currentActions[action].GetResult().GetText();
            }
        }

        public int GetActionOptionMainStat(int action)
        {
            int highStat = 0;
            if (action >= currentActions.Count)
            {
                // There in case no valid action is selected.
            }
            else
            {
                Stat optionStat = currentActions[action].GetResult().GetOptionStat();

                for (int i = 0; i < optionStat.GetStats().Count; i++)
                {
                    if (optionStat.GetStats()[highStat].GetValue() < optionStat.GetStats()[i].GetValue())
                    {
                        highStat = i;
                    }
                }

                // Test if no stat ist positive for criminal actions to display a custom / diffreent icon.
                if (optionStat.GetStats()[highStat].GetValue() <= 0)
                {
                    highStat = -1;
                }

            }


            return highStat;
        }


        #endregion


        #region getEventString
        public string GetEventOptionTitle(int option)
        {
            if (option >= currentEvent.GetOptions().Count)
            {
                return "";
            }
            else
            {
                return currentEvent.GetOptions()[option].GetTitle();
            }
        }

        public string GetEventOptionText(int option)
        {
            // Change player stats.
            if (option >= currentEvent.GetOptions().Count)
            {
                return "";
            }
            else
            {
                SubtractActionPoints(2);
                ChangePlayerStats(option);
                return currentEvent.GetOptions()[option].GetText();
            }
        }

        public string GetEventText()
        {
            return currentEvent.GetText();
        }
        public string GetEventTitle()
        {
            return currentEvent.GetTitle();
        }

        public string GetEventInfo()
        {
            if (currentEvent.GetInfo() == null)
            {
                return "";
            }
            else
            {
                return currentEvent.GetInfo();
            }
        }
        #endregion
        public int GetActionPoints()
        {
            return player.GetEducationPath().GetPhase().GetActionPoints();
        }
        public int GetCurrentPhase()
        {
            return player.GetEducationPath().GetPhase().GetCurrentPhase();
        }


        public int GetMaxPhaseNumber()
        {
            return player.GetEducationPath().GetPhase().GetMaxPhaseNumber();
        }

        public Data.Graduation GetGraduation()
        {
            return player.GetGraduation();
        }


        #region getPlayerStats
        public int GetPlayerMoney()
        {
            foreach (StatParameter statsp in player.GetPlayerStat().GetStats())
            {
                if (statsp.GetName().ToString() == "money")
                {
                    return statsp.GetValue();
                }
            }
            return 0;
        }
        public int GetPlayerMentalHealth()
        {
            foreach (StatParameter statsp in player.GetPlayerStat().GetStats())
            {
                if (statsp.GetName().ToString() == "mentalHealth")
                {
                    return statsp.GetValue();
                }
            }
            return 0;
        }
        public int GetPlayerMotivation()
        {
            foreach (StatParameter statsp in player.GetPlayerStat().GetStats())
            {
                if (statsp.GetName().ToString() == "motivation")
                {
                    return statsp.GetValue();
                }
            }
            return 0;
        }
        public int GetPlayerSuccess()
        {
            foreach (StatParameter statsp in player.GetPlayerStat().GetStats())
            {
                if (statsp.GetName().ToString() == "success")
                {
                    return statsp.GetValue();
                }
            }
            return 0;
        }
        #endregion
        private void ChangePlayerStats(int option)
        {
            Stat currentOptionStats = currentEvent.GetOptions()[option].GetOptionStat();
            this.player.ChangePlayerStat(currentOptionStats);
        }

        private void SubtractActionPoints(int cost)
        {
            player.GetEducationPath().GetPhase().SubtractPoints(cost);
            if (player.GetEducationPath().GetPhase().GetActionPoints() <= 0)
            {
                player.NextPhase();
                NextAction();
            }
        }

        public string GetStatWarning()
        {
            Data.StatType? statType = player.CheckStatSmaller(11);
            string warning = "";
            if (statType != null)
            {
                switch ((int)statType)
                {
                    case 0:
                        warning = "Achtung! Deine Mentale Gesundheit hat einen kritischen Zustand erreicht";
                        break;
                    case 1:
                        warning = "Achtung! Du bist fast Pleite";
                        break;
                    case 2:
                        warning = "Achtung! Deine Motivation hat einen kritischen Zustand erreicht";
                        break;
                    case 3:
                        warning = "Achtung! Dein Lernstand lässt vermuten, dass du die kommenden Klausuren nicht bestehen wirst";
                        break;
                }
            }
            return warning;
        }

        public string GetGameEnd()
        {
            Data.StatType? statType = player.CheckStatSmaller(1);
            string gameEnd = "";
            if (statType != null)
            {
                switch ((int)statType)
                {
                    case 0:
                        gameEnd = "Game Over!!! Du hast nicht auf deine Mentale Gesundheit geachtet und hast daher Selbstmord begangen";
                        break;
                    case 1:
                        gameEnd = "Game Over!!! Du bist Pleite und kannst deine laufenden Kosten nicht mehr tragen";
                        break;
                    case 2:
                        gameEnd = "Game Over!!! Du hast keine Motivation mehr und dein Leben ergibt keinen Sinn mehr";
                        break;
                    case 3:
                        gameEnd = "Game Over!!! Du hast zu wenig gelernt und hast deine Prüfungen nicht bestanden";
                        break;
                }
            }
            if (player.GetEducationPath().GetPhase().GetCurrentPhase() > GetMaxPhaseNumber())
            {
                if (player.GetEducationPath().GetPath() == Data.Path.Training)
                {
                    gameEnd = "Erfolg!!! Du hast deine Ausbildung ";
                }
                else
                {
                    gameEnd = "Erfolg!!! Du hast dein Studium ";
                }
                gameEnd += "\"" + player.GetEducationPath().GetProfessionName() + "\" erfolgreich absolviert!";

            }
            return gameEnd;
        }
        public void ResetPath(Data.Path path, Data.Profession profession)
        {
            player.ResetCareer(path, profession);
            NextAction();
        }
        public void NextPhase()
        {
            player.NextPhase();
            NextAction();
        }

        public bool IsInSchool()
        {
            int currentPhase = player.GetEducationPath().GetPhase().GetCurrentPhase();
            if (currentPhase == 0)
            {
                return false;
            }
            if (player.GetEducationPath().GetPath() == Data.Path.Training)
            {
                if (currentPhase % 2 == 0)
                {
                    return true;
                }
            }
            else if (player.GetEducationPath().GetPath() == Data.Path.DualStudy)
            {
                if (currentPhase % 2 != 0)
                {
                    return true;
                }
            }
            else if (player.GetEducationPath().GetPath() == Data.Path.Study) // seperatly in case of changes in the future
            {
                if (currentPhase % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetPlayerAge()
        {
            return player.GetAge();
        }
        public string GetPlayerName()
        {
            return player.GetName();
        }
        public string GetPlayerProfessionName()
        {
            return player.GetEducationPath().GetProfessionName();
        }
        public int GetAvatar()
        {
            return player.GetAvatar();
        }

    }
}