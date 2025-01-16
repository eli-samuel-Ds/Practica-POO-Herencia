using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Estudiante : Persona
    {
        //Atributos
        private int NumeroUnico;

        //Constructor
        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            this.NumeroUnico = numeroUnico;
        }

        //Comportamientos
        public string VerInformacion()
        {
            return $"Nombre: {Nombre}, Numero Unico: {NumeroUnico}";
        }
    }
}
