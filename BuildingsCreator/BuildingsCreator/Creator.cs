
using BuildingsCreator.HashTable;
using System.Collections.Generic;

namespace BuildingsCreator
{
    class Creator<T>
    {
        private static HashTable<T> _HashTable;
        public string Key { get; private set; }

        public T Value { get; private set; }

        public Creator() { CreateHashTable(100); }

        public static Building CarteBuild(int bHeight, int floorCount, int apartCount, int entrancesCount)
        {
            Building building = new Building(bHeight, floorCount, apartCount, entrancesCount);
            CreateHashTable(100);   //для установки размера можно добавить переменную

            //_HashTable.
            return null;
        }

        public static List<T> GetBuilding(int item)
        {
            return null;// _HashTable.Get(item);
        }

        private static void CreateHashTable(int size)
        {
            if (_HashTable == null)
                _HashTable = new HashTable<T>(size);
        }
    }
}
