
namespace OOP_Basic.Lesson5
{
    class RationalNumbers
    {
        private int _Numerator;
        private int _Denomenator;

        public int Numerator
        {
            get
            {
                return _Numerator;
            }
            private set
            {
                _Numerator = value;
            }
        }

        public int Denomenator
        {
            get
            {
                return _Denomenator;
            }
            private set
            {
                _Denomenator = value;
            }
        }


        public RationalNumbers(int num, int den)
        {
            _Numerator = num;
            _Denomenator = den;
        }

        public static bool operator ==(RationalNumbers numb1, float numb2)
        {
            return numb1 == numb2;
        }

        public static bool operator !=(RationalNumbers numb1, float numb2)
        {
            return numb1 != numb2;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                RationalNumbers numb = (RationalNumbers)obj;
                return (_Numerator == numb.Numerator) && (_Denomenator == numb.Denomenator);
            }
        }

        public static bool operator <(RationalNumbers numb1, float numb2)
        {
            return numb1 < numb2;
        }

        public static bool operator >(RationalNumbers numb1, float numb2)
        {
            return numb1 > numb2;
        }

        public static bool operator <=(RationalNumbers numb1, float numb2)
        {
            return numb1 <= numb2;
        }

        public static bool operator >=(RationalNumbers numb1, float numb2)
        {
            return numb1 >= numb2;
        }

        public static bool operator +(RationalNumbers numb1, float numb2)
        {
            return numb1 + numb2;
        }

        public static bool operator -(RationalNumbers numb1, float numb2)
        {
            return numb1 - numb2;
        }

        public static RationalNumbers operator ++(RationalNumbers numb1, int numb2)
        {
            return new RationalNumbers(numb1.Numerator + numb2, numb1.Denomenator);
        }

        public static RationalNumbers operator --(RationalNumbers numb1, int numb2)
        {

            return new RationalNumbers(numb1.Numerator - numb2, numb1.Denomenator);
        }
    }
}
