
namespace Task2.Models
{
    class Figure
    {
        private Colore _Colore = Colore.white;
        private bool _Hide = true;
        private int _OX;
        private int _OY;

        public int OX { get => _OX;}
        public int OY { get => _OY;}

        #region Ctors

        public Figure() { }

        public Figure(Colore colore, bool hide, int ox, int oy)
        {
            _Colore = colore;
            _Hide = hide;
            _OX = ox;
            _OY = oy;
        }

        #endregion

        #region Methods

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

        public void ChangeColor(Colore color) => _Colore = color;

        public bool IsVisible() => _Hide;

        public string Print()
        {
            return $"Цвет: {_Colore}, Скрыт: {_Hide}, Координата OX: {_OX}, Координата OY: {_OY}";
        }

        #endregion
    }
}
