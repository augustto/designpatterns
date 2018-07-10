using System;
namespace Interfaces
/*
- Principio básico da POO: programar para interfaces -> abstrações.
    • - abstração: algo abstrato, que só existe na ideia, no conceito.
    • - interface: contrato(classe) de métodos, quem assim, é obrigado a implementar seus métodos.
    • - metódo com a prop 'virtual' obriga quem herda/extende a classe a dar um override no mesmo.
*/

{
    public interface IEditar
    {
        void Editar();
    }

    public interface IImprimir
    {
        void Imprimir();
    }

    public abstract class Arquivo
    {
        public int TamanhoArquivo { get; set; }
        public string Descricao { get; set; }

        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo " + Descricao + "...");
        }
    }

    public class MP3: Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Tocando arquivo MP3 " + Descricao + "...");
        }
    }
    public class Foto: Arquivo, IImprimir, IEditar
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando imagem " + Descricao + "...");
        }

        public void Imprimir()
        {
            //
        }

        public void Editar()
        {
            //
        }
    }
    public class Documento: Arquivo, IEditar, IImprimir
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Exibindo documento " + Descricao + "...");
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
