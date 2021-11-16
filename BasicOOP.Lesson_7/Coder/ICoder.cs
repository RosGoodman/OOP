namespace Coder
{
    public interface ICoder
    {
        /// <summary> Закодировать строку. </summary>
        /// <param name="str"> Кодируемая строка. </param>
        /// <returns> Результат. </returns>
        public string Encode(string str);

        /// <summary> Декодировать строку. </summary>
        /// <param name="str"> Декодируемая строка. </param>
        /// <returns> Результат. </returns>
        public string Decode(string str);
    }
}