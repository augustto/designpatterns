using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPattern.Models.Util
{
    public class WriterMessages //classe criada apenas para simular console.writeline na web, o get retorna tudo que foi escrito.
    {
        static private string str = "";

        public static void AmarzenaMSG(Object classCall, string msg)
        {
            str += "<br>[" + classCall.GetType().Name + "] - " + msg;
        }

        public static string GetAllMessages()
        {
            return str;
        }
    }
}