using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string nombre;
            double sueldo;
            double descuentoAFP, descuentoSFS, ISR, sueldoNeto;

            
            Console.WriteLine("Introduce el nombre del empleado: ");
            nombre = Console.ReadLine();

            
            Console.WriteLine("Introduce el sueldo del empleado: ");
            sueldo = double.Parse(Console.ReadLine());

            descuentoAFP = sueldo * 0.0287; 
            descuentoSFS = sueldo * 0.0304; 

            
            Console.WriteLine($"Descuento de AFP: {descuentoAFP:F2} DOP");
            Console.WriteLine($"Descuento de SFS: {descuentoSFS:F2} DOP");

            if (sueldo <= 416220)
            {
                ISR = 0; 
                Console.WriteLine("ISR: No Aplica");
            }
            else if (sueldo <= 624329)
            {
                ISR = (sueldo - 416220) * 0.15; 
            }
            else if (sueldo <= 867123)
            {
                ISR = 31216 + (sueldo - 624329) * 0.20; 
            }
            else
            {
                ISR = 79776 + (sueldo - 867123) * 0.25; 
            }

           
            sueldoNeto = sueldo - descuentoAFP - descuentoSFS - ISR;

            
            Console.WriteLine($"Sueldo: {sueldo:F2} DOP");
            Console.WriteLine($"Descuento de AFP: {descuentoAFP:F2} DOP");
            Console.WriteLine($"Descuento de SFS: {descuentoSFS:F2} DOP");
            Console.WriteLine($"ISR: {ISR:F2} DOP");
            Console.WriteLine($"Sueldo neto: {sueldoNeto:F2} DOP");
        }
    }
}
    
