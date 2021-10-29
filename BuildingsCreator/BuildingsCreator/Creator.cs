using BuildingsCreator.Fctory;
using BuildingsCreator.HashTable;
using BuildingsCreator.Models;

namespace BuildingsCreator
{
    public class Creator
    {
        private static HashTable<IBuilding> _HashTable;
        private static IBuilding _Building;

        private Creator() { }

        #region CreatorMethods

        /// <summary> Создать экземпляр класса Creator. </summary>
        /// <param name="factory"> Абстрактная фабрика. </param>
        /// <param name="bHeight"> Высота здания. </param>
        /// <param name="floorCount"> Количество этажей. </param>
        /// <param name="apartCount"> Кол-во квартир. </param>
        /// <param name="entrancesCount"> Кол-во подъездов. </param>
        public static void CarteBuild(IAbstractFactory factory, int bHeight, int floorCount, int apartCount, int entrancesCount)
        {
            _Building = factory.CreateBuilding(bHeight, floorCount, apartCount, entrancesCount);
            CreateHashTable(100);
            HashTable<IBuilding>.Add(_Building, _Building.BuildingNumb);
        }

        /// <summary> Получить здание по номеру. </summary>
        /// <param name="numbBuild"> Номер здания. </param>
        /// <returns> Найденное здание. </returns>
        public static IBuilding GetBuilding(int numbBuild)
        {
            return HashTable<IBuilding>.Get(numbBuild);
        }

        /// <summary> Проверить существование здания по номеру. </summary>
        /// <param name="numbBuild"> Номер здания. </param>
        /// <returns> True - существует, false - не сучествует. </returns>
        public static bool Contain(int numbBuild)
        {
            return HashTable<IBuilding>.Search(numbBuild);
        }

        /// <summary> Удалить здание по номеру. </summary>
        /// <param name="numbBuild"> Номер здания. </param>
        public static void RemoveBuilding(int numbBuild)
        {
            HashTable<IBuilding>.Delete(numbBuild);
        }

        /// <summary> Создать Хэш-таблицу. </summary>
        /// <param name="size"> Размер таблицы. </param>
        private static void CreateHashTable(int size)
        {
            if (_HashTable == null)
                _HashTable = new HashTable<IBuilding>(size);
        }

        #endregion
    }
}
