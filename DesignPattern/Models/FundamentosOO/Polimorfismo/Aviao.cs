using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Aviao: MeioTransporte
    {
        public override void Mover()
        {
            Console.WriteLine(Modelo + " voando...");
        }
    }
}
