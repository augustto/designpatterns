using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    // Iterator
    public abstract class Iterator
    {
        public abstract Object First();
        public abstract Object Next();
        public abstract bool IsDone();//verifica se chegou no fim
        public abstract Object CurrentItem();
    }

    // Aggregate
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    // Concrete Aggregate
    public class Equipe : Aggregate
    {
        private List<string> _items = new List<string>();
        
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        // indexer, this a get/set by ID
        public Object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, (string)value); }
        }
    }

    public class ConcreteIterator : Iterator
    {
        private Equipe _aggregate;

        private int current = 0;

        public ConcreteIterator(Equipe aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            Object ret = null;
            if (current < _aggregate.Count - 1)
                ret = _aggregate[++current];
            return ret;
        }

        public override bool IsDone()
        {
            return current >= _aggregate.Count ? true:false;
        }

        public override object CurrentItem()
        {
            return _aggregate[current];
        }
    }
}
