
namespace Task2.Models
{
    /// <summary> Класс описывающий точку. </summary>
    class Point : Figure
    {
        /// <summary> Содать экземпляр точки. </summary>
        /// <param name="colore"> Цвет. </param>
        /// <param name="hide"> Окружность скрыта (true/false). </param>
        /// <param name="ox"> Координата оси ОХ. </param>
        /// <param name="oy"> Координата оси ОУ.</param>
        public Point(Colore colore, bool hide, int ox, int oy) :
            base(colore, hide, ox, oy)
        {

        }
    }
}
