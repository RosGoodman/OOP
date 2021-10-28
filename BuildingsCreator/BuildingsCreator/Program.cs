using System;

namespace BuildingsCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building(20f, 7, 200, 6);
            Building building2 = new Building();

            Console.WriteLine(building1.BuildingNumb);
            Console.WriteLine(building2.BuildingNumb);

            Console.WriteLine(building1.GetHeightOfFloor());

            Console.ReadKey();
        }
    }
}
