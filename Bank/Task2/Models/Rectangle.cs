
namespace Task2.Models
{
    class Rectangle : Point
    {
        private int _Height;
        private int _Width;

        public Rectangle(Colore colore, bool hide, int ox, int oy, int height, int width) :
            base(colore, hide, ox, oy)
        {
            _Height = height;
            _Width = width;
        }

        public double GetArea() => _Height * _Width;
    }
}
