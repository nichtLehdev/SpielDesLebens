namespace Spiel_Des_Lebens
{
    internal class Requirement
    {
        private int[,,] timings;
        private Stat reqStatMin;
        private Stat reqStatMax;

        public Requirement(int[,,] timings, Stat minStats, Stat maxStats)
        {
            this.timings = timings;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }
    }
}
