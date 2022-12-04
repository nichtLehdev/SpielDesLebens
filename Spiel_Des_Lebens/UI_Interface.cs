using System;
using System.Collections.Generic;

namespace Spiel_Des_Lebens
{
   internal class UI_Interface
   {
      private Player player;
      private Event currentEvent;
      private List<Action> currentActions;
      public UI_Interface(int avatar, int age, string name, Data.Path path, Data.Profession profession, Data.Graduation graduation)
      {
         player = new Player(avatar, age, name, path, profession, graduation);
         nextAction();
      }

      public int getMaxActionPoints()
      {
         return player.getEducationPath().getPhase().getMaxActionPoints();
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
            subtractActionPoints(1);
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
            subtractActionPoints(2);
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
      public int getActionPoints()
      {
         return player.getEducationPath().getPhase().getActionPoints();
      }
      public int getCurrentPhase()
      {
         return player.getEducationPath().getPhase().getCurrentPhase();
      }

      public int getMaxPhaseLength()
      {
         return player.getEducationPath().getPhaseLength();
      }

      public int getMaxPhaseNumber()
      {
         return player.getEducationPath().getPhase().getMaxPhaseNumber();
      }

      public Data.Graduation getGraduation()
      {
         return player.getGraduation();
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
      private void changePlayerStats(int option)
      {
         Stat currentOptionStats = currentEvent.options[option].getStats();
         this.player.changePlayerStat(currentOptionStats);
      }

      private void subtractActionPoints(int cost)
      {
         player.getEducationPath().getPhase().subtractPoints(cost);
         if (player.getEducationPath().getPhase().getActionPoints() <= 0)
         {
            player.nextPhase();
            nextAction();
         }
      }

      public String getStatWarning()
      {
         Data.StatType? statType = player.checkStatSmaller(11);
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

      public String getGameEnd()
      {
         Data.StatType? statType = player.checkStatSmaller(1);
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
         if (player.getEducationPath().getPhase().getCurrentPhase() > getMaxPhaseNumber())
         {
            if (player.getEducationPath().getPath() == Data.Path.Training)
            {
               gameEnd = "Erfolg!!! Du hast deine Ausbildung ";
            }
            else
            {
               gameEnd = "Erfolg!!! Du hast dein Studium ";
            }
            gameEnd += "\"" + player.getEducationPath().getProfessionName() + "\" erfolgreich absolviert!";

         }
         return gameEnd;
      }
      public void resetPath(Data.Path path, Data.Profession profession)
      {
         player.resetCareer(path, profession);
         Stat stats = new Stat(10, 10, 10, 10);
         player.changePlayerStat(stats);
         nextAction();
      }
      public void nextPhase()
      {
         player.nextPhase();
         nextAction();
      }

      public bool isInSchool()
      {
         int currentPhase = player.getEducationPath().getPhase().getCurrentPhase();
         if (currentPhase == 0)
         {
            return false;
         }
         if (player.getEducationPath().getPath() == Data.Path.Training)
         {
            if (currentPhase % 2 == 0)
            {
               return true;
            }
         }
         else if (player.getEducationPath().getPath() == Data.Path.DualStudy)
         {
            if (currentPhase % 2 != 0)
            {
               return true;
            }
         }
         else if (player.getEducationPath().getPath() == Data.Path.Study) // seperatly in case of changes in the future
         {
            if (currentPhase % 2 != 0)
            {
               return true;
            }
         }
         return false;
      }

      public int getPlayerAge()
      {
         return player.getAge();
      }
   }
}