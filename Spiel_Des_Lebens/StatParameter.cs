namespace Spiel_Des_Lebens
{
    internal class StatParameter
    {
        private Data.StatType name;
        private int value;
        private bool toBeClampedBottom;
        private bool toBeClampedTop;

        public StatParameter(Data.StatType name, int value, bool clampBottom, bool clampTop)
        {
            this.name = name;
            this.value = value;
            this.toBeClampedBottom = clampBottom;
            this.toBeClampedTop = clampTop;
        }


        public void clampBottom()
        {
            if (toBeClampedBottom)
            {
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

        public bool isGreater(StatParameter statParamenter)
        {
            if(this.value > statParamenter.value)
            {
                return true;
            }
            return false;
        }

        public bool isSmaller(StatParameter statParamenter)
        {
            if (this.value < statParamenter.value)
            {
                return true;
            }
            return false;
        }




        public Data.StatType getName()
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
