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

        //Comportamientos
        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Remove(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        public void EliminarProfesor(Profesor profesor)
        {
            Profesores.Remove(profesor);
        }

        public string VeDetalles()
        {
            return $"Clase: {Id}, Estudiantes: {Estudiantes.Count}, Profesores: {Profesores.Count}";
        }
    }
}
