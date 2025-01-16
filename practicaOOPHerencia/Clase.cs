using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Clase
    {
        //Atributos
        private string Id { get; set; }
        private List<Estudiante> Estudiantes { get; set; }
        private List<Profesor> Profesores { get; set; }

        //Constructor
        public Clase(string id)
        {
            this.Id = id;
            this.Estudiantes = new List<Estudiante>();
            this.Profesores = new List<Profesor>();
        }


    }
}
