using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepItSimpleAndYAGNIModels.cs
{
    public interface IObserver
    {
        void update(ISubject subject);
    }

    public interface ISubject
    {
        void attach(IObserver observer);

        void deattach(IObserver observer);

        void notifyObservers();
    }

    // Concrete Subject
    public class OlaMundoSubject : ISubject
    {
        private List<IObserver> observers;
        private string str;

        public OlaMundoSubject()
        {
            observers = new List<IObserver>();
        }

        public void attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void deattach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public string getStr()
        {
            return str;
        }

        public void notifyObservers()
        {
            foreach (var o in observers)
                o.update(this);
        }

        public void setStr(string value)
        {
            str = value;
            notifyObservers();
        }
    }

    public class OlaMundoObserver : IObserver
    {
        public void update(ISubject subject)
        {
            OlaMundoSubject sub = (OlaMundoSubject)subject;
            Console.WriteLine(sub.getStr());
        }
    }

    public interface ICommand
    {
        void execute();
    }

    public class OlaMundoCommand : ICommand
    {
        private OlaMundoSubject _subject;

        public OlaMundoCommand(ISubject subject)
        {
            this._subject = (OlaMundoSubject)subject;
        }

        public void execute()
        {
            _subject.setStr("Olá Mundo!");
        }
    }

    public interface IAbstractFactory
    {
        ISubject createSubject();
        IObserver createObserver();
        ICommand createCommand(ISubject subject);
    }

    // Concrete Factory
    public class OlaMundoFactory : IAbstractFactory
    {
        public ISubject createSubject()
        {
            return new OlaMundoSubject();
        }

        public IObserver createObserver()
        {
            return new OlaMundoObserver();
        }

        public ICommand createCommand(ISubject subject)
        {
            return new OlaMundoCommand(subject);
        }
    }

    public class OlaMundoSingleton
    {
        private static OlaMundoSingleton _instance;
        private IAbstractFactory _factory = new OlaMundoFactory();

        public static OlaMundoSingleton getInstance()
        {
            if (_instance == null)
                _instance = new OlaMundoSingleton();
            return _instance;
        }

        public IAbstractFactory getFactory()
        {
            return _factory;
        }
    }
}