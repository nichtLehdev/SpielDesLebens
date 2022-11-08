namespace Spiel_Des_Lebens
{
    internal class StatsParameter
    {
        public enum StatType { mentalHealth, money, motivation, success };
        private StatType name;
        private int value;
        private bool toBeClampedBottom;
        private bool toBeClampedTop;

        public StatsParameter(StatType name, int value, bool clampBottom, bool clampTop)
        {
            this.name = name;
            this.value = value;
            this.toBeClampedBottom = clampBottom;
            this.toBeClampedTop = clampTop;
        }


        public void clampBottom()
        {
            if (toBeClampedBottom) { 
                if (value < 0) { value = 0; }
            }
        }

        public void clampTop()
        {
            if (toBeClampedTop)
            {
                if (value < 100) { value = 100; }
            }
        }
             


        
        public StatType getName()
        {
            return name;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
        }
  

    }
}
