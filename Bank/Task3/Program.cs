using System;
using System.IO;

namespace Task3
{
    class Program
    {
        /// <summary> Получить адрес почты. </summary>
        /// <param name="s">Строка для поиска адресов.</param>
        /// <returns>Адрес почты.</returns>
        delegate string Separator(ref string s);

        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "\\data";
            string readFileName = "\\UsersData.txt";
            string writeFileName = "\\mails.txt";

            Separator sep = SeparateEmails;

            using (StreamReader sr = new StreamReader(new BufferedStream(File.OpenRead(path + readFileName), 10 * 1024 * 1024)))

            WriteInFaleTXT(sr, path + writeFileName, sep);
        }

        /// <summary> Записать текст в файл. </summary>
        /// <param name="sr">StreamReader</param>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="sep">Метод, обрабытывающий строку.</param>
        static void WriteInFaleTXT(StreamReader sr, string path, Separator sep)
        {
            string line = string.Empty;
            try
            {
                using (StreamWriter sw = new StreamWriter(new BufferedStream(File.OpenWrite(path), 10*1024*1024)))
                {
                    while((line = sr.ReadLine()) != null)
                    {
                        //тут можно было просто вызывать метод SeparateEmails(line),
                        //но мне почему-то не понтарвилось, оставил с делегатом
                        sw.WriteLine(sep(ref line));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary> Получить адрес почты. </summary>
        /// <param name="s">Строка для поиска адресов.</param>
        /// <returns>Адрес почты.</returns>
        static string SeparateEmails(ref string s)
        {
            return s.Split(" & ")[1];
        }
    }
}
