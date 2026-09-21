using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18092026
{
    internal class CCilindro
    {
        private CCerchio _cerchio;
        private decimal _altezza;

        public CCerchio cerchio { get; set; }
        public decimal altezza { get; set; }

        public CCilindro()
        {
            _cerchio = new CCerchio();
            _altezza = 0;
        }

        public CCilindro(decimal h, CCerchio b)
        {
            _cerchio = b;
            if (h < 0)
            {
                throw new ArgumentException("Errore");
            }
            else
            {
                _altezza = h;
            }
        }

        public CCilindro(decimal posx, decimal posy, decimal r, decimal h)
        {
            _cerchio.centro.x = posx;
            _cerchio.centro.y = posy;
            _cerchio.raggio = r;
            if (h < 0)
            {
                throw new ArgumentException("Errore");
            }
            else
            {
                _altezza = h;
            }
        }

        public override string ToString()
        {
            return _cerchio.ToString() + "; altezza: " + _altezza;
        }
    }
}
