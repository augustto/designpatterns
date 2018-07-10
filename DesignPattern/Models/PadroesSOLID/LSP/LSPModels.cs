using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSPModels
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public virtual List<string> RetornarDadosPessoa()
        {
            var ret = new List<string>();
            ret.Add(Nome);
            return ret;
        }
    }

    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public override List<string> RetornarDadosPessoa()
        {
            var ret = base.RetornarDadosPessoa();
            ret.Add(RazaoSocial);
            ret.Add(CNPJ);
            return ret;
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public override List<string> RetornarDadosPessoa()
        {
            var ret = base.RetornarDadosPessoa();
            ret.Add(CPF);
            return ret;
        }
    }

    public class Impressao
    {
        public void Impmrimir(Pessoa pessoa)
        {
            var dados = pessoa.RetornarDadosPessoa(); //note que desse modo eu posso imprimir todos elementos da abstração pessoa
            foreach (var s in dados)
                Console.WriteLine(s);
        }
    }
}