using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCModels
{
    public partial class Funcionario
    {
        public int CalcularTempoServico()
        {
            var now = DateTime.Now;
            var span = now - DataAdmissao;
            int days = span.Days;
            return days;
        }
    }
}
