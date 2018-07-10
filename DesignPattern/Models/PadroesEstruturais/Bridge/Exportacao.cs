using System;
namespace Bridge
{
    // Abstraction
    public abstract class Exportacao
    {
        protected ExportacaoImpl _implementor;

        public ExportacaoImpl Implementor
        {
            set { _implementor = value; }
        }

        public virtual string Exportar()
        {
            // implementação por delegação
            return _implementor.Exportar();
        }
    }
}
