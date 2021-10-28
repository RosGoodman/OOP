using BuildingsCreator.HashTable;
using System;

namespace BuildingsCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator<Building> creator = new Creator<Building>();
            Creator<Building>.CarteBuild(20, 7, 200, 6);
            var foundBuild = Creator<Building>.GetBuilding(1);

            //Console.WriteLine(foundBuild.GetHeightOfFloor());

            Console.Read();
        }
    }
}
