using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Clase
    {
        public string Id;
        public List<Estudiante> Estudiantes;
        public List<Profesor> Profesores;

        public Clase(string id)
        {
            this.Id = id;
            this.Estudiantes = new List<Estudiante>();
            this.Profesores = new List<Profesor>();
        }

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
            // Recorrer la lista de estudiantes y crear una lista de nombres
            string estudiantesNombres = "";
            foreach (var estudiante in Estudiantes)
            {
                estudiantesNombres += estudiante.Nombre + ", ";
            }

            // Recorrer la lista de profesores y crear una lista de nombres
            string profesoresNombres = "";
            foreach (var profesor in Profesores)
            {
                profesoresNombres += profesor.Nombre + ", ";
            }

            // Eliminar la coma al final si hay elementos en las listas
            if (estudiantesNombres.Length > 0)
                estudiantesNombres = estudiantesNombres.Remove(estudiantesNombres.Length - 2);
            if (profesoresNombres.Length > 0)
                profesoresNombres = profesoresNombres.Remove(profesoresNombres.Length - 2);

            return $"Clase: {Id}\nEstudiantes ({Estudiantes.Count}): {estudiantesNombres}\nProfesores ({Profesores.Count}): {profesoresNombres}";
        }
    }
}
