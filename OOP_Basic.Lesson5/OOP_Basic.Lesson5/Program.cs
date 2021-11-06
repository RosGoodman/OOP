using System;

namespace OOP_Basic.Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //преобразуемые в целое
            RationalNumbers numb3 = new RationalNumbers(120, 5);
            RationalNumbers numb4 = new RationalNumbers(120, 5);
            RationalNumbers numb5 = new RationalNumbers(30, 6);

            //не преобразуемые в целое
            RationalNumbers numb = new RationalNumbers(123, 5);
            RationalNumbers numb1 = new RationalNumbers(123, 5);
            RationalNumbers numb2 = new RationalNumbers(123, 2);

            Console.WriteLine("равенство рациональных");
            Console.WriteLine(numb == numb1);
            Console.WriteLine(numb2 == numb1);

            PrintLine();

            Console.WriteLine("неравенство рациональных");
            Console.WriteLine(numb != numb1);
            Console.WriteLine(numb2 != numb1);

            PrintLine();

            Console.WriteLine("Equals");
            Console.WriteLine(numb.Equals(numb1));
            Console.WriteLine(numb.Equals(numb2));
            Console.WriteLine(numb.Equals(numb3));
            Console.WriteLine(numb.Equals(numb5));

            PrintLine();

            Console.WriteLine(numb.ToString());

            Console.Read();
        }

        private static void PrintLine()
        {
            Console.WriteLine("_____________________________");
        }
    }
}
