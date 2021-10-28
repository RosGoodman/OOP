
namespace BuildingsCreator
{
    class Building
    {
        private static int _LastNumb;

        public int _BuildingNumb;
        private float _BuildingHeight;
        private int _NumbOfFloors = 1;
        private int _NumbOfApartment;
        private int _NumbOfEntrances;

        #region Properties

        public int BuildingNumb
        {
            get => _BuildingNumb;
            private set => _BuildingNumb = value;
        }

        public float BuildingHeight
        {
            get => _BuildingHeight;
            private set => _BuildingHeight = value;
        }

        public int NumbOfFloors
        {
            get => _NumbOfFloors;
            private set => _NumbOfFloors = value;
        }

        public int NumbOfApartment
        {
            get => _NumbOfApartment;
            private set => _NumbOfApartment = value;
        }

        public int NumbOfEntrances
        {
            get => _NumbOfEntrances;
            private set => _NumbOfEntrances = value;
        }

        #endregion

        #region Ctors

        public Building()
        {
            BuildingNumb = GenerateBuildNumb();
        }

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

        public float GetHeightOfFloor()
        {
            //отрицательные. Вдруг кто-то захочет жить под землей...¯\_(ツ)_/¯
            if (_BuildingHeight != 0)
                return _BuildingHeight / _NumbOfFloors;
            else return 0;
        }

        public static int GenerateBuildNumb() => ++_LastNumb;

        #endregion
    }
}
