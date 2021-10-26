using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "\\data";
            string mails = string.Empty;

            string line = ReadFileTXT($"{path}\\UsersData.txt");
            string[] words = line.Split(' ');

            //получение строки с почтой
            foreach(string mail in words)
            {
                if (SeparateEmails(mail) != string.Empty)
                    mails += " " + mail;
            }

            //запись в новый файл
            WriteInFaleTXT(mails, $"{path}\\mails.txt");

            Console.ReadLine();
        }

        /// <summary> Записать текст в файл. </summary>
        /// <param name="mails">Текст для записи.</param>
        /// <param name="path">Путь к файлу.</param>
        static void WriteInFaleTXT(string mails, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(mails);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary> Прочитать текст из файла. </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Текст из файла.</returns>
        static string ReadFileTXT(string path)
        {
            string line = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    line = sr.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return line;
        }

        /// <summary> Получить адрес почты. </summary>
        /// <param name="s">Строка для поиска адресов.</param>
        /// <returns>Адрес почты или пустая строка.</returns>
        static string SeparateEmails(string s)
        {
            if (s.Contains('@'))
                return s;
            else
                return string.Empty;
        }
    }
}
