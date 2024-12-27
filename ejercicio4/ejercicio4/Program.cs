using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la calificación del estudiante: ");
            int calificacion = int.Parse(Console.ReadLine());
            string situacion = "";

            if (calificacion >= 90 && calificacion <= 100)
                situacion = "Excelente";
            else if (calificacion >= 80 && calificacion <= 89)
                situacion = "Muy bueno";
            else if (calificacion >= 75 && calificacion <= 79)
                situacion = "Bueno";
            else if (calificacion >= 70 && calificacion <= 74)
                situacion = "Regular";
            else
                situacion = "Deficiente";

            Console.WriteLine("Calificación: " + calificacion);
            Console.WriteLine("situacion: " + situacion);
                

        }
    }
}
