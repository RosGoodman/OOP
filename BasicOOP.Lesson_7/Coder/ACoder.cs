
namespace Coder
{
    /// <summary> Класс описывающий кодировку текста сдвигом. </summary>
    public struct ACoder : ICoder
    {
        /// <summary> Закодировать переданную строку. </summary>
        /// <param name="str"> Кодируемая строка. </param>
        /// <returns> Результат. </returns>
        public string Encode(string str)
        {
            return ChangeCharsTowards(str, true);
        }

        /// <summary> Декодировать переданную строку. </summary>
        /// <param name="str"> Декодируемая строка. </param>
        /// <returns> Результат. </returns>
        public string Decode(string str)
        {
            return ChangeCharsTowards(str, false);
        }

        /// <summary> Сдвитнуть символы "вдоль" алфавита в указанную сторону. </summary>
        /// <param name="str"> Изменяемая строка. </param>
        /// <param name="toTheEnd"> Сдвигать символы в конец (true/false). </param>
        /// <returns> Результат. </returns>
        private string ChangeCharsTowards(string str, bool toTheEnd)
        {
            int coeff = toTheEnd ? 1 : -1;
            string encodeStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                encodeStr += (char)((int)str[i] + coeff);
            }
            return encodeStr;
        }
    }
}
