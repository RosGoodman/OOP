namespace Coder
{
    public interface ICoder
    {
        /// <summary> Закодировать строку. </summary>
        /// <param name="str"> Кодируемая строка. </param>
        /// <returns> Закодированная строка. </returns>
        public string Encode(string str);
        public string Decode(string str);
    }
}