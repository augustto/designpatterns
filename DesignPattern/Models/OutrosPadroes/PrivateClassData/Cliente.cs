using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClassDataModels
{
    public class Cliente
    {
        private ClienteData _clienteData;

        public Cliente(int codigo, string nome, string cpf, string contato, string telefone)
        {
            this._clienteData = new ClienteData(codigo, nome, cpf, contato, telefone);

        }

        public void MostrarCliente()
        {
            WriterMessages.AmarzenaMSG(this, _clienteData.Nome);
        }

        public void MostrarContatoCliente()
        {
            WriterMessages.AmarzenaMSG(this, _clienteData.Contato);
        }
    }

    public class ClienteData
    {
        private int _codigo;
        private string _nome;
        private string _cpf;
        private string _contato;
        private string _telefone;

        public ClienteData(int codigo, string nome, string cpf, string contato, string telefone)
        {
            this._codigo = codigo;
            this._nome = nome;
            this._cpf = cpf;
            this._contato = contato;
            this._telefone = telefone;
        }

        public int Codigo
        {
            get { return this._codigo; }
        }

        public string Nome
        {
            get { return this._nome; }
        }

        public string CPF
        {
            get { return this._cpf; }
        }

        public string Contato
        {
            get { return this._contato; }
        }

        public string Telefone
        {
            get { return this._telefone; }
        }
    }
}
