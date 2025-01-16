using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Profesor : Persona
    {
        //Atributos
        private List<Curso> Curso { get; set; }

        //Constructor
        public Profesor(string nombre) : base(nombre)
        {
            this.Curso = new List<Curso>();
        }

        //Comportamientos
        public void AgregarCurso(Curso curso)
        {
            Curso.Add(curso);
        }

        public string VerCursos()
        {
            string cursos = "";
            foreach (Curso curso in Curso)
            {
                cursos += curso.VerDetalles() + "\n";
            }
            return cursos;
        }
    }
}
