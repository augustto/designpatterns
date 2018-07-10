using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta
{
    public class AvoAniversariante : ChegadaAniversarianteObserver
    {
        public void Chegou(ChegadaAniversarianteEvent evento)
        {
            WriterMessages.AmarzenaMSG(this, "Parabéns neto!");
        }
    }
}