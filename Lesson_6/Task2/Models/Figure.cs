
namespace Task2.Models
{
    /// <summary> Класс описывающий фигуру. </summary>
    internal class Figure
    {
        private Colore _Colore = Colore.white;
        private bool _Visible = true;
        private int _OX;
        private int _OY;

        /// <summary> Координата оси ОХ. </summary>
        public int OX { get => _OX;}
        /// <summary> Координата оси ОУ. </summary>
        public int OY { get => _OY;}

        #region Ctors

        /// <summary> Содать экземпляр фигуры. </summary>
        public Figure() { }

        /// <summary> Содать экземпляр фигуры. </summary>
        /// <param name="colore"> Цвет. </param>
        /// <param name="hide"> Окружность скрыта (true/false). </param>
        /// <param name="ox"> Координата оси ОХ. </param>
        /// <param name="oy"> Координата оси ОУ.</param>
        public Figure(Colore colore, bool visible, int ox, int oy)
        {
            _Colore = colore;
            _Visible = visible;
            _OX = ox;
            _OY = oy;
        }

        #endregion

        #region Methods

        /// <summary> Переместить фигуру в указанном направлении. </summary>
        /// <param name="offset"> Размер шага. </param>
        /// <param name="direction"> Направление. </param>
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    _OX += offset;
                    break;
                case Direction.Left:
                    _OX -= offset;
                    break;
                case Direction.Up:
                    _OY += offset;
                    break;
                case Direction.Down:
                    _OY -= offset;
                    break;
            }
        }

        /// <summary> Изменить цвет фигуры. </summary>
        /// <param name="color"> Новый цвет фигуры. </param>
        public void ChangeColor(Colore color) => _Colore = color;

        /// <summary> Получить состояние видимости фигуры. </summary>
        /// <returns> Скрыт/показан (true/false). </returns>
        public bool IsVisible() => _Visible;

        /// <summary> Получить строку с состоянием фигуры. </summary>
        /// <returns> Строка состояние. </returns>
        public string Print()
        {
            return $"Цвет: {_Colore}, Скрыт: {_Visible}, Координата OX: {_OX}, Координата OY: {_OY}";
        }

        #endregion
    }
}
