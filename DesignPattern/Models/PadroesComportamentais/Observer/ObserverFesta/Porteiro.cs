using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta
{
    public class Porteiro
    {
        private List<ChegadaAniversarianteObserver> Observers;

        public Porteiro()
        {
            Observers = new List<ChegadaAniversarianteObserver>();
        }
        public void AddChegadaAniversarianteObserver(ChegadaAniversarianteObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void VerificarSeOMoradorEOAniversariante()
        {
            Random rnd = new Random();
            int chegou = 0;
            while (chegou != 45){
                chegou = rnd.Next(50); //aqui é só demorar um pouco para chamar o evento
                if(chegou == 45)
                {
                    ChegadaAniversarianteEvent evento = new ChegadaAniversarianteEvent(DateTime.Now);
                    foreach (var observer in Observers)
                    {
                        observer.Chegou(evento);
                    }
                }
            }
        }
      
    }
}