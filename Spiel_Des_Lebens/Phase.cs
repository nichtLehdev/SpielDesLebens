namespace Spiel_Des_Lebens
{
    internal class Phase
    {
        private int actionPoints;
        private int currentPhase;
        private int maxActionPoints;
        public Phase(int length)
        {
            actionPoints = length * 7;
            maxActionPoints = actionPoints;
        }

        public int getMaxActionPoints()
        {
            return maxActionPoints;
        }

        public int getActionPoints()
        {
            return actionPoints;
        }

        public void subtractPoints(int points)
        {
            actionPoints -= points;
        }

        public void nextPhase()
        {
            currentPhase++;
            actionPoints = maxActionPoints;
        }

        public int getCurrentPhase()
        {
            return currentPhase;
        }

        public int getMaxPhaseNumber()
        {
            return (int)((3 * 12) / (maxActionPoints / 7));
        }
    }
}
