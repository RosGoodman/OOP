
namespace BuildingsCreator.Models
{
    public interface IBuilding
    {
        private static int _LastNumb;

        /// <summary> Номер здания. </summary>
        public int BuildingNumb { get; set; }

        /// <summary> Получить высоту этажа. </summary>
        /// <returns> Высота этажа. </returns>
        public float GetHeightOfFloor();

        /// <summary> Сгенерировать уникальный номер дома. </summary>
        /// <returns> Номер дома. </returns>
        public static int GenerateBuildNumb() => ++_LastNumb;

        /// <summary> Получить кол-во квартир в парадной (среднее). </summary>
        /// <returns> Кол-во квартир в парадной. </returns>
        public int GetNumberOfApartmentsInTheEntrance();

        /// <summary> Получить кол-во квартир на этаже (среднее). </summary>
        /// <returns> Кол-во квартир на этаже. </returns>
        public int GetNumberOfApartmentInTheFloor();
    }
}
