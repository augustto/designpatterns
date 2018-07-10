using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Target
    {   
        public virtual string Request()
        {
            return "Método Request de Target chamado";
        }
    }
}
