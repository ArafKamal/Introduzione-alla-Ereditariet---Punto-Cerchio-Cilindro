using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18092026
{
    internal class CCerchio
    {
        private CPunto _centro;
        private decimal _raggio;

        public CPunto centro { get; set; }
        public decimal raggio { get; set; }

        public CCerchio()
        {
            _centro = new CPunto();
            _raggio = 0;
        }

        public CCerchio(CPunto p, decimal r)
        {
            _centro = p;
            _raggio = r;
        }

        public CCerchio(decimal posx, decimal posy, decimal r)
        {
            _centro.x = posx;
            _centro.y = posy;
            _raggio = r;
        }

        public override string ToString()
        {
            return _centro.ToString() + "; raggio: " + _raggio;
        }
    }
}
