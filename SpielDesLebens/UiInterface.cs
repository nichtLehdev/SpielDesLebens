// @author: Joel Dag, Kevin Kern, Liz Wellhausen

using System.Collections.Generic;

namespace SpielDesLebens
{
    internal class UiInterface
    {
        private readonly Player _player;
        private readonly int _slot;
        private Event _currentEvent;
        private List<Action> _currentActions;
        public UiInterface(Player player, int slot)
        {
            _player = player;
            _slot = slot;
            NextAction();
        }

        public void SaveGame()
        {
            SaveLoadDeleteGame.SaveGame(_player, _slot);
        }

        public bool HasValidData()
        {
            return UiInterfaceMenu.HasValidData(_slot);
        }

        public int GetMaxActionPoints()
        {
            return _player.GetEducationPath().GetPhase().GetMaxActionPoints();
        }
        public void NextEvent()
        {
            _currentEvent = _player.GetEventgenerator().NextEvent(_player.GetPlayerStat());
        }

        private void NextAction()
        {
            _currentActions = _player.GetActionGenerator().GetActions();
        }

        #region GetActionString        
        public string GetActionTitle(int action)
        {
            if (action >= _currentActions.Count)
            {
                return "";
            }
            else
            {
                return _currentActions[action].GetTitle();
            }
        }

        public string GetActionInfo(int action)
        {
            if (action >= _currentActions.Count || _currentActions[action].GetInfo() == null)
            {
                return "";
            }
            else
            {
                return _currentActions[action].GetInfo();
            }
        }

        public string GetActionOptionTitle(int action)
        {
            if (action >= _currentActions.Count)
            {
                return "";
            }
            else
            {
                return _currentActions[action].GetResult().GetTitle();
            }
        }

        public string GetActionOptionText(int action)
        {
            if (action >= _currentActions.Count)
            {
                return "";
            }
            else
            {
                return _currentActions[action].GetResult().GetText();
            }
        }

        public void AfterActionTextRecieved(int action)
        {
            SubtractActionPoints(1);
            _player.ChangePlayerStat(_currentActions[action].GetResult().GetOptionStat());
        }

        public int GetActionOptionMainStat(int action)
        {
            int highStat = 0;
            if (action >= _currentActions.Count)
            {
                // There in case no valid action is selected.
            }
            else
            {
                Stat optionStat = _currentActions[action].GetResult().GetOptionStat();

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


        #region GetEventString
        public string GetEventOptionTitle(int option)
        {
            if (option >= _currentEvent.GetOptions().Count)
            {
                return "";
            }
            else
            {
                return _currentEvent.GetOptions()[option].GetTitle();
            }
        }

        public string GetEventOptionText(int option)
        {
            // Change player stats.
            if (option >= _currentEvent.GetOptions().Count)
            {
                return "";
            }
            else
            {
                SubtractActionPoints(2);
                ChangePlayerStats(option);
                return _currentEvent.GetOptions()[option].GetText();
            }
        }

        public string GetEventText()
        {
            return _currentEvent.GetText();
        }
        public string GetEventTitle()
        {
            return _currentEvent.GetTitle();
        }

        public string GetEventInfo()
        {
            if (_currentEvent.GetInfo() == null)
            {
                return "";
            }
            else
            {
                return _currentEvent.GetInfo();
            }
        }
        #endregion
        public int GetActionPoints()
        {
            return _player.GetEducationPath().GetPhase().GetActionPoints();
        }

        public int GetCurrentPhase()
        {
            return _player.GetEducationPath().GetPhase().GetCurrentPhase();
        }

        public int GetMaxPhaseNumber()
        {
            return _player.GetEducationPath().GetPhase().GetMaxPhaseNumber();
        }

        public Data.Graduation GetGraduation()
        {
            return _player.GetGraduation();
        }

        #region GetPlayerStats
        public int GetPlayerMoney()
        {
            foreach (StatParameter statsp in _player.GetPlayerStat().GetStats())
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
            foreach (StatParameter statsp in _player.GetPlayerStat().GetStats())
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
            foreach (StatParameter statsp in _player.GetPlayerStat().GetStats())
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
            foreach (StatParameter statsp in _player.GetPlayerStat().GetStats())
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
            Stat currentOptionStats = _currentEvent.GetOptions()[option].GetOptionStat();
            _player.ChangePlayerStat(currentOptionStats);
        }

        private void SubtractActionPoints(int cost)
        {
            _player.GetEducationPath().GetPhase().SubtractPoints(cost);
            if (_player.GetEducationPath().GetPhase().GetActionPoints() <= 0)
            {
                _player.NextPhase();
                NextAction();
            }
        }

        public string GetStatWarning()
        {
            Data.StatType? statType = _player.CheckStatSmaller(11);
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
                        warning = "Achtung! Dein Lernstand lässt vermuten, dass du die kommenden Prüfungen nicht bestehen wirst";
                        break;
                }
            }
            return warning;
        }

        public string GetGameEnd()
        {
            Data.StatType? statType = _player.CheckStatSmaller(1);
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
            if (_player.GetEducationPath().GetPhase().GetCurrentPhase() > GetMaxPhaseNumber())
            {
                if (_player.GetEducationPath().GetPath() == Data.Path.Training)
                {
                    gameEnd = "Erfolg!!! Du hast deine Ausbildung ";
                }
                else
                {
                    gameEnd = "Erfolg!!! Du hast dein Studium ";
                }
                gameEnd += "\"" + _player.GetEducationPath().GetProfessionName() + "\" erfolgreich absolviert!";

            }
            return gameEnd;
        }
        public void ResetPath(Data.Path path, Data.Profession profession)
        {
            _player.ResetCareer(path, profession);
            NextAction();
        }
        public void NextPhase()
        {
            _player.NextPhase();
            NextAction();
        }

        public bool IsInSchool()
        {
            int currentPhase = _player.GetEducationPath().GetPhase().GetCurrentPhase();
            if (currentPhase == 0)
            {
                return false;
            }
            if (_player.GetEducationPath().GetPath() == Data.Path.Training)
            {
                if (currentPhase % 2 == 0)
                {
                    return true;
                }
            }
            else if (_player.GetEducationPath().GetPath() == Data.Path.DualStudy)
            {
                if (currentPhase % 2 != 0)
                {
                    return true;
                }
            }
            // Seperatly in case of changes in the future.
            else if (_player.GetEducationPath().GetPath() == Data.Path.Study)
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
            return _player.GetAge();
        }
        public string GetPlayerName()
        {
            return _player.GetName();
        }
        public string GetPlayerProfessionName()
        {
            return _player.GetEducationPath().GetProfessionName();
        }
        public int GetAvatar()
        {
            return _player.GetAvatar();
        }

    }
}