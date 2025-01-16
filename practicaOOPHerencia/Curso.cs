using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOOPHerencia
{
    internal class Curso
    {
        public string Nombre { get; private set; }
        public int RecuentoClases { get; private set; }
        public int RecuentoEjercicios { get; private set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
        {
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }

        public void ActualizarRecuentoClases(int nuevasClases)
        {
            RecuentoClases = nuevasClases;
        }

        public void ActualizarRecuentoEjercicios(int nuevosEjercicios)
        {
            RecuentoEjercicios = nuevosEjercicios;
        }

        public string VerDetalles()
        {
            return $"Nombre: {Nombre}, Recuento de Clases: {RecuentoClases}, Recuento de Ejercicios: {RecuentoEjercicios}";
        }
    }
}
