using System;

namespace OOP_Basic.Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers numb = new RationalNumbers(123, 5);

            Console.WriteLine(numb.ToString());

            Console.Read();
        }
    }
}
