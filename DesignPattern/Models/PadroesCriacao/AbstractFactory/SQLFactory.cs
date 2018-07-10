using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{

    public class SQLFactory: DBAbstractFactory
    {
        public override DBConnection createConnection()
        {   
            return new SQLConnection();
        }

        public override DBCommand createCommand()
        {
            return new SQLCommand();
    }
}
