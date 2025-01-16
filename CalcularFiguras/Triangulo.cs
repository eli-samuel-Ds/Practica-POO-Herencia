using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFiguras
{
    class Triangulo : Figura
    {
        public Triangulo(double ancho, double alto) : base(ancho, alto) { }

        public override double CalcularArea()
        {
            return (Ancho * Alto) / 2;
        }
    }
}
