using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // RealSubject
    public class Calc : Proxy.ICalc
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
