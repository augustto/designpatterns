using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    // Concrete Component
    public class DataSet : BaseDataSet
    {
        public override string Write()
        {
            // salvar dados do dataset
           return "Método DataSet.Write() invocado";
        }
    }
}
