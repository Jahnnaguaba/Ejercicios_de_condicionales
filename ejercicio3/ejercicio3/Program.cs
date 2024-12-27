using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nota1, nota2, nota3, nota4;

            Console.WriteLine("Introduce las 4 notas del estudiante: ");
             nota1 = int.Parse(Console.ReadLine());
             nota2 = int.Parse(Console.ReadLine());
             nota3 = int.Parse(Console.ReadLine());
             nota4 = int.Parse(Console.ReadLine());

            int promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio >= 70)
                Console.WriteLine("Promedio: " + promedio + ", Aprobado.");
            else
                Console.WriteLine("Promedio: " + promedio + ", Reprobado.");

        }
    }
}
