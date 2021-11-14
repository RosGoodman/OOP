
namespace Task2.Models
{
    /// <summary> Класс описывающий прямоугольник. </summary>
    class Rectangle : Point
    {
        private int _Height;
        private int _Width;

        /// <summary> Содать экземпляр прямоугольника. </summary>
        /// <param name="colore"> Цвет. </param>
        /// <param name="hide"> Окружность скрыта (true/false). </param>
        /// <param name="ox"> Координата оси ОХ. </param>
        /// <param name="oy"> Координата оси ОУ.</param>
        /// <param name="height"> Высота прямоугольника. </param>
        /// <param name="width"> Ширина прямоугольника. </param>
        public Rectangle(Colore colore, bool hide, int ox, int oy, int height, int width) :
            base(colore, hide, ox, oy)
        {
            _Height = height;
            _Width = width;
        }

        /// <summary> Получить площадь рпямоугольника. </summary>
        /// <returns> Площадь прямоугольника. </returns>
        public double GetArea() => _Height * _Width;
    }
}
