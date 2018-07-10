using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    public class SQLConnection:DBConnection
    {
        public override bool Open()
        {
            return true;
        }
    }
}
