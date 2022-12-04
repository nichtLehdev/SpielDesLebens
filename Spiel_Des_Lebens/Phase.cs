namespace Spiel_Des_Lebens
{
    internal class Phase
    {
        private int actionPoints;
        private int currentPhase;
        public Phase(int length)
        {
            actionPoints = length * 7;
        }

        public Phase(int length, int currentPhase)
        {
            this.actionPoints = length * 7;
            this.currentPhase = currentPhase;
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
        }

        public int getCurrentPhase()
        {
            return currentPhase;
        }
    }
}
