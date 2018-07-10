using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MementoModels
{

    // Originator
    public class Pessoa
    {
        private string _state;// estado do objeto
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public string setMemento(Memento memento)
        {
            State = memento.State;
            return "<br>Estado do memento restaurado(setMemento)<br>";
        }
    }

    // Memento
    public class Memento //guarda  o estado atual do objeto
    {
        private string _state;
        public Memento(string state)
        {
            _state = state;
        }
        public string State
        {
            get { return _state; }
        }
    }

    // Caretaker - guarda uma referencia para o memento
    public class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }

}