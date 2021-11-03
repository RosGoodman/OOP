
using System;

namespace OOP_Basic.Lesson5
{
    struct RationalNumbers
    {
        private int _Numerator;

        private int _Denomenator;

        public RationalNumbers(int num, int den)
        {
            if (den < 0) throw new Exception("Знаменатель должен быть натуральным числом.");
            _Numerator = num;
            _Denomenator = den;
        }

        #region == !=

        public static bool operator ==(RationalNumbers numb1, RationalNumbers numb2)
        {
            return numb1 == numb2;
        }

        public static bool operator !=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return numb1 != numb2;
        }

        public static bool operator ==(RationalNumbers numb1, int numb2)
        {
            return numb1 == numb2;
        }

        public static bool operator !=(RationalNumbers numb1, int numb2)
        {
            return numb1 != numb2;
        }

        public static bool operator ==(RationalNumbers numb1, float numb2)
        {
            return numb1 == numb2;
        }

        public static bool operator !=(RationalNumbers numb1, float numb2)
        {
            return numb1 != numb2;
        }

        public static bool operator ==(RationalNumbers numb1, decimal numb2)
        {
            return numb1 == numb2;
        }

        public static bool operator !=(RationalNumbers numb1, decimal numb2)
        {
            return numb1 != numb2;
        }

        #endregion

        #region equals

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                RationalNumbers numb = (RationalNumbers)obj;
                return (_Numerator == numb._Numerator) && (_Denomenator == numb._Denomenator);
            }
        }

        #endregion

        #region <>

        public static bool operator <(RationalNumbers numb1, RationalNumbers numb2)
        {
            return numb1 < numb2;
        }

        public static bool operator >(RationalNumbers numb1, RationalNumbers numb2)
        {
            return numb1 > numb2;
        }

        public static bool operator <(RationalNumbers numb1, float numb2)
        {
            return numb1 < numb2;
        }

        public static bool operator >(RationalNumbers numb1, float numb2)
        {
            return numb1 > numb2;
        }

        public static bool operator <(RationalNumbers numb1, int numb2)
        {
            return numb1 < numb2;
        }

        public static bool operator >(RationalNumbers numb1, int numb2)
        {
            return numb1 > numb2;
        }

        public static bool operator <(RationalNumbers numb1, decimal numb2)
        {
            return numb1 < numb2;
        }

        public static bool operator >(RationalNumbers numb1, decimal numb2)
        {
            return numb1 > numb2;
        }

        #endregion

        #region <= >=

        public static bool operator <=(RationalNumbers numb1, float numb2)
        {
            return numb1 <= numb2;
        }

        public static bool operator >=(RationalNumbers numb1, float numb2)
        {
            return numb1 >= numb2;
        }

        #endregion

        #region +-

        public static bool operator +(RationalNumbers numb1, float numb2)
        {
            return numb1 + numb2;
        }

        public static bool operator -(RationalNumbers numb1, float numb2)
        {
            return numb1 - numb2;
        }

        #endregion

        #region ++ --

        public static RationalNumbers operator ++(RationalNumbers numb1)
        {
            return new RationalNumbers(numb1._Numerator + 1, numb1._Denomenator);
        }

        public static RationalNumbers operator --(RationalNumbers numb1)
        {

            return new RationalNumbers(numb1._Numerator - 1, numb1._Denomenator);
        }

        #endregion

        #region % * /


        #endregion

        #region GetHashCode

        //метод переопределен для того, чтобы убрать предупреждение
        public override int GetHashCode()
        {
            return _Numerator.GetHashCode();
        }

        #endregion

        #region toString

        public override string ToString()
        {
            string str = String.Format(@"{0}/{1}", _Numerator, _Denomenator);
            return str;
        }

        #endregion

        #region Convert to

        public static explicit operator int(RationalNumbers numb)
        {
            return Convert.ToInt32(numb._Numerator / numb._Denomenator);
        }

        public static explicit operator float(RationalNumbers numb)
        {
            return numb._Numerator / numb._Denomenator;
        }

        #endregion
    }
}
