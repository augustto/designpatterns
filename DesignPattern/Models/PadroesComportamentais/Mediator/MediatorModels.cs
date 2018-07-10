using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediatorModels
{

    public abstract class Mediator
    {
        public abstract string Send(string message, Colleague colleague);
    }

    //Concrete Mediator
    public class ConcreteMediator : Mediator
    {
        private Suporte _suporte;
        private Usuario _usuario;

        public Suporte Suporte
        {
            set { _suporte = value; }
        }

        public Usuario Usuario
        {
            set { _usuario = value; }
        }

        public override string Send(string message, Colleague colleague)
        {
            if (colleague == _usuario)
               return _suporte.Notify(message);
            else
               return _usuario.Notify(message);

        }
    }

    // Colleague (abstract)
    public abstract class Colleague
    {
        protected Mediator _mediator;
        // Construtor
        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }

    // Concrete Colleague
    public class Suporte : Colleague
    {
        public Suporte(Mediator mediator)
            : base(mediator)
        {
        }
        public string Send(string mensagem)
        {
            return _mediator.Send(mensagem, this);
        }
        public string Notify(string message)
        {
            return "Suporte recebeu a mensagem: " + message;
        }
    }

    // Concrete Colleague
    public class Usuario : Colleague
    {
        public Usuario(Mediator mediator)
            : base(mediator)
        {
        }
        public string Send(string message)
        {
           return _mediator.Send(message, this);
        }
        public string Notify(string message)
        {
            return "Usuário recebeu a mensagem: " + message;
        }
    }

}