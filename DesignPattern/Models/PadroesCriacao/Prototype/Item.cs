using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    // Prototype
    public abstract class Item
    {
        // propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        //construtor
        public Item(int id, string descricao, double preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        // clonar
        public abstract Item Clone();
    }
}
