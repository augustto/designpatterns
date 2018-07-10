using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Leaf
    public class Button : Component
    {
        public Button(string name)
            : base(name)
        {
        }

        public override string Add(Component c)
        {
            return "Não é possível adicionar elementos a este componente";
        }
        
        public override string Remove(Component c)
        {
            return "Não é possível remover elemento";
        }

        public override string Display()
        {
           return _name;
        }
    }
}
