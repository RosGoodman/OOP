
using System;

namespace OOP_Basic.Lesson5
{
    public struct RationalNumbers : IEquatable<RationalNumbers>
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

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат проверки на равенство.</returns>
        public static bool operator ==(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator == (decimal)numb2._Numerator / numb2._Denomenator;
        }

        /// <summary> Проверить неравенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат проверки на неравенство.</returns>
        public static bool operator !=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator != (decimal)numb2._Numerator / numb2._Denomenator;
        }

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int32.</param>
        /// <returns>Результат проверки на равенство.</returns>
        public static bool operator ==(RationalNumbers numb1, int numb2)
        {
            //при делении на int обрезается остаток, по этому проверка.
            if (numb1._Numerator % numb1._Denomenator != 0) return false;
            
            return numb1._Numerator / numb1._Denomenator == numb2;
        }

        /// <summary> Проверить неравенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int32.</param>
        /// <returns>Результат проверки на неравенство.</returns>
        public static bool operator !=(RationalNumbers numb1, int numb2)
        {
            //при делении на int обрезается остаток, по этому проверка.
            if (numb1._Numerator % numb1._Denomenator != 0) return true;

            return numb1._Numerator / numb1._Denomenator != numb2;
        }

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns>Результат проверки на равенство.</returns>
        public static bool operator ==(RationalNumbers numb1, float numb2)
        {
            float numb = (float)numb1._Numerator / numb1._Denomenator;
            return numb == numb2;
        }

        /// <summary> Проверить неравенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns>Результат проверки на неравенство.</returns>
        public static bool operator !=(RationalNumbers numb1, float numb2)
        {
            return (float)numb1._Numerator / numb1._Denomenator != numb2;
        }

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns>Результат проверки на равенство.</returns>
        public static bool operator ==(RationalNumbers numb1, decimal numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator == numb2;
        }

        /// <summary> Проверить неравенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns>Результат проверки на неравенство.</returns>
        public static bool operator !=(RationalNumbers numb1, decimal numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator != numb2;
        }

        #endregion

        #region equals

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="other"> Рациональное число. </param>
        /// <returns> Результат проверки на равенство. </returns>
        public bool Equals(RationalNumbers other)
        {
            return (_Numerator == other._Numerator) && (_Denomenator == other._Denomenator);
        }

        /// <summary> Проверить равенство двух чисел. </summary>
        /// <param name="other"> Рациональное число. </param>
        /// <returns> Результат проверки на равенство. </returns>
        public override bool Equals(object? obj)
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

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator <(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator < (decimal)numb2._Numerator / numb2._Denomenator;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator >(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator > (decimal)numb2._Numerator / numb2._Denomenator;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator <(RationalNumbers numb1, int numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator < numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator >(RationalNumbers numb1, int numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator > numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator <(RationalNumbers numb1, float numb2)
        {
            return (float)numb1._Numerator / numb1._Denomenator < numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator >(RationalNumbers numb1, float numb2)
        {
            return (float)numb1._Numerator / numb1._Denomenator > numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator <(RationalNumbers numb1, decimal numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator < numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator >(RationalNumbers numb1, decimal numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator > numb2;
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
