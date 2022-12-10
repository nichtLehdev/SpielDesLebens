// @author: Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal class StatParameter
    {
        private readonly Data.StatType _name;
        private int _value;
        private readonly bool _toBeClampedBottom;
        private readonly bool _toBeClampedTop;

        public StatParameter(Data.StatType name, int value, bool clampBottom, bool clampTop)
        {
            _name = name;
            _value = value;
            _toBeClampedBottom = clampBottom;
            _toBeClampedTop = clampTop;
        }


        public void ClampBottom()
        {
            if (_toBeClampedBottom)
            {
                if (_value < 0) { _value = 0; }
            }
        }

        public void ClampTop()
        {
            if (_toBeClampedTop)
            {
                if (_value > 100) { _value = 100; }
            }
        }

        public bool IsGreater(StatParameter statParamenter)
        {
            if (_value == -1)
            {
                return true;
            }
            if (_value >= statParamenter._value)
            {
                return true;
            }
            return false;
        }

        public bool IsSmaller(StatParameter statParamenter)
        {
            if (_value <= statParamenter._value)
            {
                return true;
            }
            return false;
        }




        public Data.StatType GetName()
        {
            return _name;
        }

        public int GetValue()
        {
            return _value;
        }

        public void SetValue(int value)
        {
            _value = value;
        }


    }
}
