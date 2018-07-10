using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DataSetConcreteDecorator : DataSetDecorator
    {
        public override string Write()
        {
              this._basedataset.Write();
            return "Método DataSetConcreteDecorator.Write() invocado";
        }

        // decorando novas funcionalidades
        public string WriteXML()
        {
            return "Método DataSetConcreteDecorator.WriteXML() invocado";
        }
    }
}
