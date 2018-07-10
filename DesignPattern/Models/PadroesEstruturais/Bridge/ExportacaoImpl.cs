using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    // Implementor - implementação da exportação
    public abstract class ExportacaoImpl
    {
        public abstract string Exportar();
    }
}
