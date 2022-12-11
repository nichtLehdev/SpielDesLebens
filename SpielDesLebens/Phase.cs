// @author: Joel Dag, Kevin Kern
// Data class for a phase. A phase consists of a current phase, action points and a maximum action points. It also holds a method to calculate the maximum phase number.

namespace SpielDesLebens
{
    internal class Phase
    {
        private int _currentPhase;
        private int _actionPoints;
        private readonly int _maxActionPoints;

        public Phase(int length)
        {
            _actionPoints = length * 7;
            _maxActionPoints = _actionPoints;
        }

        public Phase(int currentPhase, int actionPoints, int length)
        {
            _currentPhase = currentPhase;
            _actionPoints = actionPoints;
            _maxActionPoints = length * 7;
        }

        public int GetMaxActionPoints()
        {
            return _maxActionPoints;
        }

        public int GetActionPoints()
        {
            return _actionPoints;
        }

        public void SubtractPoints(int points)
        {
            _actionPoints -= points;
        }

        public void NextPhase()
        {
            _currentPhase++;
            _actionPoints = _maxActionPoints;
        }

        public int GetCurrentPhase()
        {
            return _currentPhase;
        }

        public int GetMaxPhaseNumber()
        {
            return (int)((3 * 12) / (_maxActionPoints / 7));
        }
    }
}
