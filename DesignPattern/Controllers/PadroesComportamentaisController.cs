using ChainOfResponsability;
using Command;
using Iterator;
using System;
using System.Web.Mvc;
using MediatorModels;
using MementoModels;
using ObserverModels;
using DesignPattern.Models.Util;
using State;
using Strategy;
using TemplateMethodModels;
using VisitorModels;
using DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta;
//obs -> note que a maioria esmagadora dos participantes sempre serao abstração e implementaçao
namespace DesignPattern.Controllers
{
    public class PadroesComportamentaisController : Controller
    {
        #region ChainOfResponsability
        /*
        resumo: passa a solicitação para uma cadeia de objeto, até que um deles a trate

          Chain of Responsibility é um padrão GOF cuja principal função é evitar a dependência entre um objeto receptor e um objeto solicitante.
        
        Participantes:
        *Handler - define uma interface para tratar solicitações;
        *ConcreteHandler - trata de solicitaçoes pelas quais é responsável; pode acessar seu sucessor;
        *Client - inicia a solicitação para um objeto ConcreteHandle da cadeia;    
        */
        //Client
        public void ChainOfResponsability()//usar o debug.writeline nas saidas de dados para visualizar... ou entao acessar o fonte aula 23
        {
            var valForm = new ChainOfResponsability.Formulario();
            var valServer = new ChainOfResponsability.Server();
            var valBD = new BD();

            valForm.setSucessor(valServer);
            valServer.setSucessor(valBD);
            // passando requisição para cadeia de responsabilidade
            valForm.ValidateUser("teste", "teste");



        }
        #endregion

        #region Command
        /*
        Command é um padrão no qual um objeto é usado para encapsular toda informação necessária para executar uma ação ou acionar um evento em um momento posterior.
        
        Participantes:
        *Command - declara uma interface para executar a operação;
        *ConcreteCommand  
        *Client - cria um objeto ConcreteCommand e configura seu receptor;
        *Invoker - solicita ao Command a execução;
        *Receiver - sabe como executar as operações associadas a uma solicitação; qualquer classe pode funcionar como um receiver;
        *
        */
        //Client
        public void Command()//melhor usar o font console app para verificar os passos -- aula24
        {
            // configura Receiver
            Command.Server server = new Command.Server();
            // cria comando configurando o receiver
            Command.Command cmd = new ServerCommand(server);
            // configura o Invoker
            Command.Formulario form = new Command.Formulario();
            // configura e executar o comando...
            form.setCommand(cmd);
            form.ClickValidate();
            Console.ReadLine();

        }
        #endregion

        #region Iterator
        /*
       
        A intenção do padrão Iterator é fornecer uma maneira de acessar os elementos de um objeto agregado sequencialmente sem expor sua representação.

        Participantes:
        *Iterator - define uma interface para acessar e percorrer os elementos
        *ConcreteIterator - implementa a interface do Iterator; mantém o controle da posição corrente no percurso do agregado;
        *Aggregate - define uma interface para criação de um objeto Iterator;
        *ConcreteAggregate - implementa a interface de criação do Iterator para retornar uma instância do ConcreteCreator apropriado; 
                
        */
        //Client
        public void Iterator()
        {
            //Cria Concrete Aggregate
            Equipe equipe = new Equipe();
            equipe[0] = "x";
            equipe[1] = "y";
            equipe[2] = "z";
            equipe[3] = "zz";

            ConcreteIterator i = new ConcreteIterator(equipe);

            Response.Write("Listando membros da equipe:");
            Object item = i.First();
            while (item != null)
            {
                Response.Write("<br>" + item);
                item = i.Next();
            }
            
        }
        #endregion

        #region Mediator
        /*

        A intenção do padrão Mediator é definir um objeto que encapsula como um conjunto de objetos interagem. Mediator promove o baixo acoplamento por manter objetos
        sem se referir um ao outro de forma explícita, e que lhe permite variar sua iteração independentemente.e. 

        Participantes:
        *Mediator - define uma interface para comunicação com objetos Colleague;
        *ConcreteMediator - implementa o comportamento cooperativo;
        *Colleague classes - cada classe Colleague conhece seu objeto Mediator de outra forma; cada Colleague se comunica com seu Mediator sempre que, de outra forma,
        teria que se comunicar com outro colega.
        */

