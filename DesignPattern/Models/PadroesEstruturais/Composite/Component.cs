using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Component
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            this._name = name;
        }

        public abstract string Add(Component c);
        public abstract string Remove(Component c);
        public abstract string Display();
    }
}
