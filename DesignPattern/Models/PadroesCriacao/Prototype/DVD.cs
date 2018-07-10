using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    // Concrete Prototype
    public class DVD : Item
    {
        // construtor
        public DVD(int id, string descricao, double preco)
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