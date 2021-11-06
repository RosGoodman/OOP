
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
            decimal n1 = (decimal)numb1._Numerator / numb1._Denomenator;
            decimal n2 = (decimal)numb2._Numerator / numb1._Denomenator;
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

        #endregion

        #region <= >=

        /// <summary> Меньше либо равно. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки. </returns>
        public static bool operator <=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator <= (decimal)numb2._Numerator / numb2._Denomenator;
        }

        /// <summary> Больше либо равно. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки. </returns>
        public static bool operator >=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1._Numerator / numb1._Denomenator >= (decimal)numb2._Numerator / numb2._Denomenator;
        }

        #endregion

        #region +-

        /// <summary> Получить результат сложения. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator +(RationalNumbers numb1, RationalNumbers numb2)
        {
            if(numb1._Denomenator == numb2._Denomenator)
            {
                numb1._Numerator = numb1._Numerator + numb2._Numerator;
            }
            else
            {
                //приведение
                numb1._Numerator = numb1._Numerator * numb2._Denomenator;
                numb1._Denomenator = numb1._Denomenator * numb2._Denomenator;
                //сложение
                numb1._Numerator = numb1._Numerator + numb2._Numerator;
            }

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(numb1);

            return numb1;
        }

        /// <summary> Разделить числитель из наменатель на общее кратное. </summary>
        /// <param name="numb"> RationalNumbers </param>
        /// <returns> Результат. </returns>
        private static RationalNumbers DivideByCommonMultiple(RationalNumbers numb)
        {
            for (int i = 2; i < 6; i++)
            {
                int remainder1 = numb._Numerator % i;
                int remainder2 = numb._Denomenator % i;

                if (remainder1 == 0 & remainder2 == 0)
                {
                    numb._Numerator = numb._Numerator / i;
                    numb._Denomenator = numb._Denomenator / i;
                    i = 1;
                }
            }

            return numb;
        }

        /// <summary> Получить результат вычитания. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator -(RationalNumbers numb1, RationalNumbers numb2)
        {
            if (numb1._Denomenator == numb2._Denomenator)
            {
                numb1._Numerator = numb1._Numerator - numb2._Numerator;
            }
            else
            {
                //приведение
                numb1._Numerator = numb1._Numerator * numb2._Denomenator;
                numb1._Denomenator = numb1._Denomenator * numb2._Denomenator;
                //сложение
                numb1._Numerator = numb1._Numerator - numb2._Numerator;
            }

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(numb1);

            return numb1;
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
