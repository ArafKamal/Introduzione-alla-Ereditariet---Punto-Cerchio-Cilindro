using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo2
{
    internal class CCilindro : CCerchio
    {
        private int _altezza;
        // public int altezza { get; set; }
        public CCilindro() : base()
        {
            _altezza = 0;
        }
        public CCilindro(int posx, int posy, int r, int altezza) : base(posx, posy, r) 
        {
            altezza = _altezza;
        }
        public override string ToString()
        {
            return base.ToString() + "; raggio: " + _altezza;
        }
    }
}
