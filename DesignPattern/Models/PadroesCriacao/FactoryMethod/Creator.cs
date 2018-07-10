using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Creator - define o Factory Method abstrato
    public abstract class Creator
    {
        public abstract Autenticacao CreateInstance();
    }
}
