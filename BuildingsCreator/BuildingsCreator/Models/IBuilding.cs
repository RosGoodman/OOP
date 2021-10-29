
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
    }
}
