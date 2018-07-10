using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoDModels
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Promocao Promocao { get; set; }
        public double Reajustar(double percentual)
        {
            double valorDesconto = 0;
            Promocao.Desconto = percentual;
            valorDesconto = ((percentual * Valor) / 100);
            Valor -= valorDesconto;
            return valorDesconto;
        }
    }

    public class Promocao
    {
        public double Desconto { get; set; }
    }

    public class Reajuste// antes o valor de produto (produto.valor) era reajustado diretamente nessa classe, causando um badsmell
    {
        public List<Produto> Produtos { get; set; }
        public double TotalDesconto { get; set; }

        public Reajuste()
        {
            this.Produtos = new List<Produto>();
        }
        

        public void ReajustarPromocao(double perc)
        {
            TotalDesconto = 0;
            foreach (var produto in Produtos)
                TotalDesconto += produto.Reajustar(perc);
        }


    }
}