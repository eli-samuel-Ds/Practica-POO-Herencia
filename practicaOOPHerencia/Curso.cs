using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Curso
    {
        //Atributos
        private string Nombre { get; set; }
        private int RecuentoClases { get; set; }
        private int RecuentoEjercicios { get; set; }

        //Constructor
        public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
        {
            this.Nombre = nombre;
            this.RecuentoClases = recuentoClases;
            this.RecuentoEjercicios = recuentoEjercicios;
        }

        //Comportamientos
        public int ActualizarRecuentoClases(int nuevasClases)
        {
            return RecuentoClases = nuevasClases;
        }

        public int ActualizarRecuentoEjercicios(int nuevasClases)
        {
            return RecuentoEjercicios = nuevasClases;
        }

        public string VerDetalles()
        {
            return $"Nombre: {Nombre}, Recuento de Clases: {RecuentoClases}, " +
                $"Recuento de Ejercicios: {RecuentoEjercicios}";
        }
    }
}
