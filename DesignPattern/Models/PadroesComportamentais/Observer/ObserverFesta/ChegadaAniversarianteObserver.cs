using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta
{   
    //todos interessados nesse evento tem que implementar essa classe
    public interface ChegadaAniversarianteObserver
    {
        void Chegou(ChegadaAniversarianteEvent evento);
    }
}