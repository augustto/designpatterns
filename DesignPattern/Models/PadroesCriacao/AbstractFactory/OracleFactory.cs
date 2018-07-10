using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
  
    public class OracleFactory : DBAbstractFactory
    {
        public override DBConnection createConnection()
        {
            return new OracleConnection();
        }

        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }
    }
}
