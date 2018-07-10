using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class ExportacaoPDF : ExportacaoImpl
    {
        public override string Exportar()
        {
            return "Exportando PDF...";
        }
    }
}
