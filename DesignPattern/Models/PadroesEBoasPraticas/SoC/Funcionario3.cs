using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCModels
{
    public partial class Funcionario
    {

        public void AumentarSalario(double perc)
        {
            Salario = Salario * (1 + (perc / 100));
        }
    }
}
