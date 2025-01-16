using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Estudiante : Persona
    {
        public int NumeroUnico { get; private set; }

        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }

        public string VerInformacion()
        {
            return $"Nombre: {Nombre}, Número Único: {NumeroUnico}";
        }
    }
}
