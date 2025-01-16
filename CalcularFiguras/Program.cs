using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcularFiguras;

namespace MyApp
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Area De Las Figuras: \n");
            Figura[] figuras = new Figura[3];
            figuras[0] = new Rectangulo(5, 10);
            figuras[1] = new Triangulo(4, 6);
            figuras[2] = new Circulo(3);

            for (int i = 0; i < figuras.Length; i++)
            {
                Console.WriteLine("Área de la figura {0}: {1}", figuras[i].GetType().Name, figuras[i].CalcularArea());
            }

            Console.ReadKey();
        }
    }

}