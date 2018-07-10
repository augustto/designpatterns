using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    // Concrete Prototyp
    public class Livro:Item
    {
        // construtor
        public Livro(int id, string descricao, double preco)
            : base(id, descricao, preco)
        {

        }
        // clonar
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
