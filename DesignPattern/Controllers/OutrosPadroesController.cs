using DesignPattern.Models.Util;
using InterpreterModels;
using ObjectPoolPattern;
using PrivateClassDataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPattern.Controllers
{
    public class OutrosPadroesController : Controller
    {
        #region PrivateDataClass
        /*
         padrão Private Class Data, que tem por intenção separar os atributos de uma classe do seu comportamento, tornando estes uma classe separada de dados (data class).
         A classe de origem então tem uma associação com esta classe de dados, inicializando seus atributos por construção. 
        */
        public void PrivateClassData()
        {
            var cli = new Cliente(1, "guz", "123", "guz123@gmail.com", "99999999");
            cli.MostrarCliente();
            cli.MostrarContatoCliente();

            Response.Write(WriterMessages.GetAllMessages());

        }

        #endregion

        #region ObjectPool 
        /*
        Este padrão permite que objetos sejam reutilizados / reaproveitados, sem a necessidade de criação para cada chamada / solicitação de aplicações clientes. É uma espécie de cache de objetos. 
        */

        public void ObjectPool()
        {
            var constr = @"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=true; Pooling=false;";
            var pool = new SqlConnectionPool(constr);
            var con = pool.checkOut();
            var SQL = "select * from Products";
            var cmd = new SqlCommand(SQL, con);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[1].ToString());
            }
            dr.Close();
            pool.checkIn(con);
            Console.ReadLine();

        }
        #endregion


        #region Interpreter
        /*
        o padrão Interpreter. Entre suas intenções pode definir: Dada uma linguagem, define uma representação para sua gramática juntamente com um interpretador
        que usa a representação para interpretar sentenças da mesma.
        */

        public void Interpreter()
        {
            
            var ctx = new Context();

            var list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
                exp.Interpret(ctx);
      
            Console.ReadLine();
        }
        #endregion




        //****

    }
}