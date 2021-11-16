
namespace Task2.Models
{
    /// <summary> Класс описывающий точку. </summary>
    class Point : Figure
    {
        /// <summary> Содать экземпляр точки. </summary>
        /// <param name="colore"> Цвет. </param>
        /// <param name="visible"> Окружность скрыта (true/false). </param>
        /// <param name="ox"> Координата оси ОХ. </param>
        /// <param name="oy"> Координата оси ОУ.</param>
        public Point(Colore colore, bool visible, int ox, int oy) :
            base(colore, visible, ox, oy)
        {

        }
    }
}
