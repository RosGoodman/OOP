using System;
using BuildingsCreator;
using BuildingsCreator.Fctory;
using BuildingsCreator.Models;

namespace BuildingStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание и запись зданий.
            Creator<IBuilding>.CarteBuild(new ConcreteFactory(), 20, 7, 200, 6);
            Creator<IBuilding>.CarteBuild(new ConcreteFactory(), 25, 9, 230, 6);
            var foundBuild = Creator<IBuilding>.GetBuilding(1);
            var foundBuild2 = Creator<IBuilding>.GetBuilding(2);

            //расчет высоты этажей.
            Console.WriteLine($"Высота одного этажа: {foundBuild.GetHeightOfFloor()}");
            Console.WriteLine($"Высота одного этажа: {foundBuild2.GetHeightOfFloor()}");

            //получение кол-ва квартир на этаже (среднее)
            Console.WriteLine($"Количество квартир на этаже: {foundBuild.GetNumberOfApartmentInTheFloor()}");
            //получение кол-ва квартир в парадной (среднее)
            Console.WriteLine($"Количество квартир на этаже: {foundBuild.GetNumberOfApartmentsInTheEntrance()}");

            //проверка удаления зданий из хэш-таблицы
            Console.WriteLine($"Хэш-таблица содержит здание №1: {Creator<IBuilding>.Contain(1)}");
            Console.WriteLine("Удаление здания №1.");

            Creator<IBuilding>.RemoveBuilding(1);

            //foundBuild = Creator.GetBuilding(1);
            //foundBuild2 = Creator.GetBuilding(2);

            Console.WriteLine($"Хэш-таблица содержит здание №1: {Creator<IBuilding>.Contain(1)}");
            Console.WriteLine($"Хэш-таблица содержит здание №2: {Creator<IBuilding>.Contain(2)}");

            Console.Read();
        }
    }
}
