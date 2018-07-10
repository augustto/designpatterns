using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterpreterModels
{
    // "Context"
    public class Context
    {

    }

    // "Abstract Expression"
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    // "Terminal Expression"
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            WriterMessages.AmarzenaMSG(this, "Chamado método TerminalExpression.Interpret()");
        }
    }

    // "Nonterminal Expression"
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            WriterMessages.AmarzenaMSG(this,"Chamado método NonterminalExpression.Interpret()");
        }
    }

}