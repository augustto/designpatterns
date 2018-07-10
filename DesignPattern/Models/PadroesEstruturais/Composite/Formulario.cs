using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Composite
    public class Formulario : Component
    {
        private List<Component> _children = new List<Component>();

        public Formulario(string name)
            : base(name)
        {
        }

        public override string Add(Component c)
        {
            this._children.Add(c);
            return "";
        }

        public override string Remove(Component c)
        {
            this._children.Remove(c);
            return "";
        }

        public override string Display()
        {

            string retorno = _name;
            foreach (var c in _children)
            {
                retorno += "<br>" + c.Display();
            }
            return retorno;
        }
    }
}
