using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18092026
{
    internal class CPunto
    {
        private decimal _x;
        private decimal _y;
        public decimal x { get; set; }
        public decimal y { get; set; }
        public CPunto()
        {
            _x = 0;
            _y = 0;
        }
        public CPunto(decimal posx, decimal posy) 
        {
            _x = posx;
            _y = posy;
        }

        public override string ToString()
        {
            return "x: " + _x + "; y: " + _y;
        }
    }
}
