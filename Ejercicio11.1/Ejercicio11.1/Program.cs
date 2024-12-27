using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lunes, martes, miercoles, jueves, viernes;
            int totalProduccion;
            double promedio;
            int incentivo = 0;

            
            Console.WriteLine("Introduce la producción del lunes: ");
            lunes = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la producción del martes: ");
            martes = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la producción del miércoles: ");
            miercoles = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la producción del jueves: ");
            jueves = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la producción del viernes: ");
            viernes = int.Parse(Console.ReadLine());

           
            totalProduccion = lunes + martes + miercoles + jueves + viernes;
            promedio = totalProduccion / 5.0;

           
            Console.WriteLine("Total de la producción de la semana: " + totalProduccion);
            Console.WriteLine("Promedio de la producción diaria: " + promedio);

            
            if (promedio >= 20000)
            {
                incentivo = 3000;
                Console.WriteLine("Incentivo correspondiente: " + incentivo + " pesos");
            }
            else
            {
                Console.WriteLine("Incentivo: N/A");
            }
        }
    }
}
