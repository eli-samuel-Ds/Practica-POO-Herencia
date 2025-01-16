using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
