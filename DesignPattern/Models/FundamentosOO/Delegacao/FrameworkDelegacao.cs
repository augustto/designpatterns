using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//composição = herença de caixa preta: já que os detalhes do objeto herdado não fica expostos ao mundo externo. 

namespace FrameworkDelegacao
{
    public class Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Funcionário trabalhando...");
        }
    }

    public class Estagiario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Estagiário trabalhando...");
        }
    }

    public class Developer: Funcionario
    {   
        public void Desenvolver(string tarefa)
        {
            Console.WriteLine("Developer programando...");
        }
    }

    public class ArquitetoSoftware: Funcionario
    {
        public void Projetando(string tarefa)
        {
            Console.WriteLine("Arquiteto Projetando...");
        }
    }

    public class Tester : Funcionario
    {
        public void Testar(string tarefa)
        {
            Console.WriteLine("Tester testando...");
        }
    }

    public class Gerente
    {
        private Estagiario _estagiario;
        private Developer _developer;
        private ArquitetoSoftware _arquiteto;
        private Tester _tester;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _developer = new Developer();
            _arquiteto = new ArquitetoSoftware();
            _tester = new Tester();
        }
        //delegacao da tarefa -> basicamente a chamada de métodos de outras classes.
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Gerente recebeu a tarefa " + tarefa);
            _estagiario.Trabalhar(tarefa);
            _arquiteto.Projetando(tarefa);
            _developer.Trabalhar(tarefa);
            _tester.Testar(tarefa);
        }
    }

}
