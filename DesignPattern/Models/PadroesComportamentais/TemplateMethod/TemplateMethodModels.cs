using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateMethodModels
{

    // Abstract Class
    public abstract class Correcao
    {
        public abstract void Corrigir();
        public abstract void VerificarPrerequisitos();
        public abstract void EnviarDadosParaBancoDeDados();
        public abstract void LimparCorrecoesAnteriores();
        public abstract void Iniciar();

        // ***Template Method manipulando a ordem de execucao 
        public void Processar()
        {
            Iniciar();
            VerificarPrerequisitos();
            LimparCorrecoesAnteriores();
            Corrigir();
            EnviarDadosParaBancoDeDados();
        }
    }

    // Concrete Class
    public class CorrecaoProva : Correcao
    {
        public override void Iniciar()
        {
            WriterMessages.AmarzenaMSG(this, "Iniciando correção de Prova...");
        }

        public override void Corrigir()
        {
            WriterMessages.AmarzenaMSG(this, "Corrigindo prova...");
        }

        public override void VerificarPrerequisitos()
        {
            WriterMessages.AmarzenaMSG(this, "Verificando pré-requisitos...");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            WriterMessages.AmarzenaMSG(this, "Enviando dados para o BD...");
        }

        public override void LimparCorrecoesAnteriores()
        {
            WriterMessages.AmarzenaMSG(this, "Limpando dados anteriores do BD...");
        }
    }

    // Concrete Class
    public class CorrecaoRedacao : Correcao
    {
        public override void Iniciar()
        {
            WriterMessages.AmarzenaMSG(this, "Iniciando correção de Redação...");
        }

        public override void Corrigir()
        {
            WriterMessages.AmarzenaMSG(this, "Corrigindo redação...");
        }

        public override void VerificarPrerequisitos()
        {
            WriterMessages.AmarzenaMSG(this, "Verificando pré-requisitos...");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            WriterMessages.AmarzenaMSG(this, "Enviando dados para o BD...");
        }

        public override void LimparCorrecoesAnteriores()
        {
            WriterMessages.AmarzenaMSG(this, "Limpando dados anteriores do BD...");
        }
    }
}
