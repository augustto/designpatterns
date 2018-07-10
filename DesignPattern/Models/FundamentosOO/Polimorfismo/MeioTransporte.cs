using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//quando uso polimorfismo, uso herenca tbm.

namespace Polimorfismo
{
    public abstract class MeioTransporte
    {
        public string Modelo { get; set; }
        public virtual void Mover()//mesmo nomedemetodo + comportamentos diferentes = polimorfismo  //virtual -> obria a quem herdar dar um override no método
        {
            //
        }
    }
}
