namespace Spiel_Des_Lebens
{
    internal class StatParameter
    {
        private readonly Data.StatType name;
        private int value;
        private readonly bool toBeClampedBottom;
        private readonly bool toBeClampedTop;

        public StatParameter(Data.StatType name, int value, bool clampBottom, bool clampTop)
        {
            this.name = name;
            this.value = value;
            this.toBeClampedBottom = clampBottom;
            this.toBeClampedTop = clampTop;
        }


        public void ClampBottom()
        {
            if (toBeClampedBottom)
            {
                if (value < 0) { value = 0; }
            }
        }

        public void ClampTop()
        {
            if (toBeClampedTop)
            {
                if (value > 100) { value = 100; }
            }
        }

        public bool IsGreater(StatParameter statParamenter)
        {
            if (this.value == -1)
            {
                return true;
            }
            if (this.value >= statParamenter.value)
            {
                return true;
            }
            return false;
        }

        public bool IsSmaller(StatParameter statParamenter)
        {
            if (this.value <= statParamenter.value)
            {
                return true;
            }
            return false;
        }




        public Data.StatType GetName()
        {
            return name;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }


    }
}
