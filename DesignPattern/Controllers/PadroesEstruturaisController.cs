using Adapter;
using Bridge;
using Composite;
using Decorator;
using Facade;
using Flyweight;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern.Controllers
{
    public class PadroesEstruturaisController : Controller
    {

        #region Adapter
        /*
        Resumo:(como se fosse um adaptador mesmo) resolve o proble de trabalhar com classe e interfaces incopativeis(que não se relacionam)

         A intenção do padrão Adapter, também conhecido como Wrapper, é converter a interface de uma classe em outra interface esperada pelos clientes. Permite que classes trabalhem em conjunto,
         pois de outra forma não poderiam devido a suas interfaces incompatíveis. 
            
        Participantes:
        *Target - define uma interface específica do domínio que o Cliente usa;
        *Client - colabora com objetos compatíveis com a interface de Target;
        *Adaptee - define uma interface existente que necessita ser adaptada.
        *Adapter - adpata a interface do Adaptee à inteface do Target;


            */

        public void Adapter()
        {
            Target target = new Adapter.Adapter();
            Response.Write(target.Request());


        }
        #endregion


        #region Bridge
        /*
        A intenção do padrão Bridge é desacoplar uma abstração de sua implementação, de modo que os dois possam variar independentemente. O padrão pode ser usado para
        evitar o vínculo permanente entre uma abstração e sua implementação, por exemplo quando a implementação deve ser alterada em tempo de execução.

       *Participantes:
       *Abstraction - define a interface da abstração; mantém uma referência para o objeto do tipo implementor;
       *Refined Abstraction - estende a interface definada por Abstraction;
       *Implementor - define a interface para as classes de implementação;
       *Concrete Implementor - implementa a interface de implementor e define sua implementação correta.

        */

        // Client
        public void Bridge()
        {
            Exportacao exp = new ExportacaoEx();
            // injetando o objeto de implementação
            exp.Implementor = new ExportacaoDOC();
            Response.Write(exp.Exportar());
        }
        #endregion

        #region Composite
        /*Este padrão tem por intenção compor objetos em estruturas de árvore para representar hierarquias parte ou ttodo. Composite permite que clientes tratem
        objetos individuais e composições de objetos de maneira uniforme.
        
        Participantes:
        *Component - declara a interface para os objetos na composiçãwo; implementa  comportamento padrão para a interface comum; declara interface para gerenciar filhos;
        *Leaf - representa objetos 'folha' na composição;
        *Composite - define comportamentos para os componentes que têm filhos; implementa operações relacionadas com os filhos;
        *Client - manipula objetos na composição através da interface de Component;
        */


        public void Composite()
        {
            var form = new Formulario("Cadastro Clientes");
            form.Add(new Button("Incluir"));
            form.Add(new Button("Consultar"));
            form.Add(new TextBox("Nome"));
            form.Add(new TextBox("Fone"));

           Response.Write(form.Display());
        }
        #endregion

        #region Decorator
        /*
      
        Este padrão tem a intenção de, dinamicamente, agregar responsabilidades adicionais a um objeto. 

        Participantes:
        *Component - define a interface para objetos que podem ter responsabilidades acrescentadas dinamicamente;
        *ConcreteComponent - define um objeto para qual as responsabilidades adicionais podem ser atribuidas;
        *Decorator - mantém uma referência para um objeto Component e define uma interface que segue a interface do Component;
        *ConcreteDecorator - acrescenta responsabilidade ao componente
        */

        //Client
        public void Decorator()
        {

            // Cria ConcreteComponent
            DataSet c = new DataSet();
            // Cria ConcreteDecorator
            DataSetConcreteDecorator d = new DataSetConcreteDecorator();
            // setando objeto a ser decorado (injetando implementaçã0)
            d.setDatasetbase(c);
            // chamando método da abstração
            Response.Write(d.Write());
            // chamando método injetado pelo decorator
            Response.Write("<br>" + d.WriteXML());

        }
        #endregion

        #region Façade
        /*A intenção do padrão Façade é fornecer uma interface unificada para um conjunto de interfaces em um subsistema. Facade define uma interface de nível
        mais elevado que faz o subsistema mais fácil de usar. Uma boa aplicação para o Façade (fachada) é criar uma forma mais simples para os objetos clientes de
        lideram com um sistema mais complexo, escondendo muito de sua implementação, fortalecendo o encapsulamento e isolamento.
        
        Participantes:
        *Façade - conhece quais as classes do subsistema são responsáveis pelo atendimento de uma solicitação; delega solicitações de clientes a objetos 
        apropriados do subsistema;



        */

        public void Facade()
        {
            //sem o Facade teria que fazer isso:
            //var email = new Mail(new SMTPSettings());
            //var msg = new MailMessage("Hi mrx", new MailFormatHTML());
            //email.Send(msg);

            //com Facade
            var email = new Email();
            Response.Write(email.Enviar("Hi mrx"));


        }
        #endregion

        #region Flyweight 
        /*
         note que quando vou buscar um objeto eles já estão instanciados.

         A intenção desse padrão é usar compartilhamento para suportar um grande número de objetos semelhantes de forma eficiente. O padrão visa minimizar o uso
         de memória no armazenamento de vários objetos através do compartilhamento das informações em comum que essas instâncias possuem.

         Participantes:
        *Flyweight - é a interface que define como devem ser as classes que trabalham neste padrão. é importante citar que ela descreve como os dados extrínsecos são objtidos,
        ou seja, as operações que fazem essa transposição de informações;
        *ConcreteFlyweight - são as classes que implementam o contrato IFlyweight e que devem permitir o comportamento. Essas classes mantém dados intrínsecos;
        *UnsharedConcreteFlyweight - possuem as mesmas características do ConcreteFlyweight, no entanto não são objetos compartilhados. Isso porque este padrão permite
        o compartilhamento, mas não obriga que isso seja sempre seguido;
        *FlyweightFactory - Classe que é responsável pela criação dos objetos, além de manter o repositório de objetos que implementam o Flyweight;
        *Client - É quem utiliza os objetos IFlyweight, sempre os obtendo através do FlyweightFactory 
        */
        public void Flyweight()
        {
            // externo
            int ext = 10;

            FlyweightFactory fabrica = new FlyweightFactory();
            Flyweight.Flyweight f1 = fabrica.getFlyweight("A");
            Response.Write(f1.Operation(ext++));

            Flyweight.Flyweight f2 = fabrica.getFlyweight("B");
            Response.Write("<br>" +f2.Operation(ext++));

            Flyweight.Flyweight f3 = fabrica.getFlyweight("C");
            Response.Write("<br>" + f3.Operation(ext++));

            Flyweight.Flyweight f4 = fabrica.getFlyweight("A");
            Response.Write("<br>" + f4.Operation(ext++));

            Flyweight.Flyweight f5 = new UnsharedConcreteFlyweight();
            Response.Write("<br>" + f5.Operation(ext++));
        }
        #endregion

        #region Proxy
        /*


        A intenção do padrão Proxy é fornecer um substituto ou espaço reservado para outro objeto para controlar o acesso a ele. Um proxy, em sua forma mais geral, 
        é uma classe que funciona como uma interface para outra classe. 

       participantes:
       *Proxy - mantém uma referencia que permite ao proxy acessar o objeto real; fornece uma interface idêntica ao de subject, por esse motivo ele pode substituir o objeto
       real(Real Subject); controla o acesso ao objeto real, podendo ser responsvel pela criação e destruição;
       *Subject - define uma interface comum para RealSubject e Proxy;
       *RealSubject - define o objeto real que o proxu representa;

        */

        public void Proxy()
        {
            ICalc calc = new CalcProxy();
            var r = calc.Somar(3, 5);
            Response.Write(r);
        }

        #endregion
    }
}