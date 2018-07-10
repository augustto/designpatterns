using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SQLCommand:DBCommand
    {
        public override bool Execute()
        {
            return true;
        }
    }
}