        public void Mediator()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Suporte suporte = new Suporte(mediator);
            Usuario usuario = new Usuario(mediator);
            mediator.Suporte = suporte;
            mediator.Usuario = usuario;
            Response.Write(usuario.Send("Meu Windows não está entrando!!!"));
            Response.Write(suporte.Send("<br>Formate a máquina..."));

        }
        #endregion

        #region Memento


        /*A intenção do padrão Memento é, sem violar o encapsulamento, capturar e externalizar o estado interno de um objeto para que o objeto possa ser restaurado
        para este estado mais tarde. 
        
        Participantes:
        *Memento - armazena o estado interno do objeto Originador. O Memento pode armazenar i, pouco ou muito do estado do Originador, conforme necessário;
        Protege contra acessos por objetos que não o Originador;
        *Originador - cria um Memento contendo um instantâneo do seu estado interno corrente, usa o Memento para restaurar o seu estado interno.
        *Caretaker - é responsavel pela cutódia do Memento; nunca opera ou examina os conteúdos de um Memento;
                
        */

        //Cliente
        public void Memento()
        {
            // cria originator
            Pessoa gp = new Pessoa();
            gp.State = "ax";
            // mostra estado original
            Response.Write("Estado original: " + gp.State);

            Caretaker c = new Caretaker();//guarda uma referencia para o memento
            c.Memento = gp.CreateMemento();
            // trocando o estado...
            gp.State = "ax2";
         
            Response.Write("<br>Estado atual: " + gp.State);
            // restaurar o estado original
            gp.setMemento(c.Memento);
       
            Response.Write("<br>Estado restaurado: " + gp.State);
            
        }
        #endregion

        #region Observer
        /* 
        A intenção do padrão Observe é definir uma dependência um-para-muitos entre objetos de modo que quando um objeto muda de estado, todos os seus dependentes
        são notificados e atualizados automaticamente. ".

        Participantes:
        *Subject - conhece os seus observadores. Um número qualquer de objetos Observer pode observar um Subject;
        *Observer - define uma interface de atualização para objetos que deveriam ser notificados sobre mudanças em um Subject;
        *ConcreteSubject - armazena estados de interesse para obetos ConcreteObserver; envia uma notificação para os seus observadores quando seu estado muda;
        *ConcreteObserver - mantém uma refêrencia para um objeto ConcreteSubject; armazena estados que deveriam permanecer consistentes com os do Subject. implementa
        a interface de atualização de Observer, para mater seus estados consistente com o do Subject;

        */

        public void Observer()
        {
            // Concrete Subject
            Balanco balanco = new Balanco();
            // Concrete Observer
            Venda venda = new Venda(balanco);
            // adicionar os observadores
            balanco.AdionaObservador(venda);
            //processo...
            balanco.Iniciar();
            //balanco.Finalizar();
            // pode vender?
            venda.Iniciar();

            Response.Write(WriterMessages.GetAllMessages());

        }


        public void ObserverFesta()
        {   //observers
            var namorada = new NamoradaAniversariante();
            var mae = new MaeAniversariante();
            var avo = new AvoAniversariante();
            //subject
            var porteiro = new Porteiro();
            porteiro.AddChegadaAniversarianteObserver(namorada);
            porteiro.AddChegadaAniversarianteObserver(mae);
            porteiro.AddChegadaAniversarianteObserver(avo);

            porteiro.VerificarSeOMoradorEOAniversariante();
            Response.Write(WriterMessages.GetAllMessages());
        }
        #endregion

