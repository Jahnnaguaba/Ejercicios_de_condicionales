using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo;
            int numHijos;
            int incentivo = 0;

           
            Console.WriteLine("Introduce el sueldo del empleado: ");
            sueldo = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Introduce el número de hijos del empleado: ");
            numHijos = int.Parse(Console.ReadLine());

            
            if (numHijos > 0)
            {
                incentivo = numHijos * 500;
                Console.WriteLine("Sueldo del empleado: " + sueldo);
                Console.WriteLine("Número de hijos: " + numHijos);
                Console.WriteLine("Incentivo correspondiente: " + incentivo + " pesos");
            }
            else
            {
              
                Console.WriteLine("Sueldo del empleado: " + sueldo);
                Console.WriteLine("No tiene hijos, por lo tanto, no hay incentivo.");
            }
        }
    }
}
    

