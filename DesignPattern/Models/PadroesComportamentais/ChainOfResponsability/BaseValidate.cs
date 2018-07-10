using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    // Handler
    public abstract class IValidate
    {
        protected IValidate _sucessor;

        public void setSucessor(IValidate sucessor)
        {
            this._sucessor = sucessor;
        }

        public abstract bool ValidateUser(string name, string password);
    }
}
