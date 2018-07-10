using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Abstract Product
    public abstract class DBConnection
    {
        public abstract bool Open();
    }
}
