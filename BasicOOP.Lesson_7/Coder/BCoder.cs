
namespace Coder
{
    /// <summary> Класс описывающий "зеркальную" кодировку текста. </summary>
    public struct BCoder : ICoder
    {
        /// <summary> Декодировать переданную строку. </summary>
        /// <param name="str"> Строка для декодирования. </param>
        /// <returns> Результат. </returns>
        public string Decode(string str)
        {
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    newStr += str[i];
                    continue;
                }

                //вижу, что в этом месте методы очень похожи, но выделять не стал,
                //чтоб не усложнять чтение результата.

                string c = str[i].ToString();
                //нижний регистр
                if (str[i].ToString() == c.ToLower())
                {
                    int step = (int)'я' - (int)str[i];  //разница индексов
                    newStr += (char)((int)'а' + step);  //добавляем символ
                }
                //верхний регистр
                if (str[i].ToString() != c.ToLower())
                {
                    int step = (int)'Я' - (int)str[i];  //разница индексов
                    newStr += (char)((int)'А' + step);  //добавляем символ
                }
            }

            return newStr;
        }

        /// <summary> Закодировать переданную строку. </summary>
        /// <param name="str"> Строка для кодирования. </param>
        /// <returns> Результат. </returns>
        public string Encode(string str)
        {
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    newStr += str[i];
                    continue;
                }

                string c = str[i].ToString();
                //нижний регистр
                if (str[i].ToString() == c.ToLower())
                {
                    int step = (int)str[i] - (int)'а';  //разница индексов
                    newStr += (char)((int)'я' - step);  //добавляем символ
                }
                //верхний регистр
                if (str[i].ToString() != c.ToLower())
                {
                    int step = (int)str[i] - (int)'А';  //разница индексов
                    newStr += (char)((int)'Я' - step);  //добавляем символ
                }
            }

            return newStr;
        }
    }
}
