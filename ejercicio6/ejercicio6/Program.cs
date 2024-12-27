using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" aplica el descuento");
            Console.WriteLine();

            double cantidad, precio, importe, itbis, descuento, totalGeneral;

            Console.Write("Introduzca la cantidad de artículos: ");
            cantidad = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca el precio del artículo: ");
            precio = Convert.ToDouble(Console.ReadLine());

            importe = cantidad * precio;

            itbis = importe * 0.18;

            descuento = importe * 0.10;

            totalGeneral = (importe - descuento) + itbis;


            Console.WriteLine("\nImporte del artículo: {0:C}", importe);
            Console.WriteLine("ITBIS (18%): {0:C}", itbis);
            Console.WriteLine("Descuento (10%): {0:C}", descuento);
            Console.WriteLine("Total general: {0:C}", totalGeneral); 


        }
    }
}
