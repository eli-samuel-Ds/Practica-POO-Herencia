using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Profesor : Persona
    {
        public List<Curso> Cursos { get; private set; }

        public Profesor(string nombre) : base(nombre)
        {
            Cursos = new List<Curso>();
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public string VerCursos()
        {
            string cursosDetalles = "";
            foreach (var curso in Cursos)
            {
                cursosDetalles += curso.VerDetalles() + "\n";
            }

            return cursosDetalles;
        }
    }
}
