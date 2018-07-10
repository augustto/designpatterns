using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Carro: MeioTransporte
    {
        public string Marca;
        
        public override void Mover()
        {
            Console.WriteLine(Modelo + " andando...");
        }
    }
}
