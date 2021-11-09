﻿#nullable enable
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
            return (decimal)numb1 == (decimal)numb2;
        }

        /// <summary> Проверить неравенство двух чисел. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат проверки на неравенство.</returns>
        public static bool operator !=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1 != (decimal)numb2;
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
            return (decimal)numb1 < (decimal)numb2;
        }

        /// <summary> Проверить неравенство. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки на неравенство. </returns>
        public static bool operator >(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1 > (decimal)numb2;
        }

        #endregion

        #region <= >=

        /// <summary> Меньше либо равно. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки. </returns>
        public static bool operator <=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1 <= (decimal)numb2;
        }

        /// <summary> Больше либо равно. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns> Результат проверки. </returns>
        public static bool operator >=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (decimal)numb1 >= (decimal)numb2;
        }

        #endregion

        #region +-

            #region RationalNumb

        /// <summary> Получить результат сложения. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator +(RationalNumbers numb1, RationalNumbers numb2)
        {
            RationalNumbers newNumb = numb1;
            RationalNumbers added = numb2;
            if(numb1._Denomenator == numb2._Denomenator)
            {
                newNumb._Numerator += numb2._Numerator;
            }
            else
            {
                //приведение к общему знаменателю
                newNumb._Numerator *= numb2._Denomenator;
                newNumb._Denomenator *= numb2._Denomenator;
                added._Numerator *= numb1._Denomenator;
                added._Denomenator *= numb1._Denomenator;
                //сложение
                newNumb._Numerator += added._Numerator;
            }

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(newNumb);

            return newNumb;
        }

        /// <summary> Получить результат вычитания. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Рациональное число.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator -(RationalNumbers numb1, RationalNumbers numb2)
        {
            RationalNumbers newNumb = numb1;
            RationalNumbers added = numb2;
            if (numb1._Denomenator == numb2._Denomenator)
            {
                newNumb._Numerator -= numb2._Numerator;
            }
            else
            {
                //приведение
                newNumb._Numerator *= numb2._Denomenator;
                newNumb._Denomenator *= numb2._Denomenator;
                added._Numerator *= numb1._Denomenator;
                added._Denomenator *= numb1._Denomenator;
                //сложение
                newNumb._Numerator -= added._Numerator;
            }

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(newNumb);

            return newNumb;
        }

        #endregion

            #region Int

        /// <summary> Получить результат сложения. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator +(RationalNumbers numb1, int numb2)
        {
            RationalNumbers newNumb = numb1 + GetToFractionalNumb(numb2);

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(newNumb);

            return newNumb;
        }

        /// <summary> Получить результат вычитания. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Int.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator -(RationalNumbers numb1, int numb2)
        {
            RationalNumbers newNumb = numb1 - GetToFractionalNumb(numb2);

            //деление числителя и знаменателя на общее кратное.
            DivideByCommonMultiple(newNumb);

            return newNumb;
        }

        #endregion

            #region float

        /// <summary> Получить результат сложения. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator +(RationalNumbers numb1, float numb2)
        {
            float resultFloat = (float)numb1 + numb2;

            return GetToFractionalNumb((decimal)resultFloat);
        }

        /// <summary> Получить результат вычитания. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Float.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator -(RationalNumbers numb1, float numb2)
        {
            float resultFloat = (float)numb1 - numb2;

            return GetToFractionalNumb((decimal)resultFloat);
        }

        #endregion

            #region decimal

        /// <summary> Получить результат сложения. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator +(RationalNumbers numb1, decimal numb2)
        {
            return GetToFractionalNumb((decimal)numb1 + numb2);
        }

        /// <summary> Получить результат вычитания. </summary>
        /// <param name="numb1">Рациональное число.</param>
        /// <param name="numb2">Decimal.</param>
        /// <returns>Результат.</returns>
        public static RationalNumbers operator -(RationalNumbers numb1, decimal numb2)
        {
            return GetToFractionalNumb((decimal)numb1 - numb2);

        }

        #endregion

        #endregion

        #region ++ --

        /// <summary> Получить инкремент RationalNumber. </summary>
        /// <param name="numb1"> RationalNumber. </param>
        /// <returns> RationalNumber. </returns>
        public static RationalNumbers operator ++(RationalNumbers numb1)
        {
            return new RationalNumbers(numb1._Numerator + numb1._Denomenator, numb1._Denomenator);
        }

        /// <summary> Получить декремент RationalNumber. </summary>
        /// <param name="numb1"> RationalNumber. </param>
        /// <returns> RationalNumber. </returns>
        public static RationalNumbers operator --(RationalNumbers numb1)
        {

            return new RationalNumbers(numb1._Numerator - numb1._Denomenator, numb1._Denomenator);
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

        /// <summary> Преобразовать RationalNumber в Int. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static explicit operator int(RationalNumbers numb)
        {
            return Convert.ToInt32(numb._Numerator / numb._Denomenator);
        }

        /// <summary> Преобразовать RationalNumber в Float. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static explicit operator float(RationalNumbers numb)
        {
            return (float)numb._Numerator / numb._Denomenator;
        }

        /// <summary> Преобразовать RationalNumber в Decimal. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static explicit operator decimal(RationalNumbers numb)
        {
            return (decimal)numb._Numerator / numb._Denomenator;
        }

        #endregion

        #region Auxiliary methods

        /// <summary> Разделить числитель и знаменатель на общее кратное. </summary>
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

        /// <summary> Получить RationalNumber из числа с плавающей точкой. </summary>
        /// <param name="numb"> Число с плавающей точкой. </param>
        /// <returns> RationalNumber. </returns>
        public static RationalNumbers GetToFractionalNumb(decimal numb)
        {
            int divisor = 1;
            //увеличение числа до целого с получением делителя
            while(numb % 1 != 0)
            {
                numb *= 10;
                divisor *= 10;
            }

            //абсолютное значение (math.abs) на случай, если преобразуемое число отрицательное.
            int k = Math.Abs(GetCommonDivider((int)numb, divisor));
            return new RationalNumbers((int)numb / k, divisor / k);
        }

        /// <summary> Получить общий делитель двух целых чисел. </summary>
        /// <param name="a"> Число 1. </param>
        /// <param name="b"> Число 2. </param>
        /// <returns> Общий делитель. </returns>
        static int GetCommonDivider(int a, int b)
        {
            return b == 0 ? a : GetCommonDivider(b, a % b);
        }

        #endregion
    }
}
