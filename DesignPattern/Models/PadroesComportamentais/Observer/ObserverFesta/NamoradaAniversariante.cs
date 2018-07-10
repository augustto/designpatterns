using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta
{
    public class NamoradaAniversariante : ChegadaAniversarianteObserver
    {
        public void Chegou(ChegadaAniversarianteEvent evento)
        {
            WriterMessages.AmarzenaMSG(this, "Apagar Luzes");
            WriterMessages.AmarzenaMSG(this, "Fazer silencio");
            WriterMessages.AmarzenaMSG(this, "Surpresa!");
        }
    }
}