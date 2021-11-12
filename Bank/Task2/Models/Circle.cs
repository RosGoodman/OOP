
namespace Task2.Models
{
    class Circle : Point
    {
        private int _Radius;

        public int Radius { get; set; }

        public Circle(Colore colore, bool hide, int ox, int oy, int radius) :
            base(colore, hide, ox, oy)
        {
            _Radius = radius;
        }

        public double GetArea() => 3.14 * _Radius * _Radius; 
    }
}
