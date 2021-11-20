#nullable enable
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
            if (num == 0) den = 0;
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
                (newNumb, added) = LeadToACommonDenominator(numb1, numb2);
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
                (newNumb, added) = LeadToACommonDenominator(numb1, numb2);
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

            #region %

        /// <summary> Получить остаток от деления (округление до 6 знаков после запятой). </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> RationalNumbers. </param>
        /// <returns> Остаток от деления. </returns>
        public static RationalNumbers operator %(RationalNumbers numb1, RationalNumbers numb2)
        {
            decimal remains = (decimal)numb1 % (decimal)numb2;
            if (numb1 < numb2) remains *= numb1._Denomenator;

            RationalNumbers newRational = new RationalNumbers((int)remains, numb1._Denomenator);
                
            return DivideByCommonMultiple(newRational);
        }

        /// <summary> Получить остаток от деления (округление до 6 знаков после запятой). </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Int. </param>
        /// <returns> Остаток от деления. </returns>
        public static RationalNumbers operator %(RationalNumbers numb1, int numb2)
        {
            RationalNumbers newRatNumb = GetToFractionalNumb(numb2);
            return numb1 % newRatNumb;
        }

        /// <summary> Получить остаток от деления (округление до 6 знаков после запятой). </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Float. </param>
        /// <returns> Остаток от деления. </returns>
        public static RationalNumbers operator %(RationalNumbers numb1, float numb2)
        {
            RationalNumbers newRatNumb = GetToFractionalNumb((decimal)numb2);
            return numb1 % newRatNumb;
        }

        /// <summary> Получить остаток от деления (округление до 6 знаков после запятой). </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Decimal. </param>
        /// <returns> Остаток от деления. </returns>
        public static RationalNumbers operator %(RationalNumbers numb1, decimal numb2)
        {
            RationalNumbers newRatNumb = GetToFractionalNumb(numb2);
            return numb1 % newRatNumb;
        }

        #endregion

            #region *

        /// <summary> Уманожить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> RationalNumbers. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator *(RationalNumbers numb1, RationalNumbers numb2)
        {
            RationalNumbers newRational = new RationalNumbers(numb1._Numerator * numb2._Numerator, numb1._Denomenator * numb2._Denomenator);
            return DivideByCommonMultiple(newRational);
        }

        /// <summary> Уманожить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Int. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator *(RationalNumbers numb1, int numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb(numb2);
            return numb1 * newRational;
        }

        /// <summary> Уманожить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Float. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator *(RationalNumbers numb1, float numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb((decimal)numb2);
            return numb1 * newRational;
        }

        /// <summary> Уманожить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Decimal. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator *(RationalNumbers numb1, decimal numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb(numb2);
            return numb1 * newRational;
        }

        #endregion

            #region /

        /// <summary> Разделить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> RationalNumbers. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator /(RationalNumbers numb1, RationalNumbers numb2)
        {
            RationalNumbers newRational = new RationalNumbers(numb1._Numerator * numb2._Denomenator, numb1._Denomenator * numb2._Numerator);
            return DivideByCommonMultiple(newRational);
        }

        /// <summary> Разделить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Int. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator /(RationalNumbers numb1, int numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb(numb2);
            return numb1 / newRational;
        }

        /// <summary> Разделить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Float. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator /(RationalNumbers numb1, float numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb((decimal)numb2);
            return numb1 / newRational;
        }

        /// <summary> Разделить два числа. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> Decimal. </param>
        /// <returns> RationalNumbers. </returns>
        public static RationalNumbers operator /(RationalNumbers numb1, decimal numb2)
        {
            RationalNumbers newRational = GetToFractionalNumb(numb2);
            return numb1 / newRational;
        }

            #endregion

        #endregion

        #region GetHashCode

        /// <summary> Получить хэш-код RationalNumber. </summary>
        /// <returns> Hash-code </returns>
        public override int GetHashCode()
        {
            return _Numerator.GetHashCode();
        }

        #endregion

        #region toString

        /// <summary> Получить строчный вариант данных RationalNumber. </summary>
        /// <returns> String. </returns>
        public override string ToString()
        {
            string str = String.Format(@"{0}/{1}", _Numerator, _Denomenator);
            return str;
        }

        #endregion

        #region Convert to

        /// <summary> Преобразовать RationalNumber в Int. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static implicit operator int(RationalNumbers numb)
        {
            if (numb._Numerator == 0) return 0;
            return Convert.ToInt32(numb._Numerator / numb._Denomenator);
        }

        /// <summary> Преобразовать RationalNumber в Float. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static implicit operator float(RationalNumbers numb)
        {
            if (numb._Numerator == 0) return 0;
            return (float)numb._Numerator / numb._Denomenator;
        }

        /// <summary> Преобразовать RationalNumber в Decimal. </summary>
        /// <param name="numb"> RationalNumber. </param>
        public static implicit operator decimal(RationalNumbers numb)
        {
            if (numb._Numerator == 0) return 0;
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
        private static RationalNumbers GetToFractionalNumb(decimal numb)
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
        private static int GetCommonDivider(int a, int b)
        {
            return b == 0 ? a : GetCommonDivider(b, a % b);
        }

        /// <summary> Получить два рациональных числа с общим знаменателем. </summary>
        /// <param name="numb1"> RationalNumbers. </param>
        /// <param name="numb2"> RationalNumbers. </param>
        /// <returns> Result (tuple). </returns>
        private static (RationalNumbers, RationalNumbers) LeadToACommonDenominator(RationalNumbers numb1, RationalNumbers numb2)
        {
            RationalNumbers newNumb = numb1;
            RationalNumbers added = numb2;
            //перемножение дроби на делитель другой дроби.
            newNumb._Numerator *= numb2._Denomenator;
            newNumb._Denomenator *= numb2._Denomenator;
            added._Numerator *= numb1._Denomenator;
            added._Denomenator *= numb1._Denomenator;

            return (newNumb, added);
        }

        #endregion
    }
}
