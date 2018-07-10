using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    //decorator
    public class DataSetDecorator : BaseDataSet // herança
    {
        protected BaseDataSet _basedataset;//composicao

        public void setDatasetbase(BaseDataSet basedataset)
        {
            this._basedataset = basedataset;
        }

        public override string Write()
        {
            this._basedataset.Write();
            return "Método DataSetDecorator.Write() invocado";
        }
    }
}
