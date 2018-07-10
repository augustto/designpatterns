using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCPModels
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
    }

    public class Retangulo : FormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Raio * Raio * Math.PI;
        }
    }

    public class AreaCalc
    {/*para eu não precisar modificar essa classe quando uma nova forma foi incluida, é realizado essa abstração no método calcular área
        dessa forma, é criado um único método genérico que calcula todo o tipo de forma 
        */
        public double CalcularArea(FormaGeometrica[] formas)
        {
            double area = 0;
            foreach (var forma in formas)
                area = area + forma.CalcularArea();
            return area;
        }
    }
}