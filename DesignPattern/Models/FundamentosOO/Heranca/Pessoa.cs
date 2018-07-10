using System;
//conceito de herdar caracteristicas de uma classe em comum
namespace Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public void Dormir()
        {
            Console.WriteLine(Nome + " dormindo...");
        }
    }
}
