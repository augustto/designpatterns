using AbstractFactory;
using Builder;
using ConsoleApplication1;
using Prototype;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern.Controllers
{
    public class PadroesCriacaoController : Controller
    {

        #region AbstractFactory
        /*  Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar
            suas classes concretas.
      
            Este padrão pode ser utilizado quando um sistema de software precisa ser independente de como classes concretas
            são criadas, compostas ou representadas. A fabrica fica responsavel por encapsular a criação dos objetos, o usuario
            conhece apenas a interface da criacao.

            Participantes:
            *Abstract Factory - declara uma interface para opearacoes que criam objetos-produtos abstratos
            *Concrete Factory - implementa as operacoes que criam objetos-produtos concretos.
            *Abstract Product - declara uma interface para um tipo de objeto-produto
            *Concrete Product - define um objeto-produto a ser criado pela correspondente fabrica concreta; implementa a interface de Abstract Product
            *Cliente - usa somente as interfaces declaradas pelas classes Abstract Factory e Abstract Product
        */
        public void AbstractFactory()
        {
            DBAbstractFactory dbfSQL = new SQLFactory();
            DBAbstractFactory dbfOracle = new OracleFactory();

            var conn = dbfSQL.createConnection();

            if (conn.Open())
                Response.Write("Conexão aberta com sucesso usando AbstractFactory");

            var cmd = dbfSQL.createCommand();
            if (cmd.Execute())
                Response.Write("<br>Comando executado com sucesso usando AbstractFactory");

            var cmdOracle = dbfOracle.createCommand();
            if (cmdOracle.Execute())
            {
                Response.Write("<br>Comando da Oracle executado com sucesso!");
            }
        }

        #endregion

        #region Builder
        /*Intenção: separar a construção de um objeto complexo  de sua representação, de modo que o mesmo processo de
        construção pode criar diferentes representações
        
            O padrão pode ser aplicado quando o algoritmo para a construção de um objeto deve ser idependente das partes que o compoçem e de como
            elas são montadas. O processo de contrução deve permitir diferentes representações para o objeto que é construído.

            Participantes:
            *Builder - especifica uma interface abstrata para a criação de partes de um objeto-produto
            *Concrete Builder - constrói e monta partes do produto pela implementação da interface de Builder; define e mantém a representação que cria; fornece
            uma interface para recuperação do produto;
            *Director - constrói um objeto usando a interface de Builder;
            *Product - representa o objeto complexo em construção;
            *Concrete Builder - constroi a representação interna do produto e define o processo pelo qual é montado; inclui classes que definem as partes constituintes,
            incluisve as interfaces para montagem das partes do resultado final.
            */

        public void Builder()
        {
         
            VeiculoBuilder builder = new CarroBuilder();
            var director = new Director();
            director.Construct(builder);


            Response.Write("<h1><strong>Criação utilizado o Builder</strong></h1><br>" + builder.Veiculo.Mostrar());

            Response.Write("<br>--------------------------------<br>");

            builder = new MotoBuilder();
            director.Construct(builder);
            Response.Write(builder.Veiculo.Mostrar());
        }

        #endregion

        #region FactoryMetod
        /*Intenção: definir uma interface para criar um objeto, mas é a suas subclasses que decidem qual classe vão instanciar.
        permite uma classe adiar a instaciação para subclasses.    

        Descrição:O padrão pode ser aplicado quando uma classe não é capaz de saber antecipadamente quais objetos devem realmente ser criados, quando uma classe repassa(delega)
        para suas subclasses a responsabilidades de quais objetos realmentem devem ser criados

        Participantes:
        Product - define a interface de objetos que o método de fabrica cria.
        *Concrete Product - inplementa a interface Product
        *Creator - Declara o método de fabrica, o qual retorna um objeto do tipo Product. Creator tambem pode definir uma implementação por omissão do método factory que retorna por 
        omissão um objeto Concrete Product.
        *Concrete Creator - redefine o método fabrica para retornar uma instância de um Concrete Product.
        */

        public void FactoryMethod()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance();
                Response.Write("<br>" + aut.Autenticar());
            }


        }

        #endregion


        #region Prototype
        /*
        Permite a criação de novos objetos a partir de um modelo original ou protótipo que é clonado.

        *Participantes: Prototype - declara uma interface para clonar si próprio;
        *Concrete Product - implementa uma operação para clonar si próprio;
        *Client - cria um novo objeto solicitando a um protótipo que clone a si próprio
        */

        public void Prototype()
        {
            // cria um objeto protótipo e um clone
            Livro p1 = new Livro(1, "Design Patterns", 20.0);
            Livro c1 = (Livro)p1.Clone();
            Response.Write("Clonado: " + c1.Descricao);
            // cria um objeto protótipo e um clone
            DVD p2 = new DVD(1, "POO", 30.0);
            DVD c2 = (DVD)p2.Clone();
            Response.Write("<br>Clonado: " + c2.Descricao);

        }
        #endregion


        #region Singleton
        /*
         Este padrão tem a intenção de garantir que uma classe tem apenas uma instância, e fornecer um ponto global de acesso a ela.

        Participante:
        *Singleton - defiene uma operação Instance que permite aos clientes acessaraem sua única instancia. Instanceé uma operação de classe (método estático), pode ser responsável pela criação de sua própria
        instancia única.
        */

        public void Singleton()
        {
            var con1 = ConexaoBD.Instance();
            con1.stringConexao = "SQL Server";
            Response.Write(con1.Open() + "objeto con1");
            var con2 = ConexaoBD.Instance();
            Response.Write("<br>" + con2.Open() + "objeto con2") ;
            // comprovando que são a mesma instância
            if (con1 == con2) 
                Response.Write("<br>São a mesma instância");

        }
        #endregion
    }
}