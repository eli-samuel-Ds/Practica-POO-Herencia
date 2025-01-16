using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFiguras
{
    abstract class Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Figura(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public abstract double CalcularArea();
    }

}
