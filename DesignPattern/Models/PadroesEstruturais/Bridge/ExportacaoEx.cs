using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    // RefinedAbstraction - refine a abstracao
    public class ExportacaoEx : Exportacao
    {
        public override string Exportar()
        {
            return base.Exportar();
            //..poderia colocar algum código a mais para refinação
        }
    }
}
