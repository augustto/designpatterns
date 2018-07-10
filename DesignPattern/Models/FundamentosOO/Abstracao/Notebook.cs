
namespace Abstracao
{
    public abstract class USB
    {
        public abstract void Plugar();
    }

    public class iPhone : USB
    {
        public override void Plugar(){}
    }

    public class Mouse : USB
    {
        public override void Plugar(){}
    }

    public class Teclado : USB
    {
        public override void Plugar(){}
    }

    public class Tablet : USB
    {
        public override void Plugar(){}
    }


    public class Notebook
    {
        public string Modelo { get; }

        public USB Porta1 { get; set; }//associação 
        public USB Porta2 { get; set; }
        public USB Porta3 { get; set; }

        public Notebook(string Modelo)
        {
            this.Modelo = Modelo;
        }
    }


}
