using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ObjectPoolPattern
{
    public abstract class ObjectPool<T>
    {
        private double expirationTime;
        private Dictionary<T, double> locked;
        private Dictionary<T, double> unlocked;

        public ObjectPool()
        {
            expirationTime = 30000; // 30 segundos
            locked = new Dictionary<T, double>();
            unlocked = new Dictionary<T, double>();
        }

        protected abstract T create();

        public abstract Boolean validate(T o);

        public abstract void expire(T o);

        public T checkOut()
        {
            double now = DateTime.Now.Ticks;
            T t;//variavel genérica que sera retornada
            if(unlocked.Count > 0)
            {
                IEnumerator<T> e = unlocked.Keys.GetEnumerator();
                while(e.MoveNext())
                {
                    t = e.Current;
                    if((now - unlocked[t]) > expirationTime)
                    {
                        unlocked.Remove(t);
                        expire(t);
                        t = default(T);
                    }
                    else
                    {
                        if(validate(t))
                        {
                            unlocked.Remove(t);
                            locked[t] = now;
                            return t;
                        }
                        else
                        {
                            unlocked.Remove(t);
                            expire(t);
                            t = default(T);
                        }
                    }
                }
            }
            t = create();
            locked[t] = now;
            return t;
        }

        public void checkIn(T t)
        {
            locked.Remove(t);
            unlocked.Add(t, DateTime.Now.Ticks);
        }
    }
}
