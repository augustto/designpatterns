using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    public class OracleConnection : DBConnection
    {
        public override bool Open()
        {
            //Console.WriteLine("Método Open de OracleConnection foi chamado");
            return true;
        }
    }
}