        #region State
        /*
        -Parecido com strategy

        Sua intenção é permitir que um objeto altere seu comportamento quando seu estado interno muda. O padrão pode ser aplicado quando o comportamento de um objeto
        depende do seu estado e ele pode mudar seu comportamento em tempo de execução, dependendo desse estado; operações têm comandos condicionais grandes, de várias
        alternativas, que dependem do estado do objeto. Esse estado é normalmente representando por uma ou mais constantes enumeradas. ,

        Participantes:
        *Context - define uma interface de interesse para os clientes; mantém uma instancia de uma subclassse ConcreteState que define o estado corrente
        *State - define uma interface para o encapsulamento associado com um determinado estado do Context;
        *ConcreteState Subclasses - cada subclasse implementa um comportamento associado com um estado do Context.
        */

        public void State()
        {
            Connection con = new Connection(new ConnectionOpened());
            con.Open();
            con.Close();

            Response.Write(WriterMessages.GetAllMessages());
        
        }
        #endregion

        #region Strategy
        /*
        Sua intenção é definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiáveis. 

        Participantes:
        *Strategy - define uma interface comum para todos os algoritmos suportados. Context usa esta interface para chamar o algoritmo definido por uma ConcreteStrategy;
        *ConcreteStrategy - implementa o algoritmo usando a interface Strategy;
        *Contex - mantém uma referência para um objeto Strategy; pode definir uma interface que permite a Strategy acessar seus dados 
        
        */

        //Client
        public void Strategy()
        {
            // cria um array com 20 números randomizados
            long[] inputArray = new long[20];

            Random rnd = new Random();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = rnd.Next(100);
            }
            // mostra os números desordenados
            WriterMessages.AmarzenaMSG(this, "Números originais:");
            foreach (var number in inputArray)
                WriterMessages.AmarzenaMSG(this, number.ToString());
      
            // usando a estratégia para ordenar...
            Context ctx = new Context(new InsertionSort());
            ctx.ContextInterface(inputArray);
            // mostra números ordenados
            WriterMessages.AmarzenaMSG(this, "*******************************<br><span style='color:red'>Números ordenados: </span>");
            foreach (var number in inputArray)
            WriterMessages.AmarzenaMSG(this, number.ToString());
            

            Response.Write(WriterMessages.GetAllMessages());
        }
        #endregion

        #region TemplateMethod
        /*

        Este padrão tem por objetivo definir o esqueleto de um algoritmo em uma operação, postergando alguns passos para as subclasses. Template Method
        permite que as subclasses redefinam certos passos de um algoritmo sem mudar a estrutura do mesmo. 

        Participantes:
        *AbstractClass - define as operacoes primitivas abstratas que as subclasses concretas definem para implementar passos de um algoritmo; implementa um
        método-template que define o esqueleto de um algoritmo;
        *ConcreteClass - implementa as operações primitivas para executar os passos específicos invariantes do algoritmo

        */

        public void TemplateMethod()
        {
            Correcao prova = new CorrecaoProva();
            prova.Processar();
            Correcao redacao = new CorrecaoRedacao();
            redacao.Processar();

            Response.Write(WriterMessages.GetAllMessages());
        }
        #endregion

        #region Visitor
        /*
        Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre as quais opera Entre os principais benefícios podemos citar a facilidade na
        adição de novas operações que dependem de objetos complexos, reduzindo assim o acoplamento e fazendo com que o desenvolvimento foque na programação com abstrações.
     
        Participantes:
        *Visitor - declara uma operação Visit para cada ConcreteElement na estrutura do objeto; O visitante pode acessar o elemento diretamente através da interface específica.
        *ConcreteVisitor - implementa cada operação (fragmento do algoritmo) declarada por Visitor;
        *Element - define a operação Accept que aceita o visitante;
        *ConcreteElement - implementa a operação Accept;
        *ObjectStructure - pode enumerar seus elementos; 
                
        */

        public void Visitor()
        {
            // configurar a estrutura
            ObjectStrutcture obj = new ObjectStrutcture();
            obj.Attach(new ConcreteElementA());
            obj.Attach(new ConcreteElementB());

            // criar os visitors
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // estrutura aceitar visitors
            obj.Accept(v1);
            obj.Accept(v2);

            Response.Write(WriterMessages.GetAllMessages());

        }
        #endregion



        //****

    }
}