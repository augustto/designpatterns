using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
note que é realizado alguns segregaçoes na interface arquivo, que gerou IReditar, IImprimir... para cada interface dessa ser atribuita
para seu elemento específico, pois se ficasse apenas na abstração "arquivo" para todos elementos que são um arquivo teriam que implementar todos os métod, 
exemo a classe Musica implementar a interface Imprimir.
*/

namespace ISPModels
{
    public interface IImprimir
    {
        void Imprimir();
    }

    public interface IEditar
    {
        void Editar();
    }

    public interface IReproduzir
    {
        void Reproduzir();
    }

    public interface IVisualizar
    {
        void Visualizar();
    }

    public interface IArquivo
    {
        void Abrir();
        void Fechar();
    }

    public class Arquivo : IArquivo
    {
        public string Nome { get; set; }
        public int Tamanho { get; set; }

        public void Abrir()
        {
            //
        }

        public void Fechar()
        {
            //
        }
    }

    public class Musica : Arquivo, IReproduzir
    {
        public string Artista { get; set; }


        public void Reproduzir()
        {
            throw new NotImplementedException();
        }
    }

    public class Documento : Arquivo, IVisualizar, IImprimir
    {
        public string Titulo { get; set; }

        public void Visualizar()
        {
            //
        }

        public void Imprimir()
        {
            //
        }
    }

    public class Foto : Arquivo, IVisualizar, IImprimir
    {
        public string Resolucao { get; set; }

        public void Visualizar()
        {
            WriterMessages.AmarzenaMSG(this, "Visualizando foto " + Nome);
        }

        public void Imprimir()
        {
            //
        }
    }
}