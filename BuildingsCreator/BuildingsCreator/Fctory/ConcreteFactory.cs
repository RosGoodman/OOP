
using BuildingsCreator.Models;

namespace BuildingsCreator.Fctory
{
    public class ConcreteFactory : IAbstractFactory
    {
        /// <summary> Создать здание. </summary>
        /// <param name="bHeight"> Высота здания. </param>
        /// <param name="floorsCoun"> Кол-во этажей. </param>
        /// <param name="apartCount"> Кол-во квартир. </param>
        /// <param name="entrancesCount"> Кол-во подъездов. </param>
        /// <returns> Экземпляр класса Building. </returns>
        public IBuilding CreateBuilding(float bHeight, int floorsCoun, int apartCount, int entrancesCount)
        {
            return new Building(bHeight, floorsCoun, apartCount, entrancesCount);
        }
    }
}
