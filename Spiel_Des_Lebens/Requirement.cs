namespace Spiel_Des_Lebens
{
    internal class Requirement
    {
        public int[,,] timings;
        public Stat reqStatMin;
        public Stat reqStatMax;

        public Requirement(int[,,] timings, Stat minStats, Stat maxStats)
        {
            this.timings = timings;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }
    }
}
