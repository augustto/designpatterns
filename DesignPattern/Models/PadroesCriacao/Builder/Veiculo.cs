using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    //Produto
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        //construtor
        public Veiculo(string tipo)
        {
            this._tipo = tipo;
        }

        // indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public string Mostrar()
        {   
            return string.Format(
            "Tipo: {0}<br> Motor: {1}<br> Pneus {2}<br>  Portas: {3}", _tipo, _parts["motor"], _parts["pneus"], _parts["portas"]);

        }
    }
}
