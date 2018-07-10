using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Concrete Creator
    public class FacebookCreator:Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
