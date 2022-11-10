namespace Spiel_Des_Lebens
{
    internal class Requirement
    {
        private int[] path;
        private int[] profession;
        private int[] phase;
        private Stat reqStatMin;
        private Stat reqStatMax;

        public Requirement(int[] path, int[] profession, int[] phase, Stat minStats, Stat maxStats)
        {
            this.path = path;
            this.profession = profession;
            this.phase = phase;
            reqStatMin = minStats;
            reqStatMax = maxStats;
        }
    }
}
