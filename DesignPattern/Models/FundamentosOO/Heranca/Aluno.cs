using System;

namespace Heranca
{
    public class Aluno:Pessoa
    {
        public int Matricula;
        public void Estudar()
        {
            Console.WriteLine(Nome + " estudando...");
        }
    }
}
