
namespace Task2.Models
{
    /// <summary> Класс описывающий окружность. </summary>
    class Circle : Point
    {
        private int _Radius;

        /// <summary> Радиус окружности. </summary>
        public int Radius { get; set; }

        /// <summary> Создать экземпляр окружности. </summary>
        /// <param name="colore"> Цвет. </param>
        /// <param name="hide"> Окружность скрыта (true/false). </param>
        /// <param name="ox"> Координата оси ОХ. </param>
        /// <param name="oy"> Координата оси ОУ.</param>
        /// <param name="radius"> Радиус окружности. </param>
        public Circle(Colore colore, bool hide, int ox, int oy, int radius) :
            base(colore, hide, ox, oy)
        {
            _Radius = radius;
        }

        /// <summary> Получить площадь окружности. </summary>
        /// <returns> Площадь окружности. </returns>
        public double GetArea() => 3.14 * _Radius * _Radius; 
    }
}
