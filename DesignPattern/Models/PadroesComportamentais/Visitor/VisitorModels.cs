using DesignPattern.Models.Util;
using System.Collections.Generic;

namespace VisitorModels
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
            ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
            ConcreteElementB concreteElementB);
    }

    //Concrete Visitor 1
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            WriterMessages.AmarzenaMSG(this, string.Format("{0} visitado por {1}", concreteElementA.GetType().Name, this.GetType().Name));
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            WriterMessages.AmarzenaMSG(this, string.Format("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name));
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            WriterMessages.AmarzenaMSG(this, string.Format("{0} visitado por {1}", concreteElementA.GetType().Name, this.GetType().Name));
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            WriterMessages.AmarzenaMSG(this, string.Format("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name));
        }
    }

    //Element's (aceitam os visitors)
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    // Concrete Element A
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }

    // Concrete Element B
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }

    // Object Structure
    public class ObjectStrutcture
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void DeAttach(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in _elements)
                e.Accept(visitor);
        }
    }
}