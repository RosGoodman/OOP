
using BuildingsCreator.Models;

namespace BuildingsCreator
{
    /// <summary> Класс описывающий здание. </summary>
    class Building : IBuilding
    {
        private static int _LastNumb;

        public int _BuildingNumb;
        private float _BuildingHeight;
        private int _NumbOfFloors = 1;
        private int _NumbOfApartment;
        private int _NumbOfEntrances;

        #region Properties

        /// <summary> Номер здания. </summary>
        public int BuildingNumb
        {
            get => _BuildingNumb;
            set => _BuildingNumb = value;
        }

        /// <summary> Высота здания. </summary>
        public float BuildingHeight
        {
            get => _BuildingHeight;
            private set => _BuildingHeight = value;
        }

        /// <summary> Кол-во этажей. </summary>
        public int NumbOfFloors
        {
            get => _NumbOfFloors;
            private set => _NumbOfFloors = value;
        }

        /// <summary> Кол-во квартир. </summary>
        public int NumbOfApartment
        {
            get => _NumbOfApartment;
            private set => _NumbOfApartment = value;
        }

        /// <summary> Кол-во подъездов. </summary>
        public int NumbOfEntrances
        {
            get => _NumbOfEntrances;
            private set => _NumbOfEntrances = value;
        }

        #endregion

        #region Ctors

        private Building() { }

        /// <summary> Создать экземпляп класса Building. </summary>
        /// <param name="bHeight"> Высота здания. </param>
        /// <param name="floorsCount"> Кол-во этажей. </param>
        /// <param name="apartCount"> Кол-во квартир. </param>
        /// <param name="entrancesCount"> Кол-во подъездов. </param>
        public Building(float bHeight, int floorsCount, int apartCount, int entrancesCount)
        {
            BuildingNumb = GenerateBuildNumb();
            BuildingHeight = bHeight;
            _NumbOfFloors = floorsCount;
            _NumbOfApartment = apartCount;
            _NumbOfEntrances = entrancesCount;
        }

        #endregion

        #region Methods

        /// <summary> Получить высоту одного этажа. </summary>
        /// <returns> Высота этажа. </returns>
        public float GetHeightOfFloor()
        {
            //отрицательные. Вдруг кто-то захочет жить под землей...¯\_(ツ)_/¯
            if (_BuildingHeight != 0)
                return _BuildingHeight / _NumbOfFloors;
            else return 0;
        }

        /// <summary> Получить уникальный номер здания. </summary>
        /// <returns> Номер здания. </returns>
        public static int GenerateBuildNumb() => ++_LastNumb;

        #endregion
    }
}
