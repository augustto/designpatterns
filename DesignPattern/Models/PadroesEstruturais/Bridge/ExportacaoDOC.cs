using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    // ConcreteImplementor
    public class ExportacaoDOC : ExportacaoImpl
    {
        public override string Exportar()
        {
            return "Exportando DOC...";
        }
    }
}
