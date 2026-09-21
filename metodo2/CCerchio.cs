using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo2
{
    internal class CCerchio : CPunto
    {
        private int _raggio;
        // public int raggio { get; set; }
        public CCerchio() {
            _raggio = 0;
        }
        public CCerchio(decimal x, decimal y, int raggio) : base(x,y)
        {
            if (raggio < 0)
            {
                throw new ArgumentException("Errore");
            }
            else
            {
                _raggio = raggio;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "; raggio: " + _raggio;
        }
    }
}
