using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Produto Concreto
    public class AutenticacaoFacebook:Autenticacao
    {
        public override string Autenticar()
        {
            return "Autenticado via Facebook";
        }
    }
}
