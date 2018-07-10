using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulamento
{
    public class Bateria
    {
    }

    public class SuperBateria : Bateria
    {
    }

    public class Motor
    {
    }

    public class Moto
    {
        //Encapsulando detalhes da moto
        //composicao
        private Motor _motor; //composicao
        private Bateria _bateria; //composicao

        private string _nome;
        private void Ignicao()
        {
            Console.WriteLine("Foi dada ignição no carro...");    
        }

        //Propriedade...
        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        //Construtor
        public Moto(string nome)
        {
            Console.WriteLine("Criando objeto moto...");
            _motor = new Motor();
            _bateria = new Bateria();
            _nome = nome;
        }
        public int NumPneus()
        {
            return 2;
        }
        public void Abastecer()
        {
            Console.WriteLine("Abastecendo moto...");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando moto...");
            Ignicao();
        }
        public void Mover()
        {
            Console.WriteLine("Movendo   moto...");
        }
    }
}
