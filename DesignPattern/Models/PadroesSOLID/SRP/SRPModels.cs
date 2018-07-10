using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRPModels
{
    public interface IDAOProduto
    {
        void Salvar(Produto produto);
        void Excluir(Produto produto);
        void Incluir(Produto produto);
        void Atualizar(Produto produto);
        List<Produto> Listar();
    }

    public class DAOProduto : IDAOProduto
    {
        public void Salvar(Produto produto)
        {
            // Implementação 
        }
        public void Excluir(Produto produto)
        {
            //Implementação
        }
        public void Incluir(Produto produto)
        {
            //Implementação
        }
        public void Atualizar(Produto produto)
        {
            //Implementação
        }
        public List<Produto> Listar()
        {
            //Implementação
            return null;
        }
    }

    public class Produto //POCO
    {
        public int CodProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public IDAOProduto DAO { get; set; }
        public Produto(IDAOProduto dao)
        {
            this.DAO = dao;
        }
    }
}