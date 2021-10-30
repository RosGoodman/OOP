using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1234567890";
            Console.WriteLine(Reverse(str));
        }

        /// <summary> Развернуть строку. </summary>
        /// <param name="str">Строка для разворота.</param>
        /// <returns>Развернутая строка.</returns>
        private static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
