using KeepItSimpleAndYAGNIModels.cs;
using LoDModels;
using SoCModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern.Controllers
{
    public class PadroesEBoasPraticasController : Controller
    {
        #region LoD - Law of Demeter
        /*
        LoD - Law of Demeter, a Lei de Demeter, um bom princípio de design de sistemas orientados a objetos, mais especificamente relacionado a coesão entre classes,
        permitindo reduzir o acoplamento. 

        */

            //promove o baixo acoplamento entre classes.
        public void LoD()
        {
            var promocao = new Promocao() { Desconto = 50 };
            var p1 = new Produto() { Codigo = 1, Nome = "iPad", Valor = 2000, Promocao = promocao };
            var p2 = new Produto() { Codigo = 2, Nome = "iPhone", Valor = 1500, Promocao = promocao };
            var reajuste = new Reajuste();
            reajuste.Produtos.Add(p1);
            reajuste.Produtos.Add(p2);
            reajuste.ReajustarPromocao(promocao.Desconto);
            Console.WriteLine("Produto:{0}, Valor:{1}", p1.Nome, p1.Valor);
            Console.WriteLine("Produto:{0}, Valor:{1}", p2.Nome, p2.Valor);
            Console.WriteLine("Total desconto: {0}", reajuste.TotalDesconto);
            Console.ReadLine();
        }
#endregion

        #region Keep it Simple e YAGNI
        /*
        os princípios Keep it Simple (Mantenha Simples) e YAGNI (You aren't gonna need it, Você ainda não vai precisar dele). Basicamente estes princípios demonstram
        uma prática de XP .Normalmente não se aplica um padrão de projeto de forma antecipada,
        causando complexidade desnecessária (excesso de engenharia), pois não se sabe no início do desenvolvimento de um projeto como a arquitetura vai evoluir.

        */

        public void KeepItSimple()
        {
            //Console.WriteLine("Olá Mundo");
            var factory = OlaMundoSingleton.getInstance().getFactory();
            var sub = factory.createSubject();
            sub.attach(factory.createObserver());
            var cmd = factory.createCommand(sub);
            cmd.execute();
        }

     
        #endregion


        #region SoC - Separation of Concerns
        /*
        separa as responsabilidades de classes que inicialemente seriam muito grande, tendo muita responsabiliade
        tem muito a ver com o padrão do principio de responsabilidade única (uma classe tem que ter uma única responsabilidade, não pode ser sobrecarregada
        com muitas informacoes e métodos)
        o princípio SoC - Separation of Concerns, o princípio de Separação de Responsabilidades. Quando uma classe está com muitas atribuições e responsabilidades,
        fazendo mais do que deveria ou com um tamanho muito grande em termos de linhas de código, isso pode se caracteriza como uma
        Large Class  ou God Class , já que faz praticamente tudo. O exemplo mostra como aplicar o princípio SoC para dividir as
        responsabilidades de uma classe em uma forma mais simples de mantê-la. 

        */

        public void SoC()
        {
            var gp = new Funcionario();
            gp.Codigo = 123;
            gp.Nome = "abc xyz";
            gp.Salario = 1000;
            gp.DataAdmissao = new DateTime(2000, 04, 29);
            gp.AumentarSalario(20);
            gp.Imprimir();
            var tempo = gp.CalcularTempoServico();
            Console.WriteLine("Tempo de serviço: " + tempo);
            Console.ReadLine();

        }
        #endregion
    }
}
