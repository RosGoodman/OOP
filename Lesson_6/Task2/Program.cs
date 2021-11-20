using System;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(Colore.green, true, 1, 1);
            Circle circle = new Circle(Colore.red, true, 2, 2, 13);
            Rectangle rectangle = new Rectangle(Colore.red, true, 3, 4, 34, 15);

            Console.WriteLine($"Информация о figure: {figure.Print()}");
            Console.WriteLine($"Информация о circle: {circle.Print()}");
            Console.WriteLine($"Информация о rectangle: {rectangle.Print()}");

            //движение
            for (int i = 0; i < 4; i++)
            {
                figure.Move(2, Direction.Right);
                Console.WriteLine($"Текущие координаты: {figure.OX}, {figure.OY}");
                circle.Move(3, Direction.Left);
                Console.WriteLine($"Текущие координаты: {circle.OX}, {circle.OY}");
                rectangle.Move(4, Direction.Down);
                Console.WriteLine($"Текущие координаты: {rectangle.OX}, {rectangle.OY}");
            }

            Console.Read();
            
        }
    }
}
