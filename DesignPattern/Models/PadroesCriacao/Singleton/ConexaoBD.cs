using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    // Singleton
    public class ConexaoBD
    {

        private static ConexaoBD _instance;

        protected ConexaoBD()
        {
        }

        public static ConexaoBD Instance()
        {
  
            if (_instance == null)
                _instance = new ConexaoBD();
            return _instance;
        }

        public string stringConexao { get; set; }
        public string Open()
        {
           return "Abrindo conexao com banco "+stringConexao;
        }

    }
}
