
namespace Task2.Models
{
    class Figure
    {
        private Colore _Colore = Colore.white;
        private bool _Hide = true;
        private int _OX;
        private int _OY;

        #region Properties

        public Colore Colore
        {
            get => _Colore;
            set => _Colore = value;
        }
        
        public bool Hide
        {
            get => _Hide;
            set => _Hide = value;
        }
        
        public int OX
        {
            get => _OX;
            set => _OX = value;
        }
        
        public int OY
        {
            get => _OY;
            set => _OY = value;
        }

        #endregion

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


    }
}
