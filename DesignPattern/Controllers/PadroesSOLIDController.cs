using DIPModels;
using Interfaces;
using ISPModels;
using LSPModels;
using OCPModels;
using SRPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern.Controllers
{
    public class PadroesSOLIDController : Controller
    {
        #region SRP - Single Responsibility Principle
        /*
        SRP - Single Responsibility Principle, o Princípio da Responsabilidade Única, o primeiro da categoria SOLID. Este padrão indica que uma classe não deve
        estar sobrecarregada de responsabilidades, devendo ter uma única responsabalidade, a fim de maximizar sua reutilização e melhorar o índice de manutenção. 
        */
        public void SRP()
        {
            var Produto = new Produto(new DAOProduto());
        }
        #endregion

        #region OCP - Open Closed Principle
        /* 
        o princípio OCP - Open Closed Principle, o Princípio do Aberto Fechado, o segundo da categoria SOLID. Este padrão indica que uma classe deve ser fechada
        para modificação e aberta para expansão, a fim de tornar a mesma mais fácil de ser evoluída. 
        */
        public void OCP()
        {
            var ret1 = new Retangulo() { Altura = 10, Largura = 10 };
            var ret2 = new Retangulo() { Altura = 20, Largura = 20 };
            var circ1 = new Circulo() { Raio = 20 };
            FormaGeometrica[] formas = { ret1, ret2, circ1 };
            var calc = new AreaCalc();
            var area = calc.CalcularArea(formas);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        #endregion

        #region LSP - Liskov Substitution Principle
        /*
        o princípio LSP - Liskov Substitution Principle, o Princípio de Substituição de Liskov, o terceiro da categoria SOLID. Este padrão indica que um
        método que receba uma classe como parâmetro, deve funcionar e apresentar o mesmo comportamento se receber uma subclasse mais específica como parâmetro
        onde se espera geralmente uma classe mais abstrata. 

        */
        public void LSP()
        {
            var pj = new PessoaJuridica() { Nome = "mrx", RazaoSocial = "mrx cc" };
            var pf = new PessoaFisica() { Nome = "mrx abc", CPF = "1234567891" };
            var imp = new Impressao();
            imp.Impmrimir(pj);
            Console.ReadLine();
        }
        #endregion

        #region ISP - Interface Segregation Principle
        /* 
        o princípio ISP - Interface segregation principle, o Princípio de Segregação de Interfaces, o quarto da categoria SOLID. Este padrão indica que uma interface
        que defina vários métodos deve ser segregada / separada em várias interfaces, a fim de evitar que uma classe que a implemente seja obrigada a descrever todos
        os seus métodos, possivelmente ferindo o princípio da responsabilidade única. 
        */

        public void ISP()
        {
            // programar para uma interface
            IVisualizar arq = new ISPModels.Foto() { Nome = "Dream Theater" };
            arq.Visualizar();
            Console.ReadLine();
        }
        #endregion

        #region DIP - Dependency Inversion Principle
        /*
        o princípio DIP - Dependency Inversion Principle, o Princípio da Inversão de Dependência, o última da categoria SOLID. Este padrão diz que uma classe
        não deve depender de uma implementação concreta, mas sim de uma abstração, podendo dessa forma inverter a dependência (de algo concreto para algo abstrato). 

        houve uma inversão de idependencia, quem manda a classe concreta agora é o método DIP(externo) antes estava nos metodos interno, onde não podia usar abstracao,
        e pra cada classe eu utilizava um tipo de "furo" diferente, não tinha uma entrada genérica (USB).
        */

        public void DIP()
        {
            Console.WriteLine("Digite valor do pedido:");
            var valor = Console.ReadLine();
            var pedido = new Pedido(new Cheque());
            pedido.Pagar(Convert.ToDouble(valor));
            Console.ReadLine();

        }
        #endregion
        
        
     
    }
}