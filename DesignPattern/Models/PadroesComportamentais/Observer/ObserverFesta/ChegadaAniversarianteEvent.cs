using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.PadroesComportamentais.Observer.ObserverFesta
{   
    //classe define todas as informaçoes relevantes do evento, ela carrega os dados do evento, quem disparou, hora do disparo e tudo que for pertinente ao evento
    //cada tipo de tem suas proprias informacoes, por exemplo, o envento do mouse tem um conjunto de informaçoes específica, por exemplo qual tecla do mouse foi pressionada
    public class ChegadaAniversarianteEvent
    {
        public DateTime HoraChegada { get; set; }
        public ChegadaAniversarianteEvent(DateTime HoraChegada)
        {
            this.HoraChegada = HoraChegada;
        }
    }
}