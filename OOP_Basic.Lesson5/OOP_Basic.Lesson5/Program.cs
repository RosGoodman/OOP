using System;

namespace OOP_Basic.Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //К сожалению при попытке проверять написанное тут возникало много ошибок, 
            //по этому написал тесты.
            RationalNumbers n1 = new RationalNumbers(1, 2) % new RationalNumbers(1, 3);

            Console.Read();
        }

    }
}
