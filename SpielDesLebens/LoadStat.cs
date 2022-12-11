// @author: Maximilian Koch, Lars Lehmann
// Data class for a LoadStat.

namespace SpielDesLebens
{
    internal class LoadStat
    {
        public int mentalHealth { get; set; }
        public int money { get; set; }
        public int motivation { get; set; }
        public int success { get; set; }

        public LoadStat(int mentalHealth, int money, int motivation, int success)
        {
            this.mentalHealth = mentalHealth;
            this.money = money;
            this.motivation = motivation;
            this.success = success;
        }
    }
}