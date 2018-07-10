using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    // Invoker
    public class Formulario
    {
        private Command _command;

        public void setCommand(Command command)
        {
            this._command = command;
        }

        public void ClickValidate()
        {
            Console.WriteLine("Invoker: Validando usuário");
            _command.Execute();
        }
    }
}
