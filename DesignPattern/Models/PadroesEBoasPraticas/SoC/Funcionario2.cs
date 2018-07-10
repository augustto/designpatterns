using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCModels
{
    public partial class Funcionario
    {
        public void Imprimir()
        {
            Console.WriteLine("Dados do funcionário:");
            Console.WriteLine("Código: " + Codigo.ToString());
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salário: " + Salario.ToString());
        }
    }
}
