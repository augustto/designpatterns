using System;
using System.Collections.Generic;

namespace SoCModels
{
    public partial class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}