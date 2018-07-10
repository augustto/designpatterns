using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Proxy
    public class CalcProxy : ICalc
    {
        // RealSubject
        private Calc _calc;//composicao
        public int Somar(int x, int y)
        {
            // instancia por demanda (lazy)
            if (_calc == null)
            {
                _calc = new Calc();

            }

            // repassando a chamada ao RealSubject
            return _calc.Somar(x, y);
        }
    }
}
