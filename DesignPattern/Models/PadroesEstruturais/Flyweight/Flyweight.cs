using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class Flyweight
    {
        public abstract string Operation(int ext);//representa os dados extrinseco (aqueles que não podem ser compartilhados entre as instancias)
    }
}
