using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFiguras
{
    class Rectangulo : Figura
    {
        public Rectangulo(double ancho, double alto) : base(ancho, alto) { }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }
}
