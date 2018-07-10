using System;

namespace Heranca
{
    public class Professor:Pessoa
    {
        public string Disciplina { get; set; }
        public void DarAula()
        {
            Console.WriteLine(Nome + "Professo Dando Aula...");
        }

    }
}
