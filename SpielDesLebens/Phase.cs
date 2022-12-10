// @author: Joel Dag, Kevin Kern

namespace SpielDesLebens
{
    internal class Phase
    {
        private int currentPhase;
        private int actionPoints;
        private readonly int maxActionPoints;

        public Phase(int length)
        {
            actionPoints = length * 7;
            maxActionPoints = actionPoints;
        }

        public Phase(int currentPhase, int actionPoints, int length)
        {
            this.currentPhase = currentPhase;
            this.actionPoints = actionPoints;
            maxActionPoints = length * 7;
        }

        public int GetMaxActionPoints()
        {
            return maxActionPoints;
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
