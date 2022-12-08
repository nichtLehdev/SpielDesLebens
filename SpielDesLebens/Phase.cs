// @author: Joel Dag, Kevin Kern

namespace SpielDesLebens
{
    internal class Phase
    {
        private int actionPoints;
        private int currentPhase;
        private readonly int maxActionPoints;
        public Phase(int length)
        {
            actionPoints = length * 7;
            maxActionPoints = actionPoints;
        }

        public int GetMaxActionPoints()
        {
            return maxActionPoints;
        }

        public Phase(int length, int currentPhase)
        {
            this.actionPoints = length * 7;
            this.currentPhase = currentPhase;
            maxActionPoints = actionPoints;
        }

        public int GetActionPoints()
        {
            return actionPoints;
        }

        public void SubtractPoints(int points)
        {
            actionPoints -= points;
        }

        public void NextPhase()
        {
            currentPhase++;
            actionPoints = maxActionPoints;
        }

        public int GetCurrentPhase()
        {
            return currentPhase;
        }

        public int GetMaxPhaseNumber()
        {
            return (int)((3 * 12) / (maxActionPoints / 7));
        }
    }
}
