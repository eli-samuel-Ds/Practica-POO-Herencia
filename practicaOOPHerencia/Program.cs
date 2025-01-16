using System;
using practicaOOPHerencia;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa De Clases de Estudiantes y Profesores");

            //Estudiantes
            Estudiante estudiante1 = new Estudiante("Juan", 123);
            Estudiante estudiante2 = new Estudiante("Lucas", 133);

            //Profesores
            Profesor profesor1 = new Profesor("Pedro");
            Profesor profesor2 = new Profesor("Paco");

            //Cursos
            Curso curso1 = new Curso("Matematicas", 10, 20);
            Curso curso2 = new Curso("Fisica", 15, 30);

            //Clases
            Clase clase1 = new Clase("Clase 1");

            clase1.AgregarEstudiante(estudiante1);
            clase1.AgregarEstudiante(estudiante2);

            clase1.AgregarProfesor(profesor1);
            clase1.AgregarProfesor(profesor2);

            //Imprimiendo Informacion
            Console.WriteLine($"Clase: {clase1.Id}");

            Console.WriteLine($"Listado de Profesores:");
            foreach (var profesor in clase1.Profesores)
            {
                Console.WriteLine($"- {profesor.Nombre}");
            }

            Console.WriteLine("\nListado de Estudiantes");
            foreach (var estudiante in clase1.Estudiantes)
            {
                Console.WriteLine($"- {estudiante.Nombre} Numero Unico: {estudiante.NumeroUnico}");
            }

            Console.ReadKey();
        }
    }
}