using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFiguras
{
    class Circulo : Figura
    {
        public Circulo(double radio) : base(radio, radio) { }

        public override double CalcularArea()
        {
            return 3.14 * Ancho * Ancho;
        }
    }
}
